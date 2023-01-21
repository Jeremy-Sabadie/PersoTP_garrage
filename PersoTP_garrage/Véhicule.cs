namespace PersoTP_garrage
{
    internal class Véhicule
    {
        public Véhicule(string brand, string model, int registration, int damage)
        {
            Brand = brand;
            Model = model;
            Registration = registration;
            Damage = damage;
        }

        private string Brand { get; set; }
        private string Model { get; set; }
        private int Registration { get; set; }
        private int Damage { get; set; }
    }


}
