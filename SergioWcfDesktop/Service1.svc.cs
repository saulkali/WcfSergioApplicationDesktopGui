using SergioWcfDesktop.funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SergioWcfDesktop
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        Operaciones ope = new Operaciones();
        public float suma(float N1,float N2) {
            return ope.suma(N1,N2);
        }
        public float resta(float N1, float N2)
        {
            return ope.resta(N1, N2);
        }
        public float multiplicacion(float N1, float N2)
        {
            return ope.multiplicacion(N1, N2);
        }
        public float divicion(float N1, float N2)
        {
            return ope.divicion(N1, N2);
        }
        public float operacion(int identified,float N1, float N2)
        {
            return ope.operacion(identified,N1, N2);
        }
    }
}
