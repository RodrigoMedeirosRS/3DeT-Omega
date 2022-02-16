using System.Omega.Enum;

namespace System.Omega.Interface
{
    public interface ICaracteristica
    {
        NomeCaracteristica Nome { get; }
        int Valor { get; set; }
        int CustoXP { get; }
        string Descricao { get; }
    }
}