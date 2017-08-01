/*using System;
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
        public static Person operator ==(Person a, Person b)
        {
            return a.Name == b.Name;
        }
        public static Person operator !=(Person a, Person b)
        {
            return !(a == b);
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public String Name { get; set; }

        public Person(String name)
        {
            Name = name;
        }

        public static Boolean operator==(Person person1, Person person2)
        {
            if((person1!=null) && (person2 != null))
            {
                if (person1.Name==person2.Name) return true;
                else return false;
            }
            else
            {
                return false;
            }
        }

        public static Boolean operator !=(Person person1, Person person2)
        {
            if ((person1 != null) && (person2 != null))
            {
                if (person1.Name != person2.Name) return true;
                else return false;
            }
            else
            {
                return false;
            }
        }

        public override Boolean Equals(object o)
        {
            if (o == null) return false;

            Person p = (Person)o;
            return p.Name == Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

   
}