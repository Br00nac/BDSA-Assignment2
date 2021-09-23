using System;
using Xunit;
using System.Reflection;

namespace ClassLib.tests
{
    public class StudentTests
    {
        [Fact]
        public void Student_Dropout_From_Dates()
        {

            Student stud = new Student(50293, "Bru", "Mar", new DateTime(2018, 9, 4), new DateTime(2019, 4, 5), new DateTime(2021, 9, 4));
            
            string expected = @"Id: 50293, Given Name: Bru, Surname: Mar, Status: Dropout, Start Date: 9/4/2018, End Date: 4/5/2019, Graduation Date: 9/4/2021";
            Assert.Equal(expected, stud.ToString());

        }

        [Fact]
        public void Student_Active_From_Dates()
        {

            Student stud = new Student(50293, "Fre", "Wei", new DateTime(2018, 9, 4), default, new DateTime(2022, 10, 4));
            
            string expected = @"Id: 50293, Given Name: Fre, Surname: Wei, Status: Active, Start Date: 9/4/2018, End Date: 1/1/0001, Graduation Date: 10/4/2022";
            Assert.Equal(expected, stud.ToString());

        }

        [Fact]
        public void Student_New_From_Dates()
        {

            Student stud = new Student(50293, "Sim", "Gun", DateTime.Today, default, new DateTime(2022, 10, 4));
            
            string expected = $@"Id: 50293, Given Name: Sim, Surname: Gun, Status: New, Start Date: {DateTime.Today.ToString("d")}, End Date: 1/1/0001, Graduation Date: 10/4/2022";
            Assert.Equal(expected, stud.ToString());

        }

        [Fact]
        public void Student_Graduate_From_Dates()
        {

            Student stud = new Student(50293, "Emi", "Ost", new DateTime(2020, 5, 6), new DateTime(2022, 10, 4), new DateTime(2022, 10, 4));
            
            string expected = $@"Id: 50293, Given Name: Emi, Surname: Ost, Status: Graduate, Start Date: 5/6/2020, End Date: 10/4/2022, Graduation Date: 10/4/2022";
            Assert.Equal(expected, stud.ToString());

        }
    }
}
