using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Counter
{
    class count_media
    {
        public static int img_tag_count(string file_path)
        {

            // Read File

            string readed_file = File.ReadAllText(file_path); 
            int counter = 0;

            // Counting <img> 

            for (int i = 0; i < readed_file.Length; i++)
            {
                if (i == readed_file.Length - 3)
                {
                    break;
                }
                if (readed_file[i].Equals('<') && readed_file[i + 1].Equals('i') && readed_file[i + 2].Equals('m') && readed_file[i + 3].Equals('g'))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}