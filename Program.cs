using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_task
{
    public class Person
    {
        public int id;
        public string name;
     public Person(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(1,"dhirendra");
            p.display();
            Console.ReadLine();
        }
    }
}
