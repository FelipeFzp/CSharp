using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public abstract class Account
    {
        private List<double> MovementsHistory = new List<double>();
        protected virtual float TotalAvailable { get; set; }
        protected float Balance { get; set; }

        //private static String _url = "http://www.promob.com.br";

        protected void UpdateMovementsHistory(double value) // adiciona as movimentações na lista MovementsHistory
        {
            MovementsHistory.Add(value);
        }

        public virtual void PrintMovementsHistory()
        {
            foreach (var l in MovementsHistory)
            {
                Console.WriteLine(l);
            }
        }

        public Account(float InitialBalance)
        {
            this.Balance = InitialBalance;
        }

        private void Debit(float value)
        {
            this.Balance -= value;
            UpdateMovementsHistory(-value);
        }

        private void Credit(float value)
        {
            this.Balance += value;
            UpdateMovementsHistory(value);
        }

        public void CashIn(float value)
        {
            Credit(value);
        }

        public virtual void CashOut(float value)
        {
            Debit(value);
        }

        public string FormatTotalDescription()
        {
            return "Seu Saldo é de " + Balance + "R$";
        }

        public abstract void PrintAccountInformation();
    }
}