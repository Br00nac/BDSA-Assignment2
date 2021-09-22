using System;
using Xunit;

namespace ClassLib.tests
{
    public class StudentTests
    {
        [Fact]
        public void Try_Change_Status_Throws_Exception()
        {

            Student stud = new Student(50293, "Bru", "Mar", new DateTime(2018, 9, 4), DateTime.MinValue, new DateTime(2021, 9, 4));

            Assert.Throws<Exception>(() => {stud.status = status.Dropout;});

        }
    }
}
