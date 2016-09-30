using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountMananger x = new AccountMananger();

            x.AccountCashInMananger(x.CR, 100);
            x.AccountCashOutMananger(x.CR,100);
            x.AccountMovementsHistoryMananger(x.CR);
            x.AccountPrintAccountInformationMananger(x.CR);

            x.AccountCashInMananger(x.CP, 100);
            x.AccountCashOutMananger(x.CP, 100);
            x.AccountMovementsHistoryMananger(x.CP);
            x.AccountPrintAccountInformationMananger(x.CP);

            x.AccountCashInMananger(x.CI, 100);
            x.AccountCashOutMananger(x.CI, 100);
            x.AccountMovementsHistoryMananger(x.CI);
            x.AccountPrintAccountInformationMananger(x.CI);
            #region Comentarios_Uteis
            //CurrentAccount CR = new CurrentAccount(true, 200);
            /*CR.PrintAccountInformation();
            CR.CashIn(100); // deposita 100 R$
            CR.PrintAccountInformation(); // exibe a descrição de saldo
            CR.CashOut(100); // saca 100 R$
            CR.PrintAccountInformation();*/

            //SavingAccount CP = new SavingAccount(200);
            /*CP.PrintAccountInformation();
            CP.CashIn(100);
            CP.PrintAccountInformation();
            CP.CashOut(100); // saca 100 R$ +10% de taxa
            CP.PrintAccountInformation();*/


            //InvestmentAccount CI = new InvestmentAccount(200); //é Implementada de uma Interface (Interface é uma uma multi-implementação)
            /*CI.PrintAccountInformation();
            CI.CashIn(100);
            CI.PrintAccountInformation();
            CI.CashOut(100);
            CI.PrintAccountInformation();*/
            #endregion

            Console.ReadKey();
        }
    }
}
