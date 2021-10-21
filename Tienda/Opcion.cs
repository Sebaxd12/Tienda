using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public class Opcion
    {
        private int select;
   
        //constructor
        public Opcion() { }

        public Opcion(int select)
        {
            this.select = select;
        }

        public int Select { get => select; set => select = value; }

        public void showInfo()
        {
           
            string info3 = "                                            La Opcion escogida fue: " + Select + ".";
            Console.WriteLine(info3);
            

        }
    }
}
