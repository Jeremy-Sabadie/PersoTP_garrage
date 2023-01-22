namespace PersoTP_garrage
{
    internal class Vehicule
    {
        private bool inReparation { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private string Registration { get; set; }
        public int Damage { get; set; }
        private List<Garagist> garagist { get; set; }
        public Vehicule(string brand, string model, string registration, int damage)
        {
            inReparation = false;
            Brand = brand;
            Model = model;
            Registration = registration;
            Damage = damage;


        }
        public virtual double ReparationTime(Garagist g)
        {
            double Time = 1.5 * Damage * (g.Skills / 100);
            return Time;

        }
        public string Print()
        {
            return @$"marque: {Brand}
^modèle: {Model}
immatriculation: {Registration}
dommages: {Damage} %";
        }
    }


}
