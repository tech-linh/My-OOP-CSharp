//5. Create a class called "BankAccount" with properties such as "balance" and methods to deposit and withdraw money from the account.

    public class cardHolder
    {
        public static void Main(string[] args)
    {
        cardHolder.CardHolder();
    }


        String cardNum;
        int pin;
        String firstName, lastName;
        double balance;

        private cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public String getNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setNum(String newCardNum)
        {
            cardNum = newCardNum;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }

        public void setFirstName(String newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(String newLastName)
        {
            lastName = newLastName;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
        public static void CardHolder() 
    {

            void printOptions()
            {
                Console.WriteLine("\nPlease choose from one of the following options...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
            }

            void deposit(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to deposit? ");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposit);
                Console.WriteLine("Thank you for using our services! Your new balance is: " + currentUser.getBalance() + " Euro");
            }

            void withdraw(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to withdraw? ");
                double withdrawal = Double.Parse(Console.ReadLine());
                if (currentUser.getBalance() < withdrawal)
                {
                    Console.WriteLine("Insufficient balance!");
                }
                else
                {
                    double newBalance = currentUser.getBalance() - withdrawal;
                    currentUser.setBalance(newBalance);
                    Console.WriteLine("Thank your for using our services! Your new balance is: " + currentUser.getBalance() + " Euro");
                }
            }

            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.getBalance() + " Euro");

            }

            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("qwertz12345", 543210, "Max", "Mustermann", 1006000));
            cardHolders.Add(new cardHolder("1q2w3e4r5t", 123450, "Maya", "Musterfrau", 9958100.26));
            cardHolders.Add(new cardHolder("q1w2e3r4t5", 010203, "Random", "User", 954.29));


            Console.WriteLine("Welcome to SimpleATM");
            Console.WriteLine("Please insert your debit card number: ");
            String debitCardNum = "";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Card was not recognized. Please try again!"); }
                }

                catch
                { Console.WriteLine("Card was not recognized. Please try again!"); }
            }

            Console.WriteLine("Please enter your pin:");
            int userPin = 0;

            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("Incorrect PIN. Please try again!"); }
                }

                catch
                { Console.WriteLine("Incorrect PIN. Please try again!"); }
            }

            Console.WriteLine("Welcome " + currentUser.getFirstName() + " :)");

            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { deposit(currentUser); }
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }

            }
            while (option != 4);
            Console.WriteLine("Thank you for using our services. Have a nice day! ");
        }
    }
