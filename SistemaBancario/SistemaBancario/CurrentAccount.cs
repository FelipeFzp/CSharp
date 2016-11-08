using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class CurrentAccount: Account //Conta corrente herda da Superclasse Conta
    {
        private bool Overdraft { get; set; }
        private float OverdraftValue { get; set; }
        
        public CurrentAccount(bool Overdraft,float InitialBalance)
            :base(InitialBalance)
        {
            this.Overdraft = Overdraft;
            this.OverdraftValue = 100;
        }

        public override void PrintMovementsHistory()
        {
            Console.WriteLine("Movimentação da conta Corrente:");
            base.PrintMovementsHistory();
        }
        public override void PrintAccountInformation()
        {
            string MessageOverdraft = " ";
            if (Overdraft == true)
            {
                MessageOverdraft = "Sim";
                TotalAvailable = Balance + OverdraftValue;
            }
            else
            {
                MessageOverdraft = "Não";
                TotalAvailable = 0;
                TotalAvailable += Balance;
            }
            Console.WriteLine("Cheque Especial ? "+MessageOverdraft+", Total Disponivel :"+TotalAvailable+" .");
            FormatTotalDescription();
        }
    }
}
