using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class AB
    {
        public NodoArbol? NodoRaiz { get; set; }

        string respuesta;

        public AB()

        {
            NodoRaiz = null;
        }

        bool IsEmpty() => NodoRaiz == null;


        public void PoblarArbol(NodoArbol nodoActual)
        {
            //verificar si el arbol esrta vacio
            if(IsEmpty())
            {
                nodoActual = CrearNodo();
                NodoRaiz = nodoActual;

            }
            //verificar si existe nod por la izq del nodo actual
            Console.WriteLine($"Existe nodo por la rama izquierda de {nodoActual.Informacion}?");
            respuesta = Console.ReadLine().Trim().ToLower();


            if(respuesta.Equals("s"))
            {
                nodoActual.RamaIzquierda = CrearNodo();
                PoblarArbol(nodoActual.RamaIzquierda);

            }
           
            //verificar si existe nod por laddder del nodo actual
            Console.WriteLine($"Existe nodo por la rama derecha de {nodoActual.Informacion}?");
            respuesta = Console.ReadLine().Trim().ToLower();


            if (respuesta.Equals("s"))
            {
                nodoActual.RamaDerecha = CrearNodo();
                PoblarArbol(nodoActual.RamaDerecha);

            }




        }

        NodoArbol CrearNodo()
        {
            NodoArbol nuevoNodo = new NodoArbol();
            Console.WriteLine("Ingrese info para el nodo");
            nuevoNodo.Informacion = Console.ReadLine();
            return nuevoNodo;
        }
    }
}
