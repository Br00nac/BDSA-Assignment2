using System;

namespace ClassLib {
    public record ImmutableStudent()
{
    int id{get; init;}
    string givenName{get; init;}
    string surname{get; init;}
    status status{get; init;}
    DateTime startDate{get; init;}
    DateTime endDate{get; init;}
    DateTime graduationDate{get; init;}

    // public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
    //     {
    //         this.id = id;
    //         this.givenName = givenName;
    //         this.surname = surname;
    //         this.startDate = startDate;
    //         this.endDate = endDate;
    //         this.graduationDate = graduationDate;

    //         if(startDate.Equals(DateTime.Now)) {status = status.New;}
    //         else if (endDate == default) {status = status.Active;}
    //         else if (endDate < graduationDate) {status = status.Dropout;}
    //         else status = status.Graduate;
    //     }
}
}