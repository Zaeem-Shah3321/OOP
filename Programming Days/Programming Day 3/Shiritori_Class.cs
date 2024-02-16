using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task3
{
     class Class1
     {
        public string words;
        public bool check;
        public List<string> array;
        public Class1()
        {
            array = new List<string>();
        }
        public bool Play(string words)
        {
            if (array.Count > 0)
            {
                for (int x = 0; x < array.Count; x++)
                {
                    if (words == array[x])
                    {
                        Console.WriteLine("Word Already Written!");                     
                        return false;
                    }
                }
                string lastWord = array[array.Count - 1];
                if (words[0] == lastWord[lastWord.Length - 1])
                {                    
                    check = true;
                    array.Add(words);
                }
                else
                {                  
                    check = false;
                }
            }
            else
            {
                array.Add(words);
                return true;
            }
            return check;
        }
     }
}