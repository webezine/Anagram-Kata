using AnagramConsole.Models.ExtensionMethods;

namespace Models
{
    public class AnagramResult
    {

        public string WordOne { get; set; }

        public string WordTwo { get; set; }

        public bool Result { get
            {
                return this.WordOne.IsAnAnagram(this.WordTwo);
            } 
        }
    }
}
