using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class AccountMananger
    {
        public CurrentAccount CR; // declaração dos tres tipos de conta disponivel
        public SavingAccount CP;
        public InvestmentAccount CI;

        public AccountMananger() // Construtor carrega as contas
        {
            LoadAccounts();
        }

        public void LoadAccounts() // seta os valores a inicializar nas contas base
        {
          CR = new CurrentAccount(true, 0);
          CP = new SavingAccount(0);
          CI = new InvestmentAccount(0); 
        }


        public void AccountCashInMananger(Account account, float value) // levando a conta como parametro a variavel account especifica qual cashin de qual tipo de conta executar
        {
            account.CashIn(value);
        }

        public void AccountCashOutMananger(Account account,float value) // levando a conta como parametro a variavel account especifica qual cashout de qual tipo de conta executar
        {
            account.CashOut(value);
        }

        public void AccountMovementsHistoryMananger(Account account) // levando a conta como parametro a variavel account especifica qual HistoryMovements de qual tipo de conta executar
        {
            account.PrintMovementsHistory();
        }

        public void AccountPrintAccountInformationMananger(Account account) //levando a conta como parametro a variavel account especifica qual PrintAccountInformatios Chamar
        {
            account.PrintAccountInformation();
        }
    }
}
