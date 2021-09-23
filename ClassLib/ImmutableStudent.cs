using System;

namespace ClassLib {
    public record ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
{
    int id{get; init;}
    string givenName{get; init;}
    string surname{get; init;}
    status status{get; init;}
    DateTime startDate{get; init;}
    DateTime endDate{get; init;}
    DateTime graduationDate{get; init;}
}
}