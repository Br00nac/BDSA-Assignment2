using System;
using Xunit;

namespace ClassLib.tests
{
    public class StudentTests
    {
        [Fact]
        public void Status_Is_Read_Only()
        {

            Student stud = new Student(50293, "Bru", "Mar", new DateTime(2018, 9, 4), DateTime.MinValue, new DateTime(2021, 9, 4));

            Assert.True(stud.get.status.IsInitOnly);

        }
    }
}
