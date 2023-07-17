using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEstructura
{
    internal class OperacionClase
    {
        public int num1 { get; set; }
        public int num2 { get; set; }  

        public OperacionClase(int x, int y)
        {
            this.num1 = x;
            this.num2 = y; 
        }
        public void incremento(OperacionClase e, int aumento)
        {
            e.num1 += aumento;  
            e.num2 += aumento;  
        }

        public override string ToString()
        {
            return string.Format("El valor de numero 1 y numero 2 son {0},{1}",this.num1,this.num2);
        }
    }
}
