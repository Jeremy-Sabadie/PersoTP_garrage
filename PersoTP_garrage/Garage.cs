namespace PersoTP_garrage;

internal class Garage : Entreprise
{
    private List<Vehicule> Vehicules = new List<Vehicule>();
    private List<Garagist> garagist = new List<Garagist>();
    public Garage(string name, int siretNumber) : base(name, siretNumber)
    {
        string Name = name;
        int SiretNumber = siretNumber;
    }
    public void AddToList(Vehicule vehicule)
    {
        Vehicules.Add(vehicule);
    }
    public void Print()
    {
        for (int i = 0; i < Vehicules.Count; i++)
        {
            Console.WriteLine($"{Vehicules[i].Print()}");
        }
    }

}
