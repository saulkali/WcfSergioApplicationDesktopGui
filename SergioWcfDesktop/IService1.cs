using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace SergioWcfDesktop
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        //nuestros metodos
        [OperationContract]
        float divicion(float N1,float N2);
        [OperationContract]
        float resta(float N1, float N2);

        [OperationContract]
        float suma(float N1, float N2);
        [OperationContract]
        float multiplicacion(float N1, float N2);
        [OperationContract]
        float operacion(int identified, float N1, float N2);
    }


    
}
