using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste3
{
    class Entregador
    {
        
        private bool _possuiCachorro;

        public bool PossuiCachorro
        {
            get { return _possuiCachorro; }
            set { _possuiCachorro = value; }
        }

        private bool _fazEntrega;

        private bool FazEntrega
        {
            get { return _fazEntrega; }
            set
            {
                if (_possuiCachorro)
                {
                    _fazEntrega = false;
                    Console.WriteLine("Não posso entregar a residência");
                }
                else
                {
                    _fazEntrega = true;

                }

            }
        }

        public List<int> ListaCasaImpar { get; set; }

        public void AdicionarCasaImpar(int numeroCasa)
        {
            if (numeroCasa % 2 != 0)
            {
                ListaCasaImpar = new List<int>();
                ListaCasaImpar.Add(numeroCasa);
            }
        }

    }
}

