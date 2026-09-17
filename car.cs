using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp
{
   public class Car
    {
        public string BR {  get; set; }
        public string TY { get; set; }

        public int BY { get; set; }
        public int HP { get; set; }
        public int Price { get; set; }

        public Car(string line)
        {
            string[] temp = line.Split(";");
            BR = temp[0];
            TY = temp[1];
            BY = int.Parse(temp[2]);
            HP = int.Parse(temp[3]);
            Price = int.Parse(temp[4]);
                
           
        }

    }
}
