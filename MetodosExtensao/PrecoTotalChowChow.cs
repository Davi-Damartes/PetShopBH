using PetShopBH.Models;

namespace PetShopBH.MetodosExtensao
{
    public static class TotalChowChow
    {
        public static decimal CalcularTotalChowChow(this PetShopChowChow petshop, DonoCachorros donoCachorros)
        {
            decimal somaCachorroGrande = donoCachorros.QuantidadeDogGrande * petshop.PrecoBanhoDogGrande;
            decimal somaCachorroPequeno = donoCachorros.QuantidadeDogPequeno * petshop.PrecoBanhoDogPequeno;

            return somaCachorroGrande + somaCachorroPequeno;

        }
    }
}
