using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {     
            var persons = new List<Person>() {
                new Person(){Name="Pedro"},
                new Person(){Name="Juan"},
                new Person(){Name="Fernando"},
            };

            var Pedro = new Person() { Name = "Pedro" };
            var Juan = new Person() { Name = "Pedro" };
            var hermanos = Pedro + Juan;

            var codePedro = Pedro.GetHashCode();//Obtener el número de hash
            var codeJuan = Juan.GetHashCode();
            
            var iguales = Pedro.Equals(Juan);// Devuelve false, porque no está comparando la propiedad name --> sobrecarga operador --> devuelve true si los nombres son iguales
            Console.WriteLine(iguales);
            Console.ReadLine();
        }
    }
}