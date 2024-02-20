using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Empresa
{
    public partial class Form1 : Form
    {
        List<Empresas> empresas = new List<Empresas>();
        public Form1()
        {
            InitializeComponent();
        }


        public Form1(List<Empresas> a)
        {
            InitializeComponent();
            empresas = a;
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Cadastro_das_Empresas a = new Cadastro_das_Empresas(empresas);
                a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Lista_das_Empresas b = new Lista_das_Empresas(empresas);
            b.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
