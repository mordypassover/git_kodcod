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
        private List<string> _tranactionHistory;

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

        public BankAccount(int accountNumber, string ownerName, string accontType, double balance)
        {
            _accountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
            AccountType = accontType;
            IsActive = true;
            Console.WriteLine("1st construct");
        }

        public BankAccount(int accountNumber, string ownerName) : this(accountNumber, ownerName, "Checking", 0.0) 
        {
            Console.WriteLine("2nd construct"); 
        }

        public BankAccount(int accountNumber, string ownerName, double balance) : this(accountNumber, ownerName, "Checking", balance) 
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

        public void applyInterest()
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
                to.Deposit(amount);
                return withdrawd;
            }
            else return false;
        }
    }
}