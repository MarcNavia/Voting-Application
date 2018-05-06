// Application Name: Bell Tower Capital Management Voting Application
// App Developer: Marc Navia
// Created: 4/26/2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_Application_Belltower_Capitial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Declaring global variables to be use throughout the application

        int ticker1BuyTotal = 0, ticker2BuyTotal = 0, ticker3BuyTotal = 0, ticker4BuyTotal = 0;
        int ticker1SellTotal = 0, ticker2SellTotal = 0, ticker3SellTotal = 0, ticker4SellTotal = 0;

        private void ticker2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allows for charachters to be type into the textbox

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ticker3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allows for charachters to be type into the textbox

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ticker4TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allows for charachters to be type into the textbox

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //When user click exit, give them the option to either leave or not

            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void ticker1TextBox_Click(object sender, EventArgs e)
        {
            ticker1TextBox.SelectAll();
        }

        private void ticker2TextBox_Click(object sender, EventArgs e)
        {
            ticker2TextBox.SelectAll();
        }

        private void ticker3TextBox_Click(object sender, EventArgs e)
        {
            ticker3TextBox.SelectAll();
        }

        private void ticker4TextBox_Click(object sender, EventArgs e)
        {
            ticker4TextBox.SelectAll();
        }

        private void ticker1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the selected ticker to be use for voting

            ticker1TextBox.Enabled = true;
            abstainTicker1RadioButton.Enabled = true;
            buyTicker1RadioButton.Enabled = true;
            sellTicker1RadioButton.Enabled = true;
        }

        private void ticker2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the selected ticker to be use for voting

            ticker2TextBox.Enabled = true;
            abstainTicker2RadioButton.Enabled = true;
            buyTicker2RadioButton.Enabled = true;
            sellTicker2RadioButton.Enabled = true;
        }

        private void ticker3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the selected ticker to be use for voting

            ticker3TextBox.Enabled = true;
            abstainTicker3RadioButton.Enabled = true;
            buyTicker3RadioButton.Enabled = true;
            sellTicker3RadioButton.Enabled = true;
        }

        private void ticker4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the selected ticker to be use for voting

            ticker4TextBox.Enabled = true;
            abstainTicker4RadioButton.Enabled = true;
            buyTicker4RadioButton.Enabled = true;
            sellTicker4RadioButton.Enabled = true;
        }

        private void ticker1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allows for charachters to be type into the textbox

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void displayResultsButton_Click(object sender, EventArgs e)
        {
            //Declaring local variables

            int ticker1FinalTalley, ticker2FinalTalley, ticker3FinalTalley, ticker4FinalTalley;
            
            //Calculating the Final vote Talley

            ticker1FinalTalley = ticker1BuyTotal - ticker1SellTotal;
            ticker2FinalTalley = ticker2BuyTotal - ticker2SellTotal;
            ticker3FinalTalley = ticker3BuyTotal - ticker3SellTotal;
            ticker4FinalTalley = ticker4BuyTotal - ticker4SellTotal;

            //Sends the ticker vote total to the labels

            ticker1Label.Text = ticker1FinalTalley.ToString();
            ticker2Label.Text = ticker2FinalTalley.ToString();
            ticker3Label.Text = ticker3FinalTalley.ToString();
            ticker4Label.Text = ticker4FinalTalley.ToString();

            //Conditional logical that determines if the stock has included, exlucuded or resulted in a tie.

            if (ticker1CheckBox.Checked == true)
            {
                if (ticker1FinalTalley < 0)
                    resultsListBox.Items.Add(ticker1TextBox.Text + " has been voted to be excluded from the Bell Tower Capital Management Portfolio.");
                else if (ticker1FinalTalley == 0)
                    resultsListBox.Items.Add(ticker1TextBox.Text + " total vote has resulted in a tie. Managing Director must cast deciding vote.");
                else if (ticker1FinalTalley > 0)
                    resultsListBox.Items.Add(ticker1TextBox.Text + " has been voted into the Bell Tower Capital Management Portfolio!");
            }
            else
            {

            }

            resultsListBox.Items.Add("");
            
            if (ticker2CheckBox.Checked == true)
            {
                if (ticker2FinalTalley < 0)
                    resultsListBox.Items.Add(ticker2TextBox.Text + " has been voted to be excluded from the Bell Tower Capital Management Portfolio.");
                else if (ticker2FinalTalley == 0)
                    resultsListBox.Items.Add(ticker2TextBox.Text + " total vote has resulted in a tie. Managing Director must cast deciding vote.");
                else if (ticker2FinalTalley > 0)
                    resultsListBox.Items.Add(ticker2TextBox.Text + " has been voted into the Bell Tower Capital Management Portfolio!");
            }
            else
            {

            }

            resultsListBox.Items.Add("");

            if (ticker3CheckBox.Checked == true)
            {
                if (ticker3FinalTalley < 0)
                    resultsListBox.Items.Add(ticker3TextBox.Text + " has been voted to be excluded from the Bell Tower Capital Management Portfolio.");
                else if (ticker3FinalTalley == 0)
                    resultsListBox.Items.Add(ticker3TextBox.Text + " total vote has resulted in a tie. Managing Director must cast deciding vote.");
                else if (ticker3FinalTalley > 0)
                    resultsListBox.Items.Add(ticker3TextBox.Text + " has been voted into the Bell Tower Capital Management Portfolio!");
            }
            else
            {

            }

            resultsListBox.Items.Add("");

            if (ticker4CheckBox.Checked == true)
            {
                if (ticker4FinalTalley < 0)
                    resultsListBox.Items.Add(ticker4TextBox.Text + " has been voted to be excluded from the Bell Tower Capital Management Portfolio.");
                else if (ticker4FinalTalley == 0)
                    resultsListBox.Items.Add(ticker4TextBox.Text + " total vote has resulted in a tie. Managing Director must cast deciding vote.");
                else if (ticker4FinalTalley > 0)
                    resultsListBox.Items.Add(ticker4TextBox.Text + " has been voted into the Bell Tower Capital Management Portfolio!");
            }
            else
            {

            }
         
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            int voteValue = 0;

            //Decicides the voting weight

            try
            {
                if (analystRadioButton.Checked)
                    voteValue = 1;
                else if (associateRadioButton.Checked)
                    voteValue = 4;
                else if (directorRadioButton.Checked)
                    voteValue = 9;


                //Tallying votingbox1

                if (buyTicker1RadioButton.Checked)
                    ticker1BuyTotal += voteValue;
                else if (sellTicker1RadioButton.Checked)
                    ticker1SellTotal -= voteValue;
                else if (abstainTicker1RadioButton.Checked)
                    ticker1BuyTotal += 0;
                    ticker1SellTotal += 0;

                //Tallying votingbox2

                if (buyTicker2RadioButton.Checked)
                    ticker2BuyTotal += voteValue;
                else if (sellTicker2RadioButton.Checked)
                    ticker2SellTotal -= voteValue;
                else if (abstainTicker2RadioButton.Checked)
                    ticker2BuyTotal += 0;
                    ticker2SellTotal += 0;


                //Tallying votingbox3

                if (buyTicker3RadioButton.Checked)
                    ticker3BuyTotal += voteValue;
                else if (sellTicker3RadioButton.Checked)
                    ticker3SellTotal -= voteValue;
                else if (abstainTicker3RadioButton.Checked)
                    ticker3BuyTotal += 0;
                    ticker3SellTotal += 0;

                //Tallying votingbox4

                if (buyTicker4RadioButton.Checked)
                    ticker4BuyTotal += voteValue;
                else if (sellTicker4RadioButton.Checked)
                    ticker4SellTotal -= voteValue;
                else if (abstainTicker4RadioButton.Checked)
                    ticker4BuyTotal += 0;
                    ticker1SellTotal += 0;

                //Setting the radio buttons back to default

                this.analystRadioButton.Checked = true;
                this.abstainTicker1RadioButton.Checked = true;
                this.abstainTicker2RadioButton.Checked = true;
                this.abstainTicker3RadioButton.Checked = true;
                this.abstainTicker4RadioButton.Checked = true;
            }
            catch (Exception err)
            {
                //Returns a error message if a problem is caught

                MessageBox.Show(err.Message);
            }

        }
    }
}
