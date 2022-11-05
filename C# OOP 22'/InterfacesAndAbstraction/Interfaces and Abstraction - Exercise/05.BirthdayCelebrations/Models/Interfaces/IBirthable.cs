namespace BirthdayCelebrations.Models.Interfaces
{

    public interface IBirthable
    {
        string Birthdate { get; set; }

        void CheckBirthday(string birthday);
    }
}
