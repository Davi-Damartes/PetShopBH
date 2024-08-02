using PetShopBH.Models;

namespace PetShopBH.MetodosExtensao
{
    public static class TotalChowChow
    {
        public static decimal CalcularTotalChowChow(this PetShopChowChow petshop, DonoCachorros donoCachorros)
        {
            decimal somaCachorroG = donoCachorros.QuantidadeG * petshop.PrecoBanhoG;
            decimal somaCachorroP = donoCachorros.QuantidadeP * petshop.PrecoBanhoP;

            return somaCachorroG + somaCachorroP;

        }
    }
}
