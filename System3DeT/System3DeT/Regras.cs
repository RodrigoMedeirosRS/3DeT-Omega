using System;
using System3DeT.Enum;
using System3DeT.Interface;

namespace System3DeT
{
    public class Regras : Rolagem, IRegras
    {
        public virtual bool Teste(IPersonagem personagem, NomeCaracteristica nomeCaracteristica, Dificuldade dificuldade = Dificuldade.Normal)
        {
            return RolarD6(1, (int)dificuldade) <= personagem.ObterCaracteristica(nomeCaracteristica);
        }
        public virtual int Ataque(IPersonagem atacante, IPersonagem alvo, bool corporal, bool bloqueio)
        {
            var modificadorAtaque = corporal ? atacante.ObterCaracteristica(NomeCaracteristica.Forca) : atacante.ObterCaracteristica(NomeCaracteristica.PoderDeFogo);
            var modificadorAlvo = bloqueio ? alvo.ObterCaracteristica(NomeCaracteristica.Armadura) : alvo.ObterCaracteristica(NomeCaracteristica.Habilidade);
            var resultado = RolarD6(1, modificadorAtaque) - RolarD6(1, modificadorAlvo);
            return resultado < 0 ? 0 : resultado;
        }
        public void AplicarDano(IPersonagem atacante, IPersonagem alvo, int dano)
        {
            var multiplicador = (float)atacante.Escala / (float)alvo.Escala;
            var danoFinal = Convert.ToInt32(dano * multiplicador);
            alvo.PontosDeVida -= danoFinal;
        }
    }
}