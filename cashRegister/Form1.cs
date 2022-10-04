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
using System.Media;

namespace cashRegister
{
    public partial class Form1 : Form
    {
        double marioGame = 60.00;
        double zeldaGame = 80.00;
        double metroidGame = 70.00;
        double marioAmount = 0;
        double zeldaAmount = 0;
        double metroidAmount = 0;
        double taxRate = 0.13;
        double subtotal;
        double taxAmount;
        double totalPrice;
        double tendered;
        double change;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gameLabel3_Click(object sender, EventArgs e)
        {

        }

        private void calcButtton1_Click(object sender, EventArgs e)
        {
            try
            {
                marioAmount = Convert.ToDouble(gameBox1.Text);
                zeldaAmount = Convert.ToDouble(gameBox2.Text);
                metroidAmount = Convert.ToDouble(gameBox3.Text);

                subOutput.ForeColor = Color.Black;
                taxOutput.ForeColor = Color.Black;
                totalOutput.ForeColor = Color.Black;

                subtotal = (marioGame * marioAmount) + (zeldaGame * zeldaAmount) + (metroidGame * metroidAmount);
                taxAmount = taxRate * subtotal;
                totalPrice = taxAmount + subtotal;

                subOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalPrice.ToString("C")}";
            }
            catch
            {
                subOutput.ForeColor = Color.Black;
                subOutput.Text = "Input Error";
                taxOutput.ForeColor = Color.Black;
                taxOutput.Text = "Input Error";
                totalOutput.ForeColor = Color.Black;
                totalOutput.Text = "Input Error";
            }



        }

        private void calcButton2_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tendBox.Text);

                changeOutput.ForeColor = Color.Black;

                change = tendered - totalPrice;

                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                changeOutput.ForeColor = Color.Black;
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Print Receipt
            
            receiptLabel.Visible = true;
            receiptLabel.Text = "";
            receiptLabel.Text = $"\n                Receipt";
            Refresh();
            Thread.Sleep(1000);
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.reciptSound);
            alertPlayer.Play();
            receiptLabel.Text += $"\n\n Thank You For Purchasing At              Nintendo";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n Order Number 4015\n October 3rd";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n New Super Mario \n Bros Deluxe         x{marioAmount}      @${marioGame * marioAmount}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n The Legend Of Zelda \n Breath Of The Wild  x{zeldaAmount}      @${zeldaGame * zeldaAmount}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n Metriod Dread       x{metroidAmount}      @${metroidGame * metroidAmount}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n Subtotal                    {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n Tax                         {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n Total                       {totalPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n Thank You For Your Money \n -Nintendo";
        }

        private void restartLabel_Click(object sender, EventArgs e)
        {
            //Reset Whole Thing
            gameBox1.Text = "";
            gameBox2.Text = "";
            gameBox3.Text = "";
            subOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            receiptLabel.Text = "";
            tendBox.Text = "";
            changeOutput.Text = "";
            receiptLabel.Visible = false;


        }

        private void receiptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
