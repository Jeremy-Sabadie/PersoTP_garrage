namespace PersoTP_garrage;

internal class Truck : Vehicule
{
    string Brand;
    string Model;
    string Registration;
    int Damage;
    Garagist garagist;
    Truck(string brand, string model, string registration, int damage) : base(brand, model, registration, damage)
    {

    }
    public override double ReparationTime(Garagist g)
    {
        double Time = 2 * Damage * (g.Skills / 100);
        return Time;
    }
}


