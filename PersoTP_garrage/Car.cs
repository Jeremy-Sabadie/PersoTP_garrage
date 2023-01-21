namespace PersoTP_garrage;

internal class Car : Véhicule()
{
    Car(string brand, string model, int registration, int damage) : base(brand, model, registration, damage)
    {
        string Brand = brand;
        string Model = model;
        int Registration = registration;
        int Damage = damage;
    }
}
