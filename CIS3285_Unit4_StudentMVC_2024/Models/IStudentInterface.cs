namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public interface IStudentInterface
    {
        int Credits { get; set; }
        int Id { get; set; }
        string Name { get; set; }

        public IStudentInterface (int id, string name, int credits)
        {
            Id = id;
            Name = name;
            Credits = credits;
        }








    }
}