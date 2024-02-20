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
    public partial class Lista_das_Empresas : Form
    {
        List <Empresas> empresas = new List<Empresas>();

        public Lista_das_Empresas()
        {
            InitializeComponent();
            Load += Lista_das_Empresas_Load;
        }



        public Lista_das_Empresas(List <Empresas> a)
        {
            InitializeComponent();
            
            foreach (Empresas p in a)
            {
                empresas.Add(p);
                MessageBox.Show(p.tipo);
                MessageBox.Show(p.regime_Tributario);
                MessageBox.Show(p.porte_Empresa);
            }           

        }

        private void Lista_das_Empresas_Load(object sender, EventArgs e)
        {           
            
            dataGrid.DataSource = null;
            dataGrid.Refresh();
            dataGrid.DataSource = empresas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b = new Form1(empresas);
            b.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
