using System.Text.Json.Serialization;

namespace Banco.Classes
{
    public class TipoCredito
    {
        public string? Credito { get; set; }
        internal short Taxa { get; private set; }

        public short CalcularTaxa ()
        {
            if (Credito!.ToLower() == "crédito direto")
                return 2;
            else if (Credito!.ToLower() == "crédito consignado")
                return 1;
            else if (Credito!.ToLower() == "crédito pessoa jurídica")
                return 5;
            else if (Credito!.ToLower() == "crédito pessoa física")
                return 3;
            else if (Credito!.ToLower() == "crédito imobiliário")
                return 9;
            return 0;
        }
    }
}