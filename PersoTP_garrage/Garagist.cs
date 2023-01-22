namespace PersoTP_garrage;

internal class Garagist : Person
{
    public int Skills { get; set; }
    List<Vehicule> véhicules;

    public Garagist(string name, string firstName, int age, int skills) : base(name, firstName, age)
    {
        string Name = name;
        string FirstName = firstName;
        int Age = age;
        int Skills = skills;
    }

}
