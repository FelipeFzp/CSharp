using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class InvestmentAccount : Account, ITaxable
    {
        public InvestmentAccount(float InitialBalance)
            : base(InitialBalance)
        {

        }

        public override void PrintMovementsHistory()
        {
            Console.WriteLine("Movimentação da conta Investimento:");
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
