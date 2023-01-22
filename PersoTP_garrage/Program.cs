using PersoTP_garrage;

Garagist G1 = new Garagist("Didier", "Dubois", 35, 3);
Vehicule V1 = new Car("BMW3", "fff", "ffgh", 50, G1);
Garage Gr1 = new Garage("Mon garage", 3243);
Gr1.AddToList(V1);
Gr1.Print();
