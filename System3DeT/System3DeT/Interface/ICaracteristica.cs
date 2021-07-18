using System3DeT.Enum;

namespace System3DeT.Interface
{
    public interface ICaracteristica
    {
        NomeCaracteristica Nome { get; }
        int Valor { get; set; }
        int CustoXP { get; }
        string Descricao { get; }
    }
}