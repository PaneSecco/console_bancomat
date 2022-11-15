using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_bancomat
{
    internal class conto_corrente
    {
        private string id;
        private string cliente;
        private string banca;
        private float saldo;

        public conto_corrente(string id, string cliente, string banca, float saldo)
        {
            this.id = id;
            this.cliente = cliente;
            this.banca = banca;
            this.saldo = saldo;
        }

        public string get_id()
        {
            return id;  
        }
        public string get_cliente()
        {
            return cliente;
        }
        public string get_banca()
        {
            return banca;
        }
        public float get_saldo()
        {
            return saldo;
        }
        public void deposita(float somma)
        {
            saldo += somma;
        }
        public void preleva(float somma)
        {
            if (saldo-somma < 0)
            {
                throw new Exception("non puoi prelevare una somma che è maggiore del tuo saldo");
            }
            else
            {
                saldo -= somma;
            }
        }
        public void bonifico(conto_corrente conto,float somma)
        {
            if (saldo - somma < 0)
            {
                throw new Exception("non puoi prelevare una somma che è maggiore del tuo saldo");
            }
            else
            {
                saldo -= somma;
                conto.deposita(somma);
            }
        }

    }
}
