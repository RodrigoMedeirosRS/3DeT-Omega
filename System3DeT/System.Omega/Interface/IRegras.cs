using System.Omega.Enum;
namespace System.Omega.Interface
{
    public interface IRegras
    {
        bool Teste(IPersonagem personagem, NomeCaracteristica nomeCaracteristica, Dificuldade dificuldade = Dificuldade.Normal, int modificadoresAdicionais = 0);
        int Ataque(IPersonagem atacante, IPersonagem alvo, bool corporal, bool bloqueio);
        void AplicarDano(IPersonagem atacante, IPersonagem alvo, int dano);
    }
}