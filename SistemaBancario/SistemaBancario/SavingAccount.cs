using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class SavingAccount: Account, ITaxable //Conta poupança herda da Superclasse Conta
    {
        public SavingAccount(float InitialBalance)
            :base(InitialBalance)
        {
            
        }

        public override void CashOut(float value)
        {
            value+=(value*10)/100;
            Balance -= value;
            UpdateMovementsHistory(-value);
        }

        public override void PrintMovementsHistory()
        {
            Console.WriteLine("Movimentação da conta poupança:");
            base.PrintMovementsHistory();
        }
        public override void PrintAccountInformation()
        {
            TotalAvailable = 0;
            TotalAvailable += Balance;
            Console.WriteLine("Total Disponivel: " + TotalAvailable);
            FormatTotalDescription();
        }
    }
}
