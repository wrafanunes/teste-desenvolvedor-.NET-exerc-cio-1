using Banco.Classes;
using Banco.ViewModels;

namespace Banco.Services;
public interface ICreditoService
{
    CreditoViewModel ExibirResultadoCredito (Credito credito);
}
