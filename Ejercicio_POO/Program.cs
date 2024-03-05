using System;

namespace Ejercicio_POO
{
    public class Puerta
    {
        public string color;

        public Puerta()
        {
            color = "Café";
        }

        public Puerta(string colorInicial)
        {
            color = colorInicial;
        }

        public void SetColor(string nuevoColor)
        {
            color = nuevoColor;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Soy una Puerta, mi color es " + color + ".");
        }
    }

    public class Casa
    {
        public int area;
        public Puerta puerta;

        public Casa(int areaInicial)
        {
            area = areaInicial;
            puerta = new Puerta();
        }

        public void SetArea(int nuevaArea)
        {
            area = nuevaArea;
        }

        public void SetPuerta(Puerta nuevaPuerta)
        {
            puerta = nuevaPuerta;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Soy una Casa, mi área es " + area + " m2.");
        }
    }

    public class Apartamento : Casa
    {
        public Apartamento() : base(50) { }

        public new void MostrarDatos()
        {
            Console.WriteLine("Soy un Apartamento, mi área es " + area + " m2.");
        }
    }

    public class Persona
    {
        public string nombre;
        public Casa casa;

        public Persona()
        {
            nombre = "Juan";
            casa = new Casa(150);
        }

        public Persona(string nombrePersona, Casa casaPersona)
        {
            nombre = nombrePersona;
            casa = casaPersona;
        }

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public void SetCasa(Casa nuevaCasa)
        {
            casa = nuevaCasa;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Mi nombre es " + nombre + ".");
            casa.MostrarDatos();
            casa.puerta.MostrarDatos();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.MostrarDatos();
            persona.SetNombre("Carlos");
            Apartamento nuevoApartamento = new Apartamento();
            Puerta nuevaPuerta = new Puerta("Verde");
            nuevoApartamento.SetPuerta(nuevaPuerta);
            persona.SetCasa(nuevoApartamento);
            persona.MostrarDatos();

            Console.ReadLine();
        }
    }
}
