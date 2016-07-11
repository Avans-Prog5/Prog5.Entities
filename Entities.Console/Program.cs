using Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Summary van alle workshops
            using(var context = new Entities.Domain.MyEntities())
            {
                //Niet vergeten de 'teacher' ook op te vragen!
                List<Workshop> workshops = context.Workshops.Include("Teacher").ToList();

                System.Console.WriteLine("Workshops");
                foreach(var workshop in workshops)
                {
                    System.Console.WriteLine(String.Format("# {0} - by {1}", workshop.Name, workshop.Teacher.Name));
                }
                System.Console.WriteLine(" ");

                System.Console.ReadLine();
            }
        }
    }
}
