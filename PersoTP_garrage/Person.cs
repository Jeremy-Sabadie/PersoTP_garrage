namespace PersoTP_garrage;

internal class Person
{//Constructeur:
    public Person(string name, string firstName, int age)
    {
        Name = name;
        FirstName = firstName;
        Age = age;
    }
    //Attributs:
    private string Name { get; set; }
    private string FirstName { get; set; }
    private int Age { get; set; }
}
