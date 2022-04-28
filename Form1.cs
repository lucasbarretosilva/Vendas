using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula31Intermediario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string insereProduto = txtProduto.Text;
            string inserePreco = txtPreco.Text;
            double somatoria = 0.0;
           
            listBox1.Items.Add(insereProduto);
            listBox2.Items.Add(inserePreco);


            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                somatoria = somatoria + Convert.ToDouble(listBox2.Items[i]);
            }

            lblTotalVenda.Text ="Total da Compra: " + Convert.ToString(somatoria);


            


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string itemRemover = txtProduto.Text;
            double somatoria = 0.0;

            for (int i = 0;i < listBox1.Items.Count; i++) // percorre a lista 
            {
                if (itemRemover == listBox1.Items[i].ToString()) // compara 
                {
                    listBox1.Items.RemoveAt(i);
                    listBox2.Items.RemoveAt(i);
                   
                   

                   

                }
            }
            for (int j = 0; j < listBox2.Items.Count; j++) // percorre e soma os valores da listbox
            {
                somatoria = somatoria + Convert.ToDouble(listBox2.Items[j]); // converte para int e soma
            }

            lblTotalVenda.Text = "Total da Compra: " + Convert.ToString(somatoria);
        }
    }
}
