using AnagramConsole.Models.ExtensionMethods;

namespace Models
{
    public class AnagramResult
    {
        public AnagramResult(int id, string s1, string s2)
        {
            Id = id;
            WordOne = s1;
            WordTwo = s2;
        }

        public int Id { get; set; }

        public string WordOne { get; set; }

        public string WordTwo { get; set; }

        public bool Result { get
            {
                return this.WordOne.IsAnAnagram(this.WordTwo);
            } 
        }
    }
}
