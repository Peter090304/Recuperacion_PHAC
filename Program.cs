namespace Recuperacion_PHAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada flota=new ListaEnlazada();
            flota.AgregarCarro(new Carro(123,"Nissan",2023));
            flota.AgregarCarro(new Carro(223, "Toyota",2022));
            flota.AgregarCarro(new Carro(412, "Mustang",2018));
            flota.AgregarCarro(new Carro(764, "BMW",2015));
            flota.AgregarCarro(new Carro(669, "Ferrari",2017));

            flota.Imprimirporaño();
            flota.OrdenarPorAño();
            Console.WriteLine($"Se encuentra el carro {flota.EncontrarCarro("Nissan")}");
            flota.EncontrarCarro("Nissan");

        }
    }
}