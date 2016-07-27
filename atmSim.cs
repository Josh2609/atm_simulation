using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATM_simulation
{
    public partial class atmSim : Form
    {
        public Account[] ac; // creat an array of the class account called ac
        string numPadInput = "";
        string currScreen = "acc";

        // constructor
        public atmSim(Account[] ac)
        {
            InitializeComponent();

            this.ac = ac;
        }

        int activeAccNum, activePIN, accArrPos; // variables to store the active account number, pin and position in the array

        // method which checks the account details provided on the login screen against the ones stored in the account class
        private bool checkAccDetails()
        {
            bool valid = false; // declare a variable to store whether the account details are valid, and set it to false
            int accNum = System.Convert.ToInt32(activeAccNum); // declare an int variable to store the active account number
            int pin = System.Convert.ToInt32(activePIN); // declare an int variable to store the active PIN

            // loop through the array
            for (int i = 0; i < ac.Length; i++)
            {
                if (accNum == ac[i].getAccountNum()) // if there is a matching account number
                {
                    accArrPos = i; // set the array position to i
                    valid = ac[i].checkPin(pin); // check the pin against the account and set the result to valid
                    if (valid == false) // if the pin is not a match
                    {
                        ac[i].numWrongPinAttempts++; // then increment the number of wrong attempts
                    }
                    if (ac[i].getBlockStatus() == true) // if the card has been blocked
                    {
                        valid = false; // then set valid to false
                    }
                    return valid;
                }
            }
            return valid;
        }

        // method for when the form is first loaded
        private void atmSim_Load(object sender, EventArgs e)
        {
            // set maximum and minimum sizes of the form
            this.MaximumSize = new Size(517, 694);
            this.MinimumSize = new Size(517, 694);

            // set locations and sizes of various ui elements
            lblDisplayOut.Location = new Point(82, 34);
            lblDisplayOut.Size = new Size(339, 255);
            lblCurrTime.Location =  new Point(339, 34);

            lblScreenBtn1.Location = new Point(83,133);
            lblScreenBtn2.Location = new Point(83,178);
            lblScreenBtn3.Location = new Point(83,223);
            lblScreenBtn4.Location = new Point(83,266);
            lblScreenBtn5.Location = new Point(311,133);
            lblScreenBtn6.Location = new Point(311,179);
            lblScreenBtn7.Location = new Point(311,223);
            lblScreenBtn8.Location = new Point(311,266);

            btnScreen1.Location = new Point(14, 123); btnScreen1.Size = new Size(29, 32);
            btnScreen2.Location = new Point(14, 167); btnScreen2.Size = new Size(29, 32);
            btnScreen3.Location = new Point(14, 211); btnScreen3.Size = new Size(29, 32);
            btnScreen4.Location = new Point(14, 253); btnScreen4.Size = new Size(29, 32);
            btnScreen5.Location = new Point(457, 123); btnScreen5.Size = new Size(29, 32);
            btnScreen6.Location = new Point(457, 167); btnScreen6.Size = new Size(29, 32);
            btnScreen7.Location = new Point(457, 211); btnScreen7.Size = new Size(29, 32);
            btnScreen8.Location = new Point(457, 253); btnScreen8.Size = new Size(29, 32);

            btnNum1.Location = new Point(161,360); btnNum1.Size = new Size(38, 41);
            btnNum2.Location = new Point(203,360); btnNum2.Size = new Size(38, 41);
            btnNum3.Location = new Point(245,360); btnNum3.Size = new Size(38, 41);
            btnNum4.Location = new Point(161,405); btnNum4.Size = new Size(38, 41);
            btnNum5.Location = new Point(203,405); btnNum5.Size = new Size(38, 41);
            btnNum6.Location = new Point(245,405); btnNum6.Size = new Size(38, 41);
            btnNum7.Location = new Point(161,451); btnNum7.Size = new Size(38, 41);
            btnNum8.Location = new Point(203,451); btnNum8.Size = new Size(38, 41);
            btnNum9.Location = new Point(245, 451); btnNum9.Size = new Size(38, 41);
            btnNum0.Location = new Point(203,496); btnNum0.Size = new Size(38, 41);
            btnNumInactiveL.Location = new Point(161,496); btnNumInactiveL.Size = new Size(38, 41);
            btnNumInactiveR.Location = new Point(245,496); btnNumInactiveR.Size = new Size(38, 41);

            btnNumCancel.Location = new Point(302,360); btnNumCancel.Size = new Size(56,41);
            btnNumClear.Location = new Point(302,405); btnNumClear.Size = new Size(56,41);
            btnNumEnter.Location = new Point(302,451); btnNumEnter.Size = new Size(56,41);
            btnNumInactiveLong.Location = new Point(302, 496); btnNumInactiveLong.Size = new Size(56, 41);

            lblAccNum.Location = new Point(207,123);
            lblPIN.Location = new Point(233,123);
            tbAccNum.Location = new Point(210,143);
            tbPIN.Location = new Point(210,143);
            lblLoginErrorMsg.Location = new Point(160, 174);
            tbSetPin.Location = new Point(210, 143);
            pbATM.Location = new Point(0, 0);
            pbATM.Size = new Size(500, 321);

            this.ControlBox = false; // removes maximise, minimise and close buttons from form
            System.Windows.Forms.Timer currentTimer = new System.Windows.Forms.Timer(); // declares a timer
            currentTimer.Interval = 1000; // sets the timer interval to a second
            currentTimer.Tick += new EventHandler(currentTimer_Tick); // declare an event handler for timer tick
            currentTimer.Start(); // start the timer
        }

        // event handler for the timer tick
        private void currentTimer_Tick(object sender, EventArgs e)
        {
            lblCurrTime.Text = DateTime.Now.ToString("h:mm:ss tt"); // get the current time and update the label with it
        }

        // method to handle withdrawing cash
        private void withdrawCash(int amount)
        {
            bool validWithdraw = false; // set validWithdraw to false
            validWithdraw = ac[accArrPos].decrementBalance(amount); // set validWithdraw to the return of the account withdraw method
            if (validWithdraw == true) // if the withdrawal is valid
            {
                currScreen = "validWithdraw"; // set current screen to validWithdraw
                screenLblVisibility(false); // hide the main menu labels

                Account.setTransactionLog(accArrPos, DateTime.Now.ToString("h:mm:ss tt"), amount); // add the time and value to the transaction log

                lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\nWithdrawal Successful\n\n"
                              + "New account balance = £" + ac[accArrPos].getBalance()
                              + "\n\nPress Enter to return to menu"; // display a message to the user
            } else { // if the withdrawal is not valid
                screenLblVisibility(false); // hide the main menu labels

                lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\nInsufficient Funds\n\n"
                              + "Account balance = £" + ac[accArrPos].getBalance()
                              + "\n\nPress Enter to return to menu"; // display a message to the user
            }
        }

        // method for adding the numpad entries to various entities
        private void addNumPad(string value)
        {
            if (currScreen == "acc") // if the screen is the account login screen 
            {
                if (numPadInput.Length < 6) // check that the text is less than 6
                {
                    numPadInput += value; // add the number selected
                    tbAccNum.Text = numPadInput; // update the ui
                }
            }
            else if (currScreen == "pin") // if the screen is the pin login screen 
            {
                if (numPadInput.Length < 4) // check that the text is less than 4
                {
                    numPadInput += value; // add the number selected
                    tbPIN.Text = numPadInput; // update the ui
                }
            }
            else if (currScreen == "setPin") // if the screen is the change pin screen
            {
                if (numPadInput.Length < 4) // check that the text is less than 4
                {
                    numPadInput += value; // add the number selected
                    tbSetPin.Text = numPadInput; // update the ui
                }
            }
        }     

        // event handler for when the enter button is pressed
        private void btnNumEnter_Click(object sender, EventArgs e)
        {
            if (currScreen == "acc") // if the current screen is acc
            {
                if (numPadInput.Length != 6) // if the length of the input is not 6
                {
                    lblLoginErrorMsg.Text = "Account Number must be 6 digits long"; // change the text on the error label
                    lblLoginErrorMsg.Show(); // display the error label
                }
                else if (tbAccNum.Text != "") // if the input is not blank 
                {
                    lblLoginErrorMsg.Hide(); // hide the error label
                    activeAccNum = System.Convert.ToInt32(tbAccNum.Text); // set the active account number to the value in the text box
                    tbAccNum.Text = ""; // set the text box to empty
                    tbAccNum.Hide(); // hide the text box
                    lblAccNum.Hide(); // hide the label
                    tbPIN.Show(); // show the PIN text box
                    lblPIN.Show(); // show the PIN label
                    numPadInput = ""; // empty numPadInput
                    currScreen = "pin"; // set the current screen to pin
                }
            }
            else if (currScreen == "pin") // if the current screen is pin
            {
                if (numPadInput.Length != 4) // if the length of the input is not 4
                {
                    lblLoginErrorMsg.Text = "          PIN must be 4 digits long"; // change the text on the error label
                    lblLoginErrorMsg.Show(); // display the error label
                }
                else if (tbPIN.Text != "") // if the input is not blank 
                {
                    activePIN = System.Convert.ToInt32(tbPIN.Text); // set the active account number to the value in the text box
                    tbPIN.Text = ""; // set the text box to empty
                    lblLoginErrorMsg.Hide(); // hide the error label
                    bool validAccount = false; // declare a variable called validAccount to hold whether the account is valid and set it to false
                    validAccount = checkAccDetails(); // set valid account to the return of checkAccDetails()
                    if (validAccount == true) // if the account is valid
                    {
                        tbPIN.Hide(); // hide the pin text box
                        lblPIN.Hide(); // hide the pin label
                        currScreen = "userMainMenu"; // set the current screen to userMainMenu
                        lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum // change the display output label
                              + "\n\n\nPlease choose from the following Menu Items\n";
                        numPadInput = ""; // empty the numPadInput

                        screenLblVisibility(true); // display the main menu
                    }
                    else if (validAccount == false) // if the account was not valid
                    {
                        lblLoginErrorMsg.Text = "Account Number or PIN incorrect.\nPlease try again"; // change the text on the error label
                        lblLoginErrorMsg.Show(); // display the error label

                        if (ac[accArrPos].numWrongPinAttempts < 3) // if the number of incorrect attempts is less than 3
                        {
                            // then let the user try again
                            tbAccNum.Show();
                            lblAccNum.Show();
                            tbPIN.Hide();
                            lblPIN.Hide();
                            numPadInput = "";
                            currScreen = "acc";
                        }
                        else if (ac[accArrPos].numWrongPinAttempts >= 3) // blocks card and exits thread if 3 incorrect pin entries
                        {
                            lblLoginErrorMsg.Hide(); // hide the error label
                            ac[accArrPos].setBlockStatus(true); // set block status on the card to true
                            lblDisplayOut.Text = "Too many incorrect PIN entries\n\nCard Blocked\n\nExiting...";
                            lblPIN.Hide(); // hide the label
                            tbPIN.Hide(); // hide the text box
                            this.Update(); // update the ui
                            System.Threading.Thread.Sleep(3000); // sleep the thread for 3 seconds
                            centralServ.currActTerminals--; // decrement the number of active terminals
                            this.Close(); // close the thread
                        }
                    }
                }
            }
            // if the current screen is withdrawMenu, checkBalanceMenu, successfulPinChange or recentTransactions
            else if (currScreen == "withdrawMenu" || currScreen == "checkBalanceMenu" || currScreen == "successfulPinChange" || currScreen == "recentTransactions")
            {
                lblPIN.Hide(); // hide the label
                tbPIN.Hide(); // hide the text box
                currScreen = "userMainMenu"; // set the current screen to userMainMenu
                lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\n\nPlease choose from the following Menu Items\n";
                numPadInput = "";

                // change the text if the labels next to the buttons to be relevant to the new menu
                lblScreenBtn1.Text = "Withdraw Cash";
                lblScreenBtn2.Text = "Check Balance";
                lblScreenBtn3.Text = "Return Card";
                lblScreenBtn4.Text = "Change PIN";
                lblScreenBtn5.Text = "Recent Transactions";

                screenLblVisibility(true);  // display the main menu
            }
            else if (currScreen == "setPin") // if the current screen is setPin
            {
                if (numPadInput.Length == 4) // if the length of the input is 4
                {
                    int newPin = System.Convert.ToInt32(numPadInput); // convert the input to an int and set newPin to it
                    ac[accArrPos].setPin(newPin); // call method setPin to set the pin
                    tbSetPin.Hide(); // hide the text box
                    // display a message to the user
                    lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\n\n\n"
                              + "PIN Successfully Changed"
                              + "\n\nPress Enter to return to menu";
                    numPadInput = ""; // empty the numPadInput
                    tbSetPin.Text = numPadInput; // empty the setPin text box
                    currScreen = "successfulPinChange"; // set current screen to successfulPinChange
                }
                else // else if the pin was not changed
                {
                    // inform the user
                    lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                             + "\n\n\n\n"
                             + "Error PIN was not changed, must be 4 digits long. Please try again.";
                    numPadInput = ""; // empty numPadInput
                    tbSetPin.Text = numPadInput; // empty setPin text box
                }
            }
            else if (currScreen == "validWithdraw") // if the current screen is validWithdraw
            {
                currScreen = "userMainMenu"; // set the current screen to userMainMenu
                lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\n\nPlease choose from the following Menu Items\n";
                numPadInput = "";

                // change the menu options to the main options
                lblScreenBtn1.Text = "Withdraw Cash";
                lblScreenBtn2.Text = "Check Balance";
                lblScreenBtn3.Text = "Return Card";
                lblScreenBtn4.Text = "Change PIN";
                lblScreenBtn5.Text = "Recent Transactions";

                screenLblVisibility(true); // display the menu options
            }
        }

        // event handler for pressing menu button 1
        private void btnScreen1_Click(object sender, EventArgs e)
        {
            if (currScreen == "userMainMenu") // if the current screen is userMainMenu
            {
                currScreen = "withdrawMenu"; // set current screen to withdrawMenu
                // change the menu labels to be the denominations that can be withdrawn
                lblScreenBtn1.Text = "£10";
                lblScreenBtn2.Text = "£20";
                lblScreenBtn3.Text = "£40";
                lblScreenBtn4.Text = "£100";
                lblScreenBtn5.Text = "£500";
            }
            else if (currScreen == "withdrawMenu") // else if the current screen is the withdraw menu
            {
                withdrawCash(10); // call withdrawCash and pass in 10
            }
        }

        // event handler for pressing menu button 2
        private void btnScreen2_Click(object sender, EventArgs e)
        {
            if (currScreen == "userMainMenu") // if the current screen is userMainMenu
            {
                screenLblVisibility(false); // hide the menu labels
                currScreen = "checkBalanceMenu"; // change current screen to checkBalanceMenu
                lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\n\n\n"
                              + "Current account balance = £" + ac[accArrPos].getBalance()
                              + "\n\nPress Enter to return to menu"; // display the current balance to the user
            }
            else if (currScreen == "withdrawMenu") // else if the current screen is the withdraw menu
            {
                withdrawCash(20); // call withdrawCash and pass in 20
            }
        }

        // event handler for pressing menu button 3
        private void btnScreen3_Click(object sender, EventArgs e)
        {
            if (currScreen == "userMainMenu") // if the current screen is userMainMenu
            {
                centralServ.currActTerminals--; // decrement the current terminals
                this.Close(); // close the form
            }
            else if (currScreen == "withdrawMenu") // else if the current screen is the withdraw menu
            {
                withdrawCash(40); // call withdrawCash and pass in 40
            }
        }

        // event handler for pressing menu button 4
        private void btnScreen4_Click(object sender, EventArgs e)
        {
            if (currScreen == "userMainMenu") // if the current screen is userMainMenu
            {
                screenLblVisibility(false); // hide the menu labels
                tbSetPin.Show(); // show the set pin text box
                currScreen = "setPin"; // set the current screen to setPin
                lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\n\n\n"
                              + "Please enter your new PIN below and press enter"; // prompt the user to enter their new pin
            }
            else if (currScreen == "withdrawMenu") // else if the current screen is the withdraw menu
            {
                withdrawCash(100); // call withdrawCash and pass in 100
            }
        }

        // event handler for pressing menu button 5
        private void btnScreen5_Click(object sender, EventArgs e)
        {
            if (currScreen == "userMainMenu") // if the current screen is userMainMenu
            {
                screenLblVisibility(false); // hide the menu labels

                currScreen = "recentTransactions"; // set the current screen to recentTransactions
                lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\n\n"
                              + "\nTransaction Time               Value"; // display the headings
                for (int i = 0; i < 10; i += 2) // loop through and display the time and value of 5 recent transactions
                {
                    if (Account.getLog(accArrPos, i) == "empty") // if the array position is empty
                    {
                        lblDisplayOut.Text += "\n" + Account.getLog(accArrPos, i)
                            + "                                 " + Account.getLog(accArrPos, i + 1); // more space between the data is needed
                    }
                    else
                    {
                        lblDisplayOut.Text += "\n" + Account.getLog(accArrPos, i)
                            + "                         £" + Account.getLog(accArrPos, i + 1);
                    }
                }
                lblDisplayOut.Text += "\n\nPress Enter to return to menu"; // prompt the user to press enter to return
            }
            else if (currScreen == "withdrawMenu") // else if the current screen is the withdraw menu
            {
                withdrawCash(500); // call withdrawCash and pass in 500
            }
        }

        // event handlers for 3 currently unused buttons at the side of the atm screen
        private void btnScreen6_Click(object sender, EventArgs e) { }
        private void btnScreen7_Click(object sender, EventArgs e) { }
        private void btnScreen8_Click(object sender, EventArgs e) { }  

        // event handler for pressing the clear button
        private void btnNumClear_Click(object sender, EventArgs e)
        {
            numPadInput = ""; // empty the numPadInput
            if (currScreen == "acc") // if the current screen is acc
            {
                tbAccNum.Text = ""; // empty the account number text box
            }
            else if (currScreen == "pin") // if the current screen is pin
            {
                tbPIN.Text = ""; // empty the pin text box
            }
            else if (currScreen == "setPin") // if the current screen is setPin
            {
                tbSetPin.Text = ""; // empty the set pin text box
            }
        }

        // event handler for pressing the cancel button
        private void btnNumCancel_Click(object sender, EventArgs e)
        {
            if (currScreen == "acc") // if current screen is acc
            {
                centralServ.currActTerminals--; // decrement current active terminals
                this.Close(); // close the form
            }
            else if (currScreen == "pin") // if current screen is pin
            {
                // hide and show the relevant ui elements
                tbPIN.Hide();
                lblPIN.Hide();
                tbAccNum.Show();
                lblAccNum.Show();
                numPadInput = ""; // empty numPadInput
                currScreen = "acc"; // set current screen to acc
            }
            // if the current screen is withdrawMenu, checkBalanceMenu, successfulPinChange or setPin
            else if (currScreen == "withdrawMenu" || currScreen == "checkBalanceMenu" || currScreen == "setPin" || currScreen == "successfulPinChange")
            {
                currScreen = "userMainMenu"; // set current menu to userMainMenu
                lblDisplayOut.Text = "Welcome Account Number: " + activeAccNum
                              + "\n\n\nPlease choose from the following Menu Items\n";
                numPadInput = "";

                // change the menu options to the main options
                lblScreenBtn1.Text = "Withdraw Cash";
                lblScreenBtn2.Text = "Check Balance";
                lblScreenBtn3.Text = "Return Card";
                lblScreenBtn4.Text = "Change PIN";
                lblScreenBtn4.Text = "Recent Transactions";
 
                screenLblVisibility(true); // show the menu options
                tbSetPin.Hide(); // hide the setPin text box
            }
        }

        // method to change the visibility of the menu labels
        private void screenLblVisibility(bool visibility)
        {
            lblScreenBtn1.Visible = visibility;
            lblScreenBtn2.Visible = visibility;
            lblScreenBtn3.Visible = visibility;
            lblScreenBtn4.Visible = visibility;
            lblScreenBtn5.Visible = visibility;
        }

        // event handlers for the number pad buttons. calls the method addNumPad and passes in the relevant value
        private void btnNum1_Click(object sender, EventArgs e) { addNumPad("1"); }
        private void btnNum2_Click(object sender, EventArgs e) { addNumPad("2"); }
        private void btnNum3_Click(object sender, EventArgs e) { addNumPad("3"); }
        private void btnNum4_Click(object sender, EventArgs e) { addNumPad("4"); }
        private void btnNum5_Click(object sender, EventArgs e) { addNumPad("5"); }
        private void btnNum6_Click(object sender, EventArgs e) { addNumPad("6"); }
        private void btnNum7_Click(object sender, EventArgs e) { addNumPad("7"); }
        private void btnNum8_Click(object sender, EventArgs e) { addNumPad("8"); }
        private void btnNum9_Click(object sender, EventArgs e) { addNumPad("9"); }
        private void btnNum0_Click(object sender, EventArgs e) { addNumPad("0"); }
    }
}
