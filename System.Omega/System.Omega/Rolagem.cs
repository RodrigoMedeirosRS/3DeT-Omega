using RandomGen;
using System.Linq;
using System.Omega.Enum;

namespace System.Omega
{
    public abstract class Rolagem
    {
        public virtual int RolarD6(int quantidade)
        {
            return Gen.Random.Numbers.Integers(quantidade, (quantidade * 6))();
        }
        public virtual int RolarD6ComCondicao(Condicao condicao)
        {
            if (condicao == Condicao.Normal)
                return RolarD6(1);
            else
            {
                var resultado = new int[2] { RolarD6(1), RolarD6(1) };
                return condicao == Condicao.Vantagem ? resultado.Max() : resultado.Min();
            }
        }
        public virtual int RolarD6(int quantidade, int modificador)
        {
            return RolarD6(quantidade) + modificador;
        }
    }
}