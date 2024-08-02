namespace PetShopBH.Models
{
    public class PetShopChowChow
    {
        public string NomePetShop { get; set; } = string.Empty;

        public decimal PrecoBanhoG { get; set; }
        public decimal PrecoBanhoP { get; set; }
        public decimal Distancia { get; set; }

        public bool Maior { get;set; }
    }
}
