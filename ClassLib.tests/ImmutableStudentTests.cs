using System;
using Xunit;

namespace ClassLib.Tests
{
    public class ImmutableStudentTests
    {
        [Fact]
        public void Compare_equality_of_identical_records()
        {
            var immutableStudent = new ImmutableStudent(0, "Bruno", "Gamerhands", DateTime.MinValue, DateTime.MinValue, DateTime.MinValue);
            var immutableStudentTwo = new ImmutableStudent(0, "Bruno", "Gamerhands", DateTime.MinValue, DateTime.MinValue, DateTime.MinValue);
            bool same = immutableStudent == immutableStudentTwo;
            Assert.True(same);
        }

        [Fact]
        public void Compare_equality_of_identical_records_ToString()
        {
            var immutableStudent = new ImmutableStudent(0, "Bruno", "Gamerhands", DateTime.MinValue, DateTime.MinValue, DateTime.MinValue);
            var immutableStudentTwo = new ImmutableStudent(0, "Bruno", "Gamerhands", DateTime.MinValue, DateTime.MinValue, DateTime.MinValue);
            var toStringOne = immutableStudent.ToString();
            var toStringTwo = immutableStudentTwo.ToString();
            Assert.Equal(toStringOne, toStringTwo);
        }
    }
}