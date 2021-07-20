using System.Linq;
using System.Collections.Generic;
using System3DeT.Enum;
using System3DeT.Interface;

namespace System3DeT
{
    public class Personagem : IPersonagem
    {
        public Personagem(string nome, List<ICaracteristica> caracteristicas, List<IVantagemDesvantagem> vantagemDesvantagens, int pontosDeVida = 99, int pontosDeMagia = 99, int pontosDeExperiencia = 0)
        {
            Nome = nome;
            Caracteristicas = caracteristicas;
            VantagemDesvantagens = vantagemDesvantagens;
            PontosDeVida = pontosDeVida;
            PontosDeMagia = pontosDeMagia;
            PontosDeExperiencia = pontosDeExperiencia;
        }
        public EscalaDePoder Escala { get; set; }
        public string Nome { get; set; }
        public List<ICaracteristica> Caracteristicas { get; set; }
        public List<IVantagemDesvantagem> VantagemDesvantagens { get; set; }
        private int _pontosDeVida { get; set; }
        public int PontosDeVida 
        { 
            get
            { 
                return _pontosDeVida;
            }
            set
            {
                var maximo = ObterCaracteristica(NomeCaracteristica.Resistencia) * 5;

                if (_pontosDeVida + value < 0)
                    _pontosDeVida = 0;
                else if (_pontosDeVida + value > maximo)
                    _pontosDeVida = maximo;
                else
                    _pontosDeVida = value;
            }
        }
        private int _pontosDeMagia { get; set; }
        public int PontosDeMagia 
        {
            get
            { 
                return _pontosDeMagia;
            }
            set
            {
                var maximo = ObterCaracteristica(NomeCaracteristica.Habilidade) * 2;

                if (_pontosDeMagia + value < 0)
                    _pontosDeMagia = 0;
                else if (_pontosDeMagia + value > maximo)
                    _pontosDeMagia = maximo;
                else
                    _pontosDeMagia = value;
            }
        }
        public bool Vivo 
        {
            get
            {
                return PontosDeVida > 0;
            }
        }
        public int PontosDeExperiencia { get; set; }

        public int ObterCaracteristica(NomeCaracteristica nomeCaracteristica)
        {
            return (from caracteristica in Caracteristicas 
                where caracteristica.Nome == nomeCaracteristica
                select caracteristica.Valor).FirstOrDefault();
        }

        public int ObterTotalDePontos()
        {
            return ObterTotalDePontosCaracteristicas();
        }

        private int ObterTotalDePontosVantagensDesvantagens()
        {
            var total = 0;
            foreach (var vangatemDesvantagem in VantagemDesvantagens)
                total += vangatemDesvantagem.Valor;
            return total;
        }
        private int ObterTotalDePontosCaracteristicas()
        {
            var total = 0;
            foreach (var caracteristica in Caracteristicas)
                total += caracteristica.Valor;
            return total;
        }
    }
}