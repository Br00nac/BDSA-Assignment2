using System;

namespace ClassLib
{
    public class Student 
    {
        

        int id {get; init;}
        string givenName;
        string surname;
        readonly status status; //{get; init;}
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

            if(startDate.AddMonths(1) > DateTime.Today) {status = status.New;}
            else if (endDate == default) {status = status.Active;}
            else if (endDate < graduationDate) {status = status.Dropout;}
            else status = status.Graduate;
        }

        public status getstatus(){return status;}
        
        public override string ToString() => (@$"Id: {id}, Given Name: {givenName}, Surname: {surname}, Status: {status}, Start Date: {startDate.ToString("d")}, End Date: {endDate.ToString("d")}, Graduation Date: {graduationDate.ToString("d")}");
    }

    public enum status 
    {
        New,
        Active,
        Dropout,
        Graduate
    }
}
