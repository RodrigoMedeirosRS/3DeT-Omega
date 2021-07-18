using RandomGen;

namespace System3DeT
{
    public abstract class Rolagem
    {
        public virtual int RolarD6(int quantidade)
        {
            return Gen.Random.Numbers.Integers(quantidade, (quantidade * 6))();
        }
        public virtual int RolarD6(int quantidade, int modificador)
        {
            return RolarD6(quantidade) + modificador;
        }
    }
}