using System.Collections.Generic;
using System.IO;

namespace CodeName308.Text
{
    internal class FrmTrustGame_Article
    {
        private (string, int) _key;
        private readonly Dictionary<(string, int), string> _contents;
        private string _path;

        private string Read(string fileName)
        {
            StreamReader reader = new StreamReader(_path + fileName);
            return reader.ReadToEnd();
        }

        public FrmTrustGame_Article()
        {
            _key = ("base", 0);
            _path = Directory.GetCurrentDirectory() + "\\Text\\FrmTrustGame\\";
            _contents = new Dictionary<(string, int), string>
            {
                { ("base",0), Read("FrmTrustGame_0.con") },
                { ("tutorial", 0),  Read("FrmTrustGame_Tutorial_0.con")},
                { ("tutorial", 1),  Read("FrmTrustGame_Tutorial_1.con")},
                { ("tutorial", 2),  Read("FrmTrustGame_Tutorial_2.con")},
                { ("tutorial", 3),  Read("FrmTrustGame_Tutorial_3.con")},
                { ("tutorial", 4),  Read("FrmTrustGame_Tutorial_4.con")}
            };
        }

        public (string, int) GetKey() => _key;

        public string Show() => _contents.TryGetValue(_key, out string res) ? res : "N/A";

        public string Show((string, int) key)
        {
            if (_contents.ContainsKey(key))
                _key = key;
            return Show();
        }
    }
}