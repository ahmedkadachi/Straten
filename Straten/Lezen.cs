using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Straten
{
    class Lezen
    {
        Dictionary<string, string> Straatnamen = new Dictionary<string, string>();
        List<string[]> strnaam = new List<string[]>();
        string[] st = new string[500];

        public void BestandLezen()
        {
            string line;
            using (StreamReader r = new StreamReader("C:/Users/Ahmed/Desktop/school/03 - Programmeren/labo/01 - straten/WRdata10.csv"))
            {
                while ((line = r.ReadLine()) != null)
                {
                    if (!line.Contains("W")) 
                    {
                        strnaam.Add(line.Split(","));
                    }
                        
                }
            }

            foreach(List<string[]> element in strnaam)
            {

            }
        }

    }
}
