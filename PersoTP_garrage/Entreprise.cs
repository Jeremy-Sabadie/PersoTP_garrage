namespace PersoTP_garrage;

internal class Entreprise
{
    public Entreprise(string name, int siretNumber)
    {
        Name = name;
        SiretNumber = siretNumber;
    }

    private string Name { get; set; }
    private int SiretNumber { get; set; }
}
