using PetShopBH.Models;

namespace PetShopBH.MetodosExtensao
{
    public static class PrecoTotalCanilFeliz
    {
        public static decimal CalcularTotalSemanaCaninoFeliz(this PetShopFeliz petshop, DonoCachorros donoCachorros)
        {
            decimal somaCachorroG = donoCachorros.QuantidadeG * petshop.PrecoBanhoG;
            decimal somaCachorroP = donoCachorros.QuantidadeP * petshop.PrecoBanhoP;

            return somaCachorroG + somaCachorroP;

        }
        public static decimal CalcularTotalFinalDeSemanaFeliz(this PetShopFeliz petshop, DonoCachorros donoCachorros)
        {
            decimal precoPorcentagemG = 40m * 1.20m;
            decimal precoPorcentagemP = 20m * 1.20m;

            petshop.PrecoBanhoP = precoPorcentagemP;
            petshop.PrecoBanhoG = precoPorcentagemG;

            decimal somaCachorroG = donoCachorros.QuantidadeG * petshop.PrecoBanhoG;
            decimal somaCachorroP = donoCachorros.QuantidadeP * petshop.PrecoBanhoP;
            return somaCachorroG + somaCachorroP;

        }
    }
}
