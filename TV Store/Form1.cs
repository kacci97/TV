using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProdadi_Click(object sender, EventArgs e)
        {
            TV televizor = lbTelevizori.SelectedItem as TV;
            televizor.Prodazbi++;
            lbProdadeni.Text = "Продадени " + televizor.Prodazbi;

        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            AddTV novTV = new AddTV();
            if (novTV.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbTelevizori.Items.Add(novTV.TV);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сакате да го избришете телевизорот?","Избриши телевизор", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lbTelevizori.Items.RemoveAt(lbTelevizori.SelectedIndex);
            }
        }

        private void rbMostSales_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public TV  najprodavan()
        {
            int mostSale = 0;
            TV prodavan=new TV();

            foreach (TV tv in lbTelevizori.Items)

                {
                if (tv.Prodazbi > mostSale)
                    mostSale = tv.Prodazbi;
                prodavan = tv;
          
                }
            return prodavan;
            
            
            }

        public TV najresolucija()
        {
            int mostResolution = 0;
            TV resoluc = new TV();

            foreach (TV tv in lbTelevizori.Items)

            {
                if (tv.Resolucija > mostResolution)
                    mostResolution = tv.Resolucija;
                resoluc = tv;

            }
            return resoluc;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void rbResolution_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbResolution_Click(object sender, EventArgs e)
        {
            if (rbResolution.Checked)
            {
                textBox1.Text = najresolucija().ToString();


            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void rbMostSales_Click(object sender, EventArgs e)
        {

            if (rbMostSales.Checked)
            {
                textBox1.Text = najprodavan().ToString();
            }
            else
            {
                textBox1.Text = "";
            }

        }
    }
}
