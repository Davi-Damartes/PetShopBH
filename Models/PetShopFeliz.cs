namespace PetShopBH.Models
{
    public class PetShopFeliz
    {
        public string NomePetShop { get; set; } = string.Empty;

        public decimal PrecoBanhoG { get; set; }
        public decimal PrecoBanhoP { get; set; }

        public bool MaisBarato { get; set; }
        public double Distancia { get; set; }
    }
}
