using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaMoto {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        

        Moto Motoca = new Moto();

        private void buttonSubmit_Click(object sender, EventArgs e) {



            
            int menor = int.Parse(menorMarchaDaMoto.Text);
            int maior = int.Parse(maiorMarchaDaMoto.Text);
            

            Moto Motoca = new Moto(marcaDaMoto.Text,modeloDaMoto.Text,corDaMoto.Text,menor,maior);

            //Informações da Moto

            nomeDaMotoca.Text = nomeDaMoto.Text;
            marcaDaMotoca.Text = Motoca.Marca;
            modeloDaMotoca.Text = Motoca.Modelo;
            corDaMotoca.Text = Motoca.Cor;        
            menorMarchaDaMotoca.Text = Convert.ToString(menor); 
            maiorMarchaDaMotoca.Text = Convert.ToString(maior);
            marchaDaMotoca.Text = Convert.ToString(Motoca.MarchaAtual);
            Ligado.Enabled = true;
            Desligado.Enabled = true;
            marchaMais.Enabled = true;
            marchaMenos.Enabled = true;

            MessageBox.Show("A " + nomeDaMoto.Text + " está pronta para RODAR!!");

            //Deixa os campos em Branco apos enviar

            nomeDaMoto.Text = "";
            marcaDaMoto.Text = "";
            modeloDaMoto.Text = "";
            corDaMoto.Text = "";
            menorMarchaDaMoto.Text = "";
            maiorMarchaDaMoto.Text = "";



            
        }

        private void Desligado_CheckedChanged(object sender, EventArgs e) {
            if (Desligado.Checked == true) {
                MessageBox.Show("A " + nomeDaMotoca.Text + " está desligada!");
                Motoca.MarchaAtual = 0;
                marchaDaMotoca.Text = "0";
            }
        }

        private void Ligado_CheckedChanged(object sender, EventArgs e) {
                if (Ligado.Checked == true) {
                    MessageBox.Show("A " + nomeDaMotoca.Text + " está ligada!");
                }                  
        }

        private void button1_Click(object sender, EventArgs e) {

            if (Ligado.Checked == true) {              
                if (marchaDaMotoca.Text == maiorMarchaDaMotoca.Text) {
                    MessageBox.Show("Está na marcha mais alta");

                }

                else {
                    Motoca.marchaAcima();
                    marchaDaMotoca.Text = Convert.ToString(Motoca.MarchaAtual);
                }
            }
            else {
                MessageBox.Show("Ligue a "+nomeDaMotoca.Text);
            }
           
        }

        private void button2_Click(object sender, EventArgs e) {
            if (Ligado.Checked == true) {
                if (marchaDaMotoca.Text == menorMarchaDaMotoca.Text) {
                    MessageBox.Show("Está na marcha mais baixa");

                }

                else {
                    Motoca.marchaAbaixo();
                    marchaDaMotoca.Text = Convert.ToString(Motoca.MarchaAtual);
                }
            }
            else {
                MessageBox.Show("Ligue a " + nomeDaMotoca.Text);
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void checkAsp_CheckedChanged(object sender, EventArgs e) {

        }

        private void checkC_CheckedChanged(object sender, EventArgs e) {
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void nomeDaMoto_TextChanged(object sender, EventArgs e) {

        }

        private void label10_Click(object sender, EventArgs e) {

        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void nomeDaMotoca_Click(object sender, EventArgs e) {

        }

        private void marcaDaMotoca_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void maiorMarchaDaMotoca_Click(object sender, EventArgs e) {

        }

        private void a_Click(object sender, EventArgs e) {

        }

        private void c_Click(object sender, EventArgs e) {

        }

        private void d_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click_1(object sender, EventArgs e) {

        }

        private void marcaDaMoto_TextChanged(object sender, EventArgs e) {
        }

        private void quadrado_TextChanged(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
 

        private void criarNovaMotoToolStripMenuItem_Click_1(object sender, EventArgs e) {
            nomeDaMotoca.Text = " ";
            marcaDaMotoca.Text = "";
            modeloDaMotoca.Text = "";
            corDaMotoca.Text = "";
            menorMarchaDaMotoca.Text = "";
            maiorMarchaDaMotoca.Text = "";
            marchaDaMotoca.Text = "";
            nomeDaMoto.Text = "";
            marcaDaMoto.Text = "";
            modeloDaMoto.Text = "";
            corDaMoto.Text = "";
            menorMarchaDaMoto.Text = "";
            maiorMarchaDaMoto.Text = "";
            Ligado.Enabled = false;
            Desligado.Enabled = false;
            marchaMais.Enabled = false;
            marchaMenos.Enabled = false;
        }
    }
}
