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
    public partial class Cadastro_das_Empresas : Form
    {

        List<Empresas> empresas = new List<Empresas>();



        public Cadastro_das_Empresas()
        {
            InitializeComponent();
        }

        public Cadastro_das_Empresas(List<Empresas> a)
        {
            InitializeComponent();
            empresas = a;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string cNPJ = maskedTextBox1.Text;
            string razao_Social = textBox1.Text;
            string nome_Fantasia = textBox2.Text;
            string situacao_Cadastral = comboBox1.Text;
            DateTime data_Inicio = dateTimePicker1.MinDate;
            string telefone = maskedTextBox2.Text;
            string capital_Social = textBox3.Text;
            string natureza_Juridica = comboBox3.Text;

            string regime_Tributario = Regime_Tributario();

            string nome_Proprietario = textBox6.Text;
            string cPF_Proprietario = maskedTextBox3.Text;

            string tipo = Tipo();

            string porte_Empresa = Porte_Empresarial();

            string estado = comboBox2.Text;
            string cidade = textBox5.Text;
            string bairro = textBox4.Text;
            string rua = textBox7.Text;
            string numero = textBox8.Text;
            string referencia = textBox9.Text;


            Empresas a = new Empresas(cNPJ, razao_Social, nome_Fantasia, situacao_Cadastral, data_Inicio, telefone,
                capital_Social, natureza_Juridica, regime_Tributario, nome_Proprietario, cPF_Proprietario, tipo, porte_Empresa,
                estado, cidade, bairro, rua, numero, referencia);

            empresas.Add(a);

            this.Hide();
            Form1 b = new Form1(empresas);
            b.ShowDialog();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b = new Form1(empresas);
            b.ShowDialog();
        }

        private void Cadastro_das_Empresas_Load(object sender, EventArgs e)
        {

        }

        private String Regime_Tributario()
        {
            if (radioButton1.Checked == true)
            {
                return radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                return radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                return radioButton3.Text;
            }
            else
            {
                return " ";
            }
        }

        private String Tipo()
        {
            if(radioButton4.Checked == true)
            {
                return radioButton4.Text;
            }
            else if (radioButton5.Checked == true)
            {
                return radioButton5.Text;
            }
            else
            {
                return " ";
            }
        }

        private String Porte_Empresarial()
        {
            if (radioButton8.Checked == true)
            {
                return radioButton8.Text;
            }
            else if (radioButton6.Checked == true)
            {
                return radioButton6.Text;
            }
            else if (radioButton7.Checked == true)
            {
                return radioButton7.Text;
            }
            else
            {
                return " ";
            }
        }

    }
}
