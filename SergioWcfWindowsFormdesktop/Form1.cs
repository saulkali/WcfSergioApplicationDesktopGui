using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SergioWcfWindowsFormdesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceCalculadora.Service1Client operacion = new ServiceCalculadora.Service1Client();
            float resultado = 0;
            if (radioButton1.Checked) {
                resultado = operacion.operacion(1,float.Parse (textBox2.Text), float.Parse(textBox3.Text));
            }
            else
            {
                if (radioButton2.Checked)
                {
                    resultado = operacion.operacion(2, float.Parse(textBox2.Text), float.Parse(textBox3.Text));
                }
                else {
                    
                     if (radioButton3.Checked)
                        {
                            resultado = operacion.operacion(3, float.Parse(textBox2.Text), float.Parse(textBox3.Text));
                        }
                        else {
                            if (radioButton4.Checked)
                            {
                                resultado = operacion.operacion(4, float.Parse(textBox2.Text), float.Parse(textBox3.Text));
                            }
                            else {
                                MessageBox.Show("Seleccione una operacion");
                            }
                        

                    }
                }
            }
            textBox1.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceCalculadora.Service1Client operacion = new ServiceCalculadora.Service1Client();
            float resultado = 0;
            resultado= operacion.suma(float.Parse(textBox4.Text),float.Parse(textBox5.Text));
            textBox6.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceCalculadora.Service1Client operacion = new ServiceCalculadora.Service1Client();
            float resultado = 0;
            resultado =  operacion.multiplicacion(float.Parse(textBox4.Text), float.Parse(textBox5.Text));
            textBox6.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceCalculadora.Service1Client operacion = new ServiceCalculadora.Service1Client();
            float resultado = 0;
            resultado =  operacion.resta(float.Parse(textBox4.Text), float.Parse(textBox5.Text));
            textBox6.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ServiceCalculadora.Service1Client operacion = new ServiceCalculadora.Service1Client();
            float resultado = 0;
            resultado =  operacion.divicion(float.Parse(textBox4.Text), float.Parse(textBox5.Text));
            textBox6.Text = resultado.ToString();
        }
    }
}
