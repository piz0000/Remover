using System;
using System.Collections.Generic;
using System.IO;

namespace Remover
{
    /// <summary>
    /// 드라이브
    /// </summary>
    public class RemoveDrive : RemoveBase
    {
        /// <summary>
        /// 용량 최저 퍼센트
        /// </summary>      
        public int PercentageLow { get; set; } = 30;

        /// <summary>
        /// 용량 최대 퍼센트
        /// </summary>      
        public int PercentageHigh { get; set; } = 90;

        DriveInfo driveInfo
        {
            get
            {
                if (string.IsNullOrEmpty(Name) || Name.Length <= 0)
                    return null;

                if (_driveInfo == null)
                    _driveInfo = new DriveInfo(Name[0].ToString());

                if (_driveInfo.Name[0] != Name[0])
                    _driveInfo = new DriveInfo(Name[0].ToString());

                return _driveInfo;
            }
        }
        DriveInfo _driveInfo = null;

        public Dictionary<string, string> GetParam()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("Kind", nameof(RemoveDrive));

            base.GetParam(ref param);

            param.Add(nameof(PercentageLow), PercentageLow.ToString());
            param.Add(nameof(PercentageHigh), PercentageHigh.ToString());

            return param;
        }
        public override void SetParam(Dictionary<string, string> param)
        {
            base.SetParam(param);

            PercentageLow = Convert.ToInt32(param[nameof(PercentageLow)]);
            PercentageHigh = Convert.ToInt32(param[nameof(PercentageHigh)]);
        }

        /// <summary>
        /// 사용 용량 퍼센트 가져오기 <para/>
        /// </summary>
        /// <returns>정상 : 0 ~ 100, <para/> 드라이브 정보 확인 : -1</returns>
        public int GetPercentage()
        {
            DriveInfo dInfo = driveInfo;
            if (dInfo != null)
            {
                double useSpace = dInfo.TotalSize - dInfo.AvailableFreeSpace;
                int PercentageValue = Convert.ToInt32(Math.Round(useSpace / dInfo.TotalSize, 2) * 100);
                return PercentageValue;
            }
            else
            {
                return -1;
            }
        }

        public void Remove()
        {
            int drivePer = GetPercentage();
            if (drivePer == -1)
                return;

            if (drivePer <= PercentageHigh)
                return;

            Remove(Name[0] + ":\\");
        }

        void Remove(string folder)
        {
            if (IsRunning == false)
                return;

            //파일 제거
            RemoveFolder remove = new RemoveFolder();
            remove.Name = folder;
            remove.IsSubDirectory = false;
            remove.Extensions = Extensions;
            remove.Remove();

            //하위 폴더
            string[] folders = Directory.GetDirectories(folder);
            foreach (string ff in folders)
            {
                DirectoryInfo info = new DirectoryInfo(ff);

                if ((info.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    continue;

                if ((info.Attributes & FileAttributes.System) == FileAttributes.System)
                    continue;

                int drivePer = GetPercentage();
                if (drivePer == -1)
                    return;

                if (drivePer <= PercentageLow)
                    return;

                Remove(ff);
            }
        }

    }
}
