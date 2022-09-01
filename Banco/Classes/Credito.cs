using System.ComponentModel.DataAnnotations;

namespace Banco.Classes;
public class Credito
{
    private TipoCredito? _tipo;

    public decimal Valor { get; set; }
    public short QuantidadeParcelas { get; set; }
    public string? DataPrimeiroVencimento { get; set; }
    internal string? Status { get; set; }
    internal decimal ValorTotal { get; set; }
    internal decimal Juros { get; set; }
    public TipoCredito Tipo
    {
        get => (_tipo ??= new TipoCredito());
        set => _tipo = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void DefinirStatus ()
    {
        if (Valor > 1000000 || QuantidadeParcelas < 5 || QuantidadeParcelas > 72
            || Convert.ToDateTime(DataPrimeiroVencimento) < DateTime.Now.AddDays(15)
            || Convert.ToDateTime(DataPrimeiroVencimento) > DateTime.Now.AddDays(40)
            || Tipo.Credito!.ToLower() == "crédito pessoa jurídica" && Valor < 15000)
            Status = "Recusado";
        else
            Status = "Aprovado";
    }
    public void CalcularJuros ()
    {
        Juros = Valor * QuantidadeParcelas * Tipo.CalcularTaxa() / 100;
    }
    public void CalcularValorTotal ()
    {
        ValorTotal = Valor + Juros;
    }
}
