using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    [Serializable]

    public class Words
    {
        public enum Type { noun, verb, adjective }
        public string word { set; get; }
        public List<string> translate { set; get; }
        public Type type { set; get; }
        public Words() { }
        public Words(string word, List<string> translate, Type type)
        {
            this.word = word;
            this.translate = new List <string> (translate);
            this.type = type;
        }
    }
}
