namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Créer les comptes
            Current account1 = new Current("BE55 000 000 000", 500, 0);
            Savings account2 = new Savings("BE56 1111 111 111", 1500, 2);
            Current account3 = new Current("BE43 222 222 222", 100, 500);
            
            // Afficher les comptes
            Console.WriteLine($"Compte courant : {account1.Number} | Solde : {account1.Balance}€ | Découvert max : {account1.Overdraft}");
            Console.WriteLine($"Compte épargne : {account2.Number} | Solde : {account2.Balance}€ | Taux d'intérêt : {account2.InterestRate}%");

            // Retirer de l'argent sur le compte courant
            double amountWithdraw = 150;
            bool successWithdraw = account1.Withdraw(amountWithdraw);
            if(successWithdraw)
            {
                Console.WriteLine($"Retrait de {amountWithdraw}€ effectué du compte {account1.Number}");
            }
            else
            {
                Console.WriteLine($"Retrait de {amountWithdraw}€ impossible du compte {account1.Number}");
            }

            // Déposer de l'argent sur le compte épargne
            double amountDeposit = 500;
            bool successDeposit = account2.Deposit(amountDeposit);
            if(successDeposit)
            {
                Console.WriteLine($"Dépôt de {amountDeposit}€ effectué sur le compte {account2.Number}");
            }
            else
            {
                Console.WriteLine($"Dépôt de {amountDeposit}€ impossible sur le compte {account2.Number}");
            }

            // Envoyer de l'argent à un compte
            double amountPay = 50;
            bool successPay = account1.Pay(account3, amountPay);
            if(successPay)
            {
                Console.WriteLine($"Paiement de {amountPay}€ effectué du compte {account1.Number} vers le compte {account3.Number}");
            }
            else
            {
                Console.WriteLine($"Paiement de {amountPay}€ impossible du compte {account1.Number} vers le compte {account3.Number}");
            }
        }
    }
}