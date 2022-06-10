using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    //Inicio de clase
    class Amazon
    {
        //Campos de la clase
        public string nombre;
        public string descripcion;
        public float precio;
        public byte stock;
        //metodo constructor
        public Amazon(string nombre, string descripcion, 
            float precio, byte stock)
        {
            //diferenciar campos de parametros con this
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }
        //metodo destructor
        ~Amazon()
        {
            Console.WriteLine("Memoria Liberada Objeto Amazon");
        }  
    }
}
