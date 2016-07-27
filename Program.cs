using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


/* ATM Simulation
 * Created by Josh Corps and Zain Mahmood 
 */

namespace ATM_simulation
{
    static class Program
    {

        static AccountData accountData;
        static Account[] currentAccounts;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            accountData = new AccountData(); // set accountData to new accountData
            currentAccounts = accountData.getAccounts(); // set current Acounts to the accounts

            Application.Run(new centralServ()); // run the central server
        }

        public static void newATM()
        {
            new Thread(() => new atmSim(currentAccounts).ShowDialog()).Start(); // creates a new thread and runs an instance of the atmSim form
        }
    }


    // This class stores the account info and creates an Account object with that data
    public class AccountData
    {
        private Account[] ac = new Account[3];

        public AccountData()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }

        public Account[] getAccounts()
        {
            return ac;
        }
    }
    /*
    *   The Account class encapusulates all features of a simple bank account
    */
    public class Account
    {
        //the attributes for the account
        public int numWrongPinAttempts = 0;
        private int balance;
        private bool cardBlocked = false;
        private int pin;
        private int accountNum;

        // string array to store the log. first pos is account, second pos stores last transaction value and time
        // even numbers (0,2,4,etc) are transaction time and odd numbers are the related amount
        private static string[,] transactionLogArray = new string[3,10]; 

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            // loops through to set all of the log array to empty
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    transactionLogArray[i, j] = "empty";
                    tempArray[i, j] = "empty";
                }
            }
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        private static string[,] tempArray = new string[3, 10]; // temp array to hold the log array when moving the array positions up
        public static void setTransactionLog(int accArrPos, string transactionTime, int transactionValue)
        {
            for (int j = 0; j < 10; j++) // loop through the 10 array positions for this account
            {
                if (transactionLogArray[accArrPos, j] == "empty") // if the position is empty
                {
                    transactionLogArray[accArrPos, j] = transactionTime; // set position j to the transaction time
                    transactionLogArray[accArrPos, j + 1] = System.Convert.ToString(transactionValue); // set j+1 to the transaction value
                    return; // exit the method
                }
            }
            // if all array positions filled then this will be executed
            // copies array to temp array and shifts all values up by 2 end removes the first ones
            for (int i = 0, j = 2; j < 10; i++, j++)
            {
                tempArray[accArrPos, i] = transactionLogArray[accArrPos, j];
            }
            // copies temp array back to original array
            for (int i = 0; i < 10; i++)
            {
                transactionLogArray[accArrPos, i] = tempArray[accArrPos, i];
            }
            // places newest transaction data at end of array
            transactionLogArray[accArrPos, 8] = transactionTime;
            transactionLogArray[accArrPos, 9] = System.Convert.ToString(transactionValue);
        }

        // method to return a particular position from the log array
        public static string getLog(int x, int y)
        {
            return transactionLogArray[x,y];
        }

        // getter and setter functions for the block status of the card
        public void setBlockStatus(bool blocked)
        {
            if (blocked)
                cardBlocked = true;
            else
                cardBlocked = false;
        }
        public bool getBlockStatus()
        {
            if (cardBlocked)
                return true;
            else
                return false;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   returns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        private Object lockThread = new Object(); // create a new lock object called lockThread
        static Semaphore semThread = new Semaphore(1, 1); // create a new semaphore called semThread

        public Boolean decrementBalance(int amount)
        {
            if (this.balance >= amount)
            {
                if (centralServ.getDataRaceFixState() == 0) // if the data race option is selected
                {
                    // simulates a data race by storing the current balance in a temp variable then waiting
                    int tempBalance = balance;
                    System.Threading.Thread.Sleep(3000);

                    tempBalance -= amount;
                    balance = tempBalance;
                    return true;
                }
                else if (centralServ.getDataRaceFixState() == 1) // if the data race fix by lock is selected
                {
                    // anything inside the lock can only be accessed by one thread at a time which prevents data races
                    lock (lockThread)
                    {
                        int tempBalance = balance;
                        System.Threading.Thread.Sleep(3000);

                        tempBalance -= amount;
                        //System.Threading.Thread.Sleep(1000);

                        balance = tempBalance;
                        return true;
                    }
                }
                else if (centralServ.getDataRaceFixState() == 2) // if the data race fix by semaphore is selected
                {
                    // anything between waitOne and release can only be accessed by 1 thread at a time
                    semThread.WaitOne();
                    int tempBalance = balance;
                    System.Threading.Thread.Sleep(3000);

                    tempBalance -= amount;
                    //System.Threading.Thread.Sleep(1000);

                    balance = tempBalance;
                    semThread.Release();
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }


        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // method to set the pin of the account
        public void setPin(int newPin)
        {
            this.pin = newPin;
        }

        // method to return the account number
        public int getAccountNum()
        {
            return accountNum;
        }
    }
}
