namespace NorthwindApp.Models;

public class PersonAddress
{
    public int Id { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }

    public PersonAddress(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}