using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.SorokinAD.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string str, string path)
        {

            string resStr = "";
            using (StreamReader streamreader = new StreamReader(path))
            {
                string line;
                while ((line = streamreader.ReadLine()) != null)
                {
                    string[] array = line.Split(' ');
                    if (array.Length > 0)
                    {
                        resStr += array[0] + '\n';
                    }
                }
            }
            return resStr;
        }
    }
}
