using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Straten
{
    class Lezen
    {
        
        public void BestandLezen()
        {
            string line;
            using (StreamReader r = new StreamReader("C:/Users/Ahmed/Desktop/school/03 - Programmeren/labo/01 - straten/WRdata10.csv"))
            {
                while ((line = r.ReadLine()) != null)
                {
                    line.Split()
                }
            }
        }

    }
}
