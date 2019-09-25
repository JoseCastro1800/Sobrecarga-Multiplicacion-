using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_carga_de_datos
{
   public class Datos
    {
        public void Obtener_Datos()
        {
            //Aqui se le da la opcion de que el usuario ingrese datos
            Console.WriteLine("Sea Bienvenido");
            Console.WriteLine("Ingrese 2 datos");
            Console.WriteLine("Dato1");

            double cool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dato2");
            double cool2 = Convert.ToDouble(Console.ReadLine());

            //Instanciar la clase operacion 
            Operacion OP = new Operacion();
            OP.Multiplicar();

            // Operacion de los metodos 
            double Res = OP.Multiplicar(cool, cool2);

            //Se manda imprimir el resultado
            Console.WriteLine("El resultado es" + Res);
            Console.ReadKey();
        }
    }
}
