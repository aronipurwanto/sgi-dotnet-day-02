namespace NorthwindApp.Models;

public class Person
{
    public int Id { get; set; }
    public String Name { get; set; }
    public List<PersonAddress> Address { get; set; }

    public Person(int id, string name, List<PersonAddress> address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}