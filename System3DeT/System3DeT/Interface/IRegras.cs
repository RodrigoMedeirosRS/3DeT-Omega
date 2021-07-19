using System3DeT.Enum;
namespace System3DeT.Interface
{
    public interface IRegras
    {
        bool Teste(IPersonagem personagem, NomeCaracteristica nomeCaracteristica, Dificuldade dificuldade = Dificuldade.Normal);
        int Ataque(IPersonagem atacante, IPersonagem alvo, bool corporal, bool bloqueio);
        void AplicarDano(IPersonagem atacante, IPersonagem alvo, int dano);
    }
}