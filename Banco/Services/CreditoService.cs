using Banco.Classes;
using Banco.ViewModels;

namespace Banco.Services;
public class CreditoService : ICreditoService
{
    public CreditoViewModel ExibirResultadoCredito (Credito credito)
    {
        credito.DefinirStatus();
        credito.CalcularJuros();
        credito.CalcularValorTotal();
        CreditoViewModel creditoViewModel = new()
        {
            Status = credito.Status,
            Juros = credito.Juros,
            ValorTotal = credito.ValorTotal
        };
        return creditoViewModel;
    }
}
