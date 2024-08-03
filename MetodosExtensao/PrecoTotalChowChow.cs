using PetShopBH.Models;

namespace PetShopBH.MetodosExtensao
{
    public static class TotalChowChow
    {
        public static decimal CalcularTotalChowChow(this PetShopChowChow petshop, DonoCachorros donoCachorros)
        {
            decimal somaCachorroPequeno = donoCachorros.QuantidadeDogPequeno * petshop.PrecoBanhoDogPequeno;
            decimal somaCachorroGrande = donoCachorros.QuantidadeDogGrande * petshop.PrecoBanhoDogGrande;

            return somaCachorroGrande + somaCachorroPequeno;

        }
    }
}
