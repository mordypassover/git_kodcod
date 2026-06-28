using System;



namespace bank
{
    public enum AccountTypeEnum
    {
        Savings,
        Checking,
        Business
    }
    class BankAccount
    {
        private int _accountNumber;
        private string _ownerName;
        private double _balance;
        private AccountTypeEnum _accountType;
        private bool _isActive;
        private List<string> _tranactionHistory = new List<string>();

        public int AccountNumber{ get => _accountNumber; }

        public string OwnerName 
        { 
            get => _ownerName; 
            set 
            { 
                if (string.IsNullOrWhiteSpace(value) ) 
                {
                    _ownerName = "Unknown";
                }
                else { _ownerName = value; }
            } 
        }

        public double Balance 
        {
            get => _balance;
            set
            {
                if( value < 0) { _balance = 0; }
                else { _balance = value; }
            }
        }

        public string AccountType
        {
            get => _accountType.ToString();
            set 
            {
                if (Enum.TryParse(value, true, out AccountTypeEnum acctype))
                {  
                    _accountType = acctype; 
                }
                else _accountType = AccountTypeEnum.Checking;
            }
        }

        public bool IsActive 
        {
            get => _isActive; 
            private set { _isActive = value; }
        }

        public BankAccount(int accountNumber, string ownerName, double balance, string accontType)
        {
            _accountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
            AccountType = accontType;
            IsActive = true;
            Console.WriteLine("1st construct");
        }

        public BankAccount(int accountNumber, string ownerName) : this(accountNumber, ownerName, 0.0, "Checking") 
        {
            Console.WriteLine("2nd construct"); 
        }

        public BankAccount(int accountNumber, string ownerName, double balance) : this(accountNumber, ownerName, balance, "Checking") 
        {
            Console.WriteLine("3rd construct");
        }
        public override string ToString()
        {
            return $"Accont #{AccountNumber} | Owner: {OwnerName} |" +
                   $" balance: ${Balance:F2} | Type: {AccountType}";
        }
        public void Deposit(double amount)
        {
            if (amount > 0 && IsActive) 
            {
                Balance += amount;
                _tranactionHistory.Add($"deposited ${amount}");
            }
            else { Console.WriteLine("cant deposit, amount must be positive"); }
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount && IsActive) {
                Balance -= amount;
                _tranactionHistory.Add($"withdrawd ${amount}");
                return true;
            }
            Console.WriteLine("cant withdraw, amount must be positive and  smaller then balan");
            return false;
        }

        public void ApplyInterest()
        {
            if (AccountType == AccountTypeEnum.Savings.ToString() && IsActive) 
            { 
                double intrest = (Balance / 100) * 2;
                Balance += intrest;
                _tranactionHistory.Add($"deposited intrest ${intrest}");
            }
        }
        public void PrintTransactionsHistory()
        {
            foreach (string transaction in _tranactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }
        public void Activate()
        {
            IsActive = true;
        }
        public void DeActivate()
        {
            IsActive = false;
        }
        public static bool Transfer(BankAccount from, BankAccount to, double amount)
        {
            if (from.IsActive && to.IsActive)
            {
                bool withdrawd = from.Withdraw(amount);
                if (withdrawd) { to.Deposit(amount); }
                return withdrawd;
            }
            else return false;
        }
    }
    class mainProgram
    {
        static void Main()
        {
            List <BankAccount> accountList = new List<BankAccount>();
            accountList.Add(new BankAccount(1, "mordy"));
            accountList.Add(new BankAccount(5, "", 100.5, "Savings"));
            accountList.Add(new BankAccount(4, "yoni",-222.6 ,"Business"));
            accountList.Add(new BankAccount(15, "shimi"));
            accountList.Add(new BankAccount(133, "yanki", 99, "notValid"));
            foreach (BankAccount account in accountList) { Console.WriteLine(account); }
            accountList[0].Deposit(13.0);
            accountList[3].Deposit(1000.5);
            accountList[4].Withdraw(910.0);
            Console.WriteLine($"a2: {accountList[2].Balance}");
            accountList[2].Withdraw(13.0);
            Console.WriteLine($"a2: {accountList[2].Balance}");
            accountList[2].DeActivate();
            Console.WriteLine($"a2: {accountList[2].Balance}");
            Console.WriteLine($"a2: {accountList[2].Withdraw(10.8)}\n");
            accountList[2].Activate();
            Console.WriteLine($"a1: {accountList[1].Balance}, a2: {accountList[0].Balance}\n");
            accountList[1].ApplyInterest();
            accountList[2].ApplyInterest();
            Console.WriteLine($"a1: {accountList[1].Balance}, a2: {accountList[0].Balance}\n");
            Console.WriteLine($"a4: {accountList[4].Balance}, a0: {accountList[0].Balance}");
            BankAccount.Transfer(accountList[4], accountList[0], 20);
            Console.WriteLine($"a4: {accountList[4].Balance}, a0: {accountList[0].Balance}\n");
            accountList[2].PrintTransactionsHistory();
            accountList[4].PrintTransactionsHistory();
            foreach (BankAccount account in accountList) { Console.WriteLine(account); }
        }
    }
}