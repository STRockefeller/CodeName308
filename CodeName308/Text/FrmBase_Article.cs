using System.Collections.Generic;
using System.IO;

namespace CodeName308.Text
{
    internal class FrmBase_Article
    {
        private int _id;
        private readonly Dictionary<int, string> _contents;
        private string _path;

        private string Read(string fileName)
        {
            StreamReader reader = new StreamReader(_path + fileName);
            return reader.ReadToEnd();
        }

        public FrmBase_Article()
        {
            _id = 0;
            _contents = new Dictionary<int, string>();
            _path = Directory.GetCurrentDirectory() + "\\Text\\FrmBase\\";
            _contents.Add(0, Read("FrmBase_0.con"));
            _contents.Add(1, Read("FrmBase_1.con"));
        }

        public string Show()
        {
            return _contents.TryGetValue(_id, out string res) ? res : "N/A";
        }

        public string Show(int id)
        {
            if (_contents.ContainsKey(id))
                _id = id;
            return Show();
        }

        public string Next()
        {
            if (_contents.ContainsKey(_id + 1))
                _id++;
            return Show();
        }

        public string Previous()
        {
            if (_contents.ContainsKey(_id - 1))
                _id--;
            return Show();
        }
    }
}