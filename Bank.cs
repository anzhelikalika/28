namespace WindowsFormsApp1
{
    public class Bank
    {
        public string BankName { get; set; }
        public int MinCreditAmount { get; set; }
        public int MaxCreditAmount { get; set; }
        public int MinCreditAge { get; set; }
        public int MaxCreditAge { get; set; }
        public int MinCreditPeriod { get; set; }
        public int MaxCreditPeriod { get; set; }
        public double CreditRate { get; set; }

        public Bank(string bankName, int minCreditAmount, int maxCreditAmount, int minCreditAge, int maxCreditAge, int minCreditPeriod, int maxCreditPeriod, double creditRate)
        {
            BankName = bankName;
            MinCreditAmount = minCreditAmount;
            MaxCreditAmount = maxCreditAmount;
            MinCreditAge = minCreditAge;
            MaxCreditAge = maxCreditAge;
            MinCreditPeriod = minCreditPeriod;
            MaxCreditPeriod = maxCreditPeriod;
            CreditRate = creditRate;
        }

        public double TotalAmount(int amount, int period)
        {
            double result = amount;
            for (int i = 0; i < period/12; i++)
            {
                result += amount / 100 * CreditRate;
            }
            return result;
        }

        public double OverPayment(int amount, int period)
        {
            return TotalAmount(amount, period) / period;
        }
        
    }
}
