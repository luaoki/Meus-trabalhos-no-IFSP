using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Imc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string resultados()
        {
            if (imc <= 18.5)
            {
                textBox3.Text = "BAIXO PESO! \n\n Nesse ponto, o corpo magro deixa de ser saudáveal e o organismo fica mais vulnerável" +
                    " a infeccções. Se o peso persistir, mesmo com a alimentação normal, procure ajuda médica; a dificuldade para engordar" +
                    " pode ser sintoma de alguma doença insidiosa, como o diabetes";
            }
            if (imc > 18.5 && imc <= 24.9)
            {
                
                textBox3.Text = "PESO IDEAL! \n\n Seu peso está adequado a sua altura. é importante manter a educação alimentar e a atividade" +
                    "e a atividade física. fique atento caso seu valor esteja perto de limites para os estágios dde Baixo Peso ou Sobrepeso.";
            }
            if (imc > 24.9 && imc <= 29.9)
            {
                textBox3.Text = "SOBREPESO! \n\n Esta faixa indica que você está com predisposição à obesidade;" +
                    "dependendo do seu histórico familiar e pessoal, pode haver um quadro de pré-diabetes e hipertensão" +
                    "Procure orientação médica para evitar o próximo estágio, Obesidade 1. Quanto mais quilos extras, maior a dificuldade para emagrecer.";
            }
            if (imc > 29.9 && imc <= 34.9)
            {
                textBox3.Text = "OBESIDADE DE GRAU 1! \n\n O risco de desenvolver diabetes, para quem está nesta faixa de peso é de 20%," +
                    "e o de hipertensão ultrapassa 25%. Há risco maior de outras doenças cardiovasculares, articulares, distúrbios psiquiátricos, apnéia do sono e até certos tipos de câncer.";
            }
            if (imc > 34.9 && imc <= 39.9)
            {
                textBox3.Text = "OBESIDADE DE SEGUNDO GRAU!! \n\n O risco de desenvolver diabetes chega a 40%, e a chance de surgirem doenças associadas a obesidade" +
                    "com reumatismos, câncer, apneia do sono, hipertensão e outros problemas cardiovasculares pode chegar a 50%. PROCURE ORIENTAÇÃO MÉDICA!!!";

            }
            if (imc > 39.9 && imc <= 40)
            {
                textBox3.Text = "OBESIDADE GRAU 3\n\n O risco de desenvolver doenças associadas ao excesso de peso, como diabete, reumatismos, câncer," +
                    "apneia do sono, hipertensão e outros problemas cardiovasculares chega a 90%. Nesse estágio, a cirurgia de redução de estômago pode ser indicada.\n\nPROCURE ORIENTAÇÃO MÉDICA IMEDIATAMENTE!!!";
            }
            return textBox3.Text;
        }


        double imc;
        private void button1_Click_1(object sender, EventArgs e)
        {
            //verifica valores e interage com o usuário
            if (txtpeso.Text == "" || txtaltura.Text == "")
            {
                MessageBox.Show("Insira os valores para calcular!");
            }
            else
            {
                try
                {
                    //calculo
                    double peso = double.Parse(txtpeso.Text), altura = double.Parse(txtaltura.Text);
                    imc = peso / (altura * altura);
                    lblresultado.Text = Convert.ToString(imc);
                    resultados();
                }
                catch(Exception)
                {
                    MessageBox.Show("Digite somente números e utilize apenas vírgulas!");
                }
            }
        }

       
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sim ou Não", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)

                Close();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtaltura.Clear();
            lblresultado.Text = null;
            txtpeso.Clear();
            textBox3.Clear();
        }

        

        
    }
}
