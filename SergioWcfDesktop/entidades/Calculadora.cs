using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SergioWcfDesktop.entidades
{
    public class Calculadora
    {
        
        float numero1;
        public float setNumero1 {
            get { return numero1; }
            set { numero1 = value; }
        }
        
        float numero2;
        public float setNumero2 {
            get { return numero2; }
            set { numero2 = value; }
            
        }
    }
}