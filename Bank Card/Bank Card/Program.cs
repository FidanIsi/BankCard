using System.Diagnostics;

namespace Bank_Card
{
    public abstract class BankCard
    {
        public BankCard(string cardId, string cardCode, int cardCVV, decimal balance)
        {
            CardId = cardId;
            CardCode = cardCode;
            CardCVV = cardCVV;
            Balance = balance;
        }

        protected string CardId { get; set; }
        protected string CardCode { get; set; }
        protected int CardCVV { get; set; }
        protected decimal Balance { get; set; }

        protected decimal DepositCommissionRate { get; set; }
        protected decimal WithdrawalCommissionRate { get; set; }  
        
        public virtual void Deposit(decimal amount)
        {
            Balance += amount - (amount * DepositCommissionRate);
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && amount < Balance)
            {
                Balance -= amount + (amount * WithdrawalCommissionRate);
            }
        }

        public void Info()
        {
            Console.WriteLine(CardId);
            Console.WriteLine(CardCode);
            Console.WriteLine(CardCVV);
            Console.WriteLine(Balance);
            Console.WriteLine();
        }
    }

    public class Unibank : BankCard
    {
        public Unibank(string cardId, string cardCode, int cardCVV, decimal balance) : base(cardId, cardCode, cardCVV, balance)
        {
            WithdrawalCommissionRate = 0.015m;
        }

        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
        }

    }
    public class AccessBank : BankCard
    {
        public AccessBank(string cardId, string cardCode, int cardCVV, decimal balance) : base(cardId, cardCode, cardCVV, balance)
        {
            DepositCommissionRate = 0.003m;
            WithdrawalCommissionRate = 0.016m;
        }

        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
        }



    }

    public class PashaBank : BankCard
    {
        public PashaBank(string cardId, string cardCode, int cardCVV, decimal balance) : base(cardId, cardCode, cardCVV, balance)
        {
            DepositCommissionRate = 0.006m;
            WithdrawalCommissionRate = 0.011m;
        }

        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
        }

    }

    public class LeoBank : BankCard
    {
        public LeoBank(string cardId, string cardCode, int cardCVV, decimal balance) : base(cardId, cardCode, cardCVV, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Unibank unibankcard = new Unibank("Fidan Ismayilova", "1234567812345678", 678, 800);
            unibankcard.Deposit(20);
            unibankcard.Withdraw(10);
            unibankcard.Info();

            AccessBank accessBankCard = new AccessBank("Fidan Ismayilova", "1234567812345678", 678, 1000);
            accessBankCard.Deposit(70);
            accessBankCard.Withdraw(30);
            accessBankCard.Info();

            PashaBank pashaBankCard = new PashaBank("Fidan Ismayilova", "1234567812345678", 678, 1200);
            pashaBankCard.Deposit(100);
            pashaBankCard.Withdraw(70);
            pashaBankCard.Info();

            LeoBank leoBankCard = new LeoBank("Fidan Ismayilova", "1234567812345678", 678, 900);
            leoBankCard.Deposit(200);
            leoBankCard.Withdraw(50);
            leoBankCard.Info();
        }
    }
            
}
