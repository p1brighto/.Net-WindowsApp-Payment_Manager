/*/*
Assigment-: Payment manager
Author: Brighto Paul
Purpose:To become comfortable with building C# applications in Visual Studio, 
building an application  that process the credit ccard payment and save the data in a dataset.
Date of Submission:18th April,2016
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beanstream.Api.SDK;
using Beanstream.Api.SDK.Domain;
using Beanstream.Api.SDK.Requests;
using Beanstream.Api.SDK.Data;
using Beanstream.Api.SDK.Exceptions;
using System.IO; // For File Operations

namespace Assignment4_Beanstream
{
    public partial class PaymentManager : Form
    {
        public PaymentManager()
        {
            InitializeComponent();
        }
        //exit menu
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitPaymentButton_Click(object sender, EventArgs e)
        {
            //checking whether the fields are empty
            if (amountTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please input a valid amount");
            }
            else if (nameTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please input the Name on the Card");
            }
            else if (cardNumberTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please input the Card Nuber");
            }
            else if (monthComboBox.Text == String.Empty && yearComboBox.Text == String.Empty)
            {
                MessageBox.Show("Please input the Expiry Details");
            }
            else if (cardNumberTextBox.Text == String.Empty)
            {
                MessageBox.Show("Plese input the namber on the back of the card");
            }
            else
            {
                try
                {
                    //validation for the amount
                    if (Convert.ToDouble(amountTextBox.Text) > 1000)
                    {
                        MessageBox.Show("Payment amount is limited to $1,000.");
                    }
                    else if (Convert.ToDouble(amountTextBox.Text) <= 0)
                    {
                        MessageBox.Show("Please input a valid amount");
                    }
                    else
                    {

                        const string paymentsAPIKeyString = "b9950D37FE0c4f92A1177F7C935CcBeA";
                        const int merchantIDInt = 300201147;
                        const string APIVersionInt = "1";

                        // Initialize Gateway connection
                        Gateway bsGateway = new Gateway();
                        bsGateway.MerchantId = merchantIDInt;
                        bsGateway.PaymentsApiKey = paymentsAPIKeyString;
                        bsGateway.ApiVersion = APIVersionInt;

                        // Setup the Credit Card details
                        Card ccCard = new Card();
                        ccCard.Name = nameTextBox.Text;
                        ccCard.Number = cardNumberTextBox.Text;
                        ccCard.ExpiryMonth = monthComboBox.SelectedItem.ToString();
                        ccCard.ExpiryYear = yearComboBox.SelectedItem.ToString();
                        ccCard.Cvd = cvvTextBox.Text;

                        // Setup the payment request
                        CardPaymentRequest reqCardPaymentRequest = new CardPaymentRequest();
                        reqCardPaymentRequest.Amount = Convert.ToDouble(amountTextBox.Text);

                        reqCardPaymentRequest.OrderNumber = "1264561589aa0" + DateTime.Now.TimeOfDay;
                        reqCardPaymentRequest.Card = ccCard;
                        // Process the payment and get the response from their servers
                        PaymentResponse response = bsGateway.Payments.MakePayment(reqCardPaymentRequest);
                        MessageBox.Show("Payment "+response.Message);//status message
                        //save data in the dat set
                        paymentsTableAdapter.Insert(
                            response.Created.ToString(),
                            response.Message,
                            response.Card.CardType,
                            nameTextBox.Text,
                            response.Card.LastFour,
                            Convert.ToDecimal(amountTextBox.Text),
                            response.OrderNumber,
                            response.TransactionId
                            );
                        //clearing fields
                        paymentsTableAdapter.Fill(paymentsDataSet.Payments);
                        amountTextBox.Text = nameTextBox.Text = cardNumberTextBox.Text = cvvTextBox.Text = String.Empty;
                        monthComboBox.SelectedIndex = yearComboBox.SelectedIndex = -1;
                        amountTextBox.Focus();
                    }
                }

                catch
                {
                    MessageBox.Show("Invalid Payment Information. Payment was unsuccessful");
                }         
            }
        }
        //set up clear button
        private void clearfieldsButton_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = nameTextBox.Text = cardNumberTextBox.Text = cvvTextBox.Text = "";
            monthComboBox.SelectedIndex=yearComboBox.SelectedIndex = -1;
            amountTextBox.Focus();
        }
        //validate keypress
        private void cvvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.paymentsDataSet);

        }

        private void PaymentManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentsDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.paymentsDataSet.Payments);

        }
        //validate keyppress
        private void cardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        //validate teh keypress
        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        //Buck up the files
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initial values in the save dialog
            saveFileDialog.FileName = "payments.csv";
            saveFileDialog.DefaultExt = ".csv";
            saveFileDialog.Title = "Please choose the location to save";
            saveFileDialog.Filter= "Your CSV File(*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    StreamWriter swStreamWriter = new StreamWriter(saveFileDialog.FileName, false);

                    int countColumn = paymentsDataGridView.ColumnCount ;
                    //loop through each row
                    foreach (DataGridViewRow obj in paymentsDataGridView.Rows)
                    {
                        if (!obj.IsNewRow)
                        {
                            string data = "";

                            data = obj.Cells[1].Value.ToString();
                            //loop throgh each column
                            for (int i = 2; i < countColumn; i++)
                            {
                                
                                if(i==6)
                                {
                                    data = data + ',' + obj.Cells[i].Value.ToString();
                                }
                                else
                                {
                                    data = data + ',' + obj.Cells[i].Value;
                                }
                           }
                         //save data in the file
                        swStreamWriter.WriteLine(data);
                    }
                }

                swStreamWriter.Flush();
                swStreamWriter.Close();

               }
                //error message
                catch (Exception)
                {
                    MessageBox.Show("Cannot save to the file.");
                }
            }
        }
    }
}
