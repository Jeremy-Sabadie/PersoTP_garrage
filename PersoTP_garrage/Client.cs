namespace PersoTP_garrage;

internal class Client : Person
{
    private Vehicule véhicule;
    Client(string name, string firstName, int age) : base(name, firstName, age)
    {
        string Name = name;
        string FirstName = firstName;
        int Age = age;
    }
}
