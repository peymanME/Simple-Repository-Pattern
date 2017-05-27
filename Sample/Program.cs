using Sample.Models.Entities;
using Sample.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
 
            using (var context = new SampleUnitOfWork(new SampleContext()))
            {
                Random rnd = new Random();
                Console.WriteLine("Sample Insert data: ");
                // Insert data 
                Student student = context.Students.AddOrUpdate(new Student()
                {
                    FirstName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    Number = rnd.Next()
                });
                context.Complete();
                Console.WriteLine("\t\n Information of student inserted: \n First name: {0} \n Last name: {1} \n Student number: {2}",student.FirstName, student.LastName, student.Number);

                // Update data
                student.LastName = Guid.NewGuid().ToString() + "Test";
                student = context.Students.AddOrUpdate(student);
                context.Complete();
                Console.WriteLine("\t\n Information of student edited: \n First name: {0} \n Last name: {1} \n Student number: {2}", student.FirstName, student.LastName, student.Number);

                Console.WriteLine("\t\n Please press Enter key!!!");
             }

            Console.ReadLine();
        }
    }
}
