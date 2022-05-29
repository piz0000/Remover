using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Remover
{
    /// <summary>
    /// 폴더
    /// </summary>
    public class RemoveFolder : RemoveBase
    {
        /// <summary>
        /// 오늘 날짜 기준 제거 시작 일 <para/>
        /// today : 2021-12-31 <para/>
        /// StartDate : 10 <para/>
        /// 제거 시작 일 : today - StartDate = 2021-12-21
        /// </summary>
        public int StartDate { get; set; } = 90;

        public DateTime StartDateTime { get => DateTime.Now.AddDays(StartDate * -1); }

        /// <summary>
        /// 하위 폴더 파일 포함 유무
        /// </summary>
        public bool IsSubDirectory { get; set; } = true;

        public Dictionary<string, string> GetParam()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("Kind", nameof(RemoveFolder));

            base.GetParam(ref param);

            param.Add(nameof(StartDate), StartDate.ToString());
            param.Add(nameof(IsSubDirectory), IsSubDirectory.ToString());

            return param;
        }

        public override void SetParam(Dictionary<string, string> param)
        {
            base.SetParam(param);

            StartDate = Convert.ToInt32(param[nameof(StartDate)]);
            IsSubDirectory = Convert.ToBoolean(param[nameof(IsSubDirectory)]);
        }

        public void Remove()
        {
            Remove(Name);
        }

        void Remove(string folder)
        {
            if (RemoveExcept.IncludePath(folder))
                return;

            //현재 폴더 파일 제거
            for (int index = 0; index < Extensions.Count; index++)
            {
                FileData[] fileDatas = FastDirectoryEnumerator.GetFiles(folder, "*." + Extensions[index], SearchOption.TopDirectoryOnly).OrderByDescending(f => f.CreationTime).ToArray();

                DateTime dtStd = StartDateTime;

                foreach (FileData info in fileDatas)
                {
                    if (IsRunning == false)
                        return;

                    if ((info.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        continue;

                    if ((info.Attributes & FileAttributes.System) == FileAttributes.System)
                        continue;

                    try
                    {
                        if (info.CreationTime < dtStd)
                        {
                            File.Delete(info.Path);
                        }
                    }
                    catch
                    {
                    }
                }
            }

            if (IsSubDirectory)
            {
                //하위 폴더
                string[] folders = Directory.GetDirectories(folder);
                foreach (string ff in folders)
                {
                    Remove(ff);
                }
            }
        }
    }
}
