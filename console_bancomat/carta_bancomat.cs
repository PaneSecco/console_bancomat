using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_bancomat
{
    internal class carta_bancomat
    {
        private conto_corrente conto;
        private string id;
        private string pin;
        public carta_bancomat(conto_corrente conto, string id, string pin)
        {
            set_conto(conto);
            this.id = id;
            this.pin = pin;
        }
        private void set_conto(conto_corrente conto)
        {
            this.conto = conto;
        }

        public string get_id(string pin)
        {
            if (this.pin == pin)
            {
                return id;
            }
            else
            {
                throw new Exception("il pin inserito è errato");
            }
        }
        public void deposita(float somma, string pin)
        {
            if (this.pin == pin)
            {
                conto.deposita(somma);
            }
            else
            {
                throw new Exception("il pin inserito è errato");
            }
        }
        public void preleva(float somma, string pin)
        {
            if (this.pin == pin)
            {
                conto.deposita(somma);
            }
            else
            {
                throw new Exception("il pin inserito è errato");
            }
        }
        public float get_saldo(string pin)
        {
            if (this.pin == pin)
            {
                return conto.get_saldo();
            }
            else
            {
                throw new Exception("il pin inserito è errato");
            }
        }
    }
}
