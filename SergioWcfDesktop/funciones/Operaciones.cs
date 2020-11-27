using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SergioWcfDesktop.funciones
{
    public class Operaciones
    {
        public float suma(float N1, float N2) {
            float resultado = N1 + N2;
            return resultado;
        }
        public float resta(float N1, float N2)
        {
            float resultado = N1 - N2;
            return resultado;
        }
        public float multiplicacion(float N1, float N2)
        {
            float resultado = N1 * N2;
            return resultado;
        }
        public float divicion(float N1, float N2)
        {
            float resultado = N1 / N2;
            return resultado;
        }
        public float operacion(int identified,float N1, float N2)
        {
            float resultado = 0;
            if (identified == 1)
            {
                return (N1 + N2);
            }
            else
            {
                if (identified == 2)
                {
                    return (N1 - N2);
                }
                else {
                    if (identified == 3)
                    {
                        return multiplicacion(N1, N2);
                    }
                    else {
                        if (identified == 4)
                        {
                            return divicion(N1, N2);
                        }
                        else {
                            return resultado;
                        }
                    }
                }
            }
        }
    }
}