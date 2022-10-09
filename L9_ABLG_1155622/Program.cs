using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_ABLG_1155622
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil objAutomovil = new Automovil(2019, 10000.00, "", false, 7.50, 0.00);

            Console.WriteLine("Ingrese la marca del automóvil");
            objAutomovil.DefinirMarca(Console.ReadLine());

            Console.WriteLine("Ingrese el modelo del automóvil");
            objAutomovil.DefinirModelo(int.Parse(Console.ReadLine()));


            Console.WriteLine("Ingrese el precio del automóvil");
            objAutomovil.DefinirPrecio(double.Parse(Console.ReadLine()));

            Console.WriteLine("Ingrese el descuento que se debe aplicar");
            objAutomovil.DefinirDescuentoAplicado(double.Parse(Console.ReadLine()));


            Console.WriteLine(objAutomovil.MostrarInformacion());
            Console.ReadKey();
        }
    }

    class Automovil
    {
        private int modelo;
        private double precio;
        private string marca;
        private bool disponible;
        private double tipoCambioDolar;
        private double descuentoAplicado;

       

        public Automovil(int Modelo, double Precio, string Marca, bool Disponible, double Cambio, double DescuentoAplicado)
        {
            modelo = Modelo;
            precio = Precio;
            marca = Marca;
            disponible = Disponible;
            tipoCambioDolar = Cambio;
            descuentoAplicado = DescuentoAplicado;

        }

        public void DefinirModelo(int unModelo)
        {
            modelo = unModelo;
        }

        public void DefinirPrecio(double unPrecio)
        {
            precio = unPrecio;
        }

        public void DefinirMarca(string unMarca)
        {
            marca = unMarca;
        }

        public void DefinirTipoCambioDolar(double unTipoCambioDolar)
        {
            tipoCambioDolar = unTipoCambioDolar;
        }

        public void DefinirDescuentoAplicado(double unDescuentoAplicado)
        {
            descuentoAplicado = unDescuentoAplicado;
        }
        public void CambiarDisponibilidad()
        {
            if (disponible == true)
            {
                disponible = false;
            }
            else
            {
                disponible = true;
            }
        }

        public string MostrarDisponible()
        {
            {
                if (disponible == false)
                {
                    return "disponible";
                }
                else
                {
                    return "no disponible";
                }
            }


        }
        public string MostrarInformacion()
        {
            return "marca: " + marca + ", precio: " + precio + ", modelo: " + modelo + ", Descuento: " + descuentoAplicado + ", Tipo de Cambio " + tipoCambioDolar + ", Precio en dólares: " + (precio/7.5) + ",  " + MostrarDisponible () + ", Precio con descuento: " + (precio - descuentoAplicado) ; 
             
        }

    }
}
