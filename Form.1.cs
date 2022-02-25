using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private bool canChoose = false;
        public int Age {  get; set; }
        public int Period {  get; set; }
        public int Amount {  get; set; }
        public bool EarlyRepayment {  get; set; }


        private List<Bank> BankList = new List<Bank>();
        public Form1()
        {
            InitializeComponent();
            bSelect.Enabled = false;
            ReadFromFile();
            FillList(BankList);
        }

        public void ReadFromFile()
        {
            using (var sr = new StreamReader("..\\..\\banks.txt"))
            {
                
                while (!sr.EndOfStream)
                {
                    string[] parameters = sr.ReadLine().Split();

                    Bank bank = new Bank(
                        parameters[0],
                        Convert.ToInt32(parameters[1]),
                        Convert.ToInt32(parameters[2]),
                        Convert.ToInt32(parameters[3]),
                        Convert.ToInt32(parameters[4]),
                        Convert.ToInt32(parameters[5]),
                        Convert.ToInt32(parameters[6]),
                        Convert.ToDouble(parameters[7]));
                    BankList.Add(bank);

                   // MessageBox.Show(bank.BankName + bank.MaxCreditAmount);
                }
            }
        }

        void FillList(List<Bank> list)
        {
            if (canChoose)
            {
                list.Sort(delegate(Bank a, Bank b) {
                    if (a.CreditRate > b.CreditRate) return 1;
                    else if(a.CreditRate < b.CreditRate) return -1;
                    else return 1;
                });
            }
            foreach (var bank in list)
            {
                string str = bank.BankName;
                if (canChoose)
                {
                    str += " Общий платёж: " + bank.TotalAmount(Amount, Period);
                }
                str += " Процентная ставка: " + bank.CreditRate + "%";
                listBox1.Items.Add(str);
            }
        }
        
        
        public void button1_Click(object sender, EventArgs e)
        {
            if (tbCreditAmount.Text != "" && tbCreditPeriod.Text != "" && tbAge.Text != "")
            {
                canChoose = true;
                listBox1.Items.Clear();
                ReadUserParameters();
                FillList(BankList.Where(x
                    => Age >= x.MinCreditAge && Age <= x.MaxCreditAge &&
                    Period >= x.MinCreditPeriod && Period <= x.MaxCreditPeriod &&
                    Amount >= x.MinCreditAmount && Amount <= x.MaxCreditAmount).ToList());
            }
            else
            {
                canChoose = false;
            }
        }

        private void ReadUserParameters()
        {
            Age = Convert.ToInt32(tbAge.Text);
            Amount = Convert.ToInt32(tbCreditAmount.Text);
            Period = Convert.ToInt32(tbCreditPeriod.Text) * 12;
        }

        private void bSelect_Click(object sender, EventArgs e)
        {

            Bank SelectedBank = BankList.Where(
                bank =>
                    listBox1.SelectedItem.ToString().Split().
                    Contains(bank.BankName)).
                    First();
            panel1.Controls.Clear();
            panel1.Controls.Add(new SelectedBankPanel(SelectedBank, Amount, Period));
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1 && canChoose) {
                bSelect.Enabled = true;
            }
            else
            {
                bSelect.Enabled = false;
            }
        }
    }
}
