using System.Collections.Generic;

namespace Remover
{
    public abstract class RemoveBase
    {
        /// <summary>
        /// 작동 상태
        /// </summary>
        public static bool IsRunning = false;

        /// <summary>
        /// 이름
        /// </summary>
        public virtual string Name { get; set; } = string.Empty;

        /// <summary>
        /// 확장자
        /// </summary>
        public virtual List<string> Extensions { get; set; } = new List<string>();

        public virtual void GetParam(ref Dictionary<string, string> param)
        {
            param.Add(nameof(Name), Name);

            param.Add(nameof(Extensions), GetExtension());
        }

        public virtual void SetParam(Dictionary<string, string> param)
        {
            Name = param[nameof(Name)];

            SetExtension(param[nameof(Extensions)]);
        }

        /// <summary>
        /// 확장자 세미콜론 분류 설정하기
        /// </summary>
        /// <param name="extension"></param>
        public virtual void SetExtension(string extension)
        {
            Extensions.Clear();

            string[] str = extension.Split(';');
            for (int index = 0; index < str.Length; index++)
            {
                string _str = str[index].Trim();
                if (string.IsNullOrEmpty(_str))
                    continue;

                Extensions.Add(_str);
            }
        }

        /// <summary>
        /// 확장자 세미콜론 분류 가져오기
        /// </summary>
        /// <returns></returns>
        public virtual string GetExtension()
        {
            string str = "";

            for (int index = 0; index < Extensions.Count; index++)
                str += Extensions[index] + ";";

            return str;
        }
    }
}
