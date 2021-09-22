using System;

namespace ClassLib
{
    public class Student 
    {
        int id {get; init;}
        string givenName;
        string surname;
        status status {get; init;}
        DateTime startDate;
        DateTime endDate;
        DateTime graduationDate;

        public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;

            if(startDate.Equals(DateTime.Now)) {status = status.New;}
            else if (endDate == default) {status = status.Active;}
            else if (endDate < graduationDate) {status = status.Dropout;}
            else status = status.Graduate;
        }
        
        public override string ToString() => $@"Id: {id}, Given Name: {givenName}, Surname: {surname}, Status: {status}, 
                                             Start Date: {startDate}, End Date: {endDate}, Graduation Date: {graduationDate}";
    }

    public enum status 
    {
        New,
        Active,
        Dropout,
        Graduate
    }
}
