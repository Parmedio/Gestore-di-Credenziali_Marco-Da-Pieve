using System.Globalization;

namespace DBManager.Models.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string? UserEmail { get; set; }

    public string? Password { get; set; }

    public string? RegistrationDate { get; set; }

    public override string ToString() => $"User ID: {UserId}\nMail: {UserEmail}\nPassword: {Password}\nRegistration date: {ConvertDateString(RegistrationDate)}";

    private string ConvertDateString(string dateString)
    {
        DateTime date = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);
        return date.ToString("dd/MM/yyyy");
    }

}
