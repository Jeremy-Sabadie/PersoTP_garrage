namespace PersoTP_garrage;

internal class Garage : Entreprise
{
    Garage(string name, int siretNumber) : base(name, siretNumber)
    {
        string Name = name;
        int SiretNumber = siretNumber;
    }
    private List<Véhicule> Véhicules { get; set; }
    private List<Garagist> garagist { get; set; }

}
