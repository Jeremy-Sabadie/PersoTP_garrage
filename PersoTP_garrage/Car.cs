namespace PersoTP_garrage;

internal class Car : Vehicule
{
    public Car(string brand, string model, string registration, int damage, Garagist garagist) : base(brand, model, registration, damage)
    {
        string Brand = brand;
        string Model = model;
        string Registration = registration;
        int Damage = damage;

    }
    public override double ReparationTime(Garagist g)
    {
        double Time = 1.5 * Damage * (g.Skills / 100);
        return Time;

    }
}

