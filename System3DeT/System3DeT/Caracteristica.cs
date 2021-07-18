using System3DeT.Enum;
using System3DeT.Interface;

namespace System3DeT
{
    public class Caracteristica : ICaracteristica
    {
        public Caracteristica(NomeCaracteristica nome, int valor = 0, string descricao = "")
        {
            Nome = nome;
            Valor = valor;
            Descricao = descricao;
        }
        public NomeCaracteristica Nome { get; private set; }

        private int _valor { get ;set; }
        public int Valor 
        { 
            get 
            {
                return _valor;
            }
            set
            {
                if (value + _valor < 0)
                    _valor = 0;
                else if (value + _valor > 5)
                    _valor = 5;
                else
                    _valor = value;
            }
        }
        public int CustoXP 
        { 
            get
            {
                return _valor * 10;
            }
        }
        public string Descricao { get; set; }  
    }
}