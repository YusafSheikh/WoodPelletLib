using System.Security.Cryptography.X509Certificates;

namespace WoodPelletLib
{
    public class WoodPellet
    {
        public int Id { get; set; }
        public string? Brand { get; set; } // ? angiver at Brand kan være null

        public decimal Price { get; set; }
        public int Quality { get; set; } // get set tillader læsning og skrivning af værdien

        public void Validate() // metode som er ansvarlig for kontrol om alle krav er opfyldt
        {
            if (string.IsNullOrEmpty(Brand) || Brand.Length < 2) // tjekker om brand er null eller tom, eller har færre en 2 karakter
            {
                throw new ArgumentException("Brand skal have mindst 2 karaktere"); //Kaster argument exception hvis betingelsen ikke er opfyldt
            }

            if (Price <= 0) // tjekker om det er mindre eller lig med 0
            {
                throw new ArgumentException("Pris skal være et positivt nummer"); //Kaster argument exception hvis betingelsen ikke er opfyldt
            }

            if (Quality < 1 || Quality < 5) // tjekker om quality er mindre end 1 eller større end 5
            {
                throw new ArgumentException("Quality skal være mellem 1 til 5"); //Kaster argument exception hvis betingelsen ikke er opfyldt
            }
        }

        public override string ToString() // Overskriver ToString() metoden fra baseklassen object
        {
            return $"(Id: {Id}, Brand: {Brand}, Price: {Price}, Quality: {Quality})"; // Returnerer en formateret streng, der repræsenterer objektet 
        }
    }
}