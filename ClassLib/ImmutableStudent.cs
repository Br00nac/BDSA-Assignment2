using System;

namespace ClassLib 
{
    public record ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
    public status status
    {
        get => GetStatus();
    }

    private status GetStatus()
    {
        var now = DateTime.Now;
        if (now < startDate.AddMonths(3) && now < endDate) return status.New;
        if (startDate <  now && now < endDate) return status.Active;
        if (endDate == graduationDate) return status.Graduate;
        return status.Dropout;
    }
    }
}