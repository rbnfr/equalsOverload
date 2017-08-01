﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public string Name { get; set; }
        //Sobrecarga de operadores. Hemos alterado el operador para hacer posible una suma de strings. Le hemos dicho que si se dice de sumar a dos personas, componga la frase de que son hermanos.
        public static Person operator + (Person a, Person b)
        {
            return new Person() { Name = a.Name + " " + "y" + b.Name + " son hermanos." };
        }
        // Sobrecarga de equals
        public static Boolean operator ==(Person a, Person b)
        {
            if (a.Name == b.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public static Boolean operator !=(Person a, Person b)
        {
            return !(a.Name == b.Name);
        }
        /*public override int GetHashCode()
        {
            return ;
        }*/
    }
}