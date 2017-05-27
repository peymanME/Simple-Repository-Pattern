using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.Models.Entities;
using Sample.ORM;
using Sample.Services;

namespace TestDAL
{
    [TestClass]
    public class StudentServiceTest
    {
        private Student _student;
        [TestMethod]
        public void TestInsertData()
        {
            StudentService studentService = new StudentService();
            
            Student student = new Student()
            {
                FirstName = "Peyman",
                LastName = "Ekhtiar",
                Number = 12
            };
            _student = studentService.InsertData(student);
        }
    }
}
