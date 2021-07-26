using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CodeName308.Storage
{
    [Serializable]
    public class InitializationNameStorage
    {
        public string User;
        public string LionKing;
        public string Betrayer;
        public string King80;
        public string Anti80;
        public string Random;
        public string NiceMan;
        public string Conspirator;
        private string _jsonPpath;

        public InitializationNameStorage()
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Storage\\");
            _jsonPpath = Directory.GetCurrentDirectory() + "\\Storage\\InitializationNameStorage.json";
        }

        public void UseDefault()
        {
            User = "主人公";
            LionKing = "獅子王";
            Betrayer = "貝古仔";
            King80 = "80王";
            Anti80 = "反80小天使";
            Random = "亂來仔";
            NiceMan = "老好人";
            Conspirator = "心機仔";
        }

        /// <summary>
        /// json序列化並儲存
        /// </summary>
        public void JsonSerialize()
        {
            string json = JsonConvert.SerializeObject(this);
            StreamWriter writer = new StreamWriter(_jsonPpath);
            writer.WriteLine(json);
            writer.Close();
        }

        /// <summary>
        /// 讀取json設定
        /// </summary>
        /// <returns></returns>
        public InitializationNameStorage JsonDeserialize()
        {
            if (!File.Exists(_jsonPpath))
            {
                UseDefault();
                return this;
            }
            StreamReader reader = new StreamReader(_jsonPpath);
            string json = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<InitializationNameStorage>(json);
        }
    }
}