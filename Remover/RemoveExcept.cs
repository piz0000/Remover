using System;
using System.Collections.Generic;
using System.IO;

namespace Remover
{
    /// <summary>
    /// 제외 폴더
    /// </summary>
    public static class RemoveExcept
    {
        public static List<string> Excepts { get; set; } = new List<string>();

        public static Dictionary<string, string> GetParam()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Kind", nameof(RemoveExcept));

            dic.Add("ExceptCount", Excepts.Count.ToString());

            for (int index = 0; index < Excepts.Count; index++)
                dic.Add("Except" + index, Excepts[index]);

            return dic;
        }

        public static void SetParam(Dictionary<string, string> param)
        {
            Excepts.Clear();

            int count = Convert.ToInt32(param["ExceptCount"]);

            for (int index = 0; index < count; index++)
                Excepts.Add(param["Except" + index]);
        }

        public static bool IncludePath(string path)
        {
            for (int index = 0; index < Excepts.Count; index++)
            {
                string source = Path.GetFullPath(Excepts[index]);
                string target = Path.GetFullPath(path);
                if (source == target)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
