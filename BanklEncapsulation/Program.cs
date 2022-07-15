namespace BanklEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();
            Console.WriteLine("Please enter the amount you would like to deposit");
            var amount = double.Parse(Console.ReadLine());
            account1.Deposit(amount);

            Console.WriteLine("Please enter the amount you would like to withdrawl");
            amount = double.Parse(Console.ReadLine());
            account1.Withdrawl(amount);

            Console.WriteLine("Ok thank you");
            Console.WriteLine("Here is your balance");
            account1.GetBalance();
        }
    }
}