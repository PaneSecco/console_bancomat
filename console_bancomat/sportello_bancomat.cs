using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_bancomat
{
    internal class sportello_bancomat
    {
        private string id;
        private string indirizzo;
        private string banca;
        private carta_bancomat carta;

        public sportello_bancomat(string id,string indirizzo, string banca)
        {
            this.id = id;
            this.indirizzo = indirizzo;
            this.banca = banca;
        }

        public string get_id()
        {
            return id;
        }
        public string get_indirizzo()
        {
            return indirizzo;
        }
        public string get_banca()
        {
            return banca;
        }
        public void inserisci(carta_bancomat carta)
        {
            this.carta = carta;
        }
        public carta_bancomat rimuovi()
        {
            carta_bancomat carta_supporto = carta;
            carta = null;
            return carta_supporto;
        }
        public carta_bancomat get_carta()
        {
            return carta;
        }
    }
}
