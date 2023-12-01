using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_PHAC
{
    class Carro
    {
        public int Carros { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }


        public Carro(int carro, string modelo, int año)
        {
            Carros = carro;
            Modelo = modelo;
            Año = año;

        }
    }

    class Nodo
    {
        public Carro Datos { get; set; }
        public Nodo Siguiente { get; set; }
    }

    class ListaEnlazada
    {
        private Nodo cabeza;

        public void AgregarCarro(Carro carro)
        {
            Nodo nuevoNodo = new Nodo { Datos = carro, Siguiente = null };

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }


        public int EncontrarCarro(string nombre)
        {
            Nodo actual = cabeza;
            int posicion = 0;

            while (actual != null)
            {
                if (actual.Datos.Modelo == nombre)
                {
                    return posicion;
                }

                actual = actual.Siguiente;
                posicion++;
            }

            return -1;
        }

        public void Imprimirporaño()
        {
            OrdenarPorAño();
            Nodo actual = cabeza;

            while (actual != null)
            {
                Console.WriteLine($"Nombre:{actual.Datos.Modelo},Año:{actual.Datos.Año}");
                actual = actual.Siguiente;
            }
        }

        public void OrdenarPorAño()
        {
            if (cabeza == null || cabeza.Siguiente == null)
            {
                return;
            }

            Nodo actual = cabeza;

            while (actual != null)
            {
                Nodo siguiente = actual.Siguiente;

                while (siguiente != null)
                {
                    if (actual.Datos.Año < siguiente.Datos.Año)
                    {
                        Carro temp = actual.Datos;
                        actual.Datos = siguiente.Datos;
                        siguiente.Datos = temp;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
            }
        }

    }



}


