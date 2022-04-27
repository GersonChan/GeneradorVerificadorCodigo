using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorVerificadorCodigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        List<int> vectorControl = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        List<int> vectordatos = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            string datos = txtGenerador.Text;
            string generarTemp = generador(datos);
            MessageBox.Show("codigo \n" + generarTemp);
            vectordatos.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string datos = txtVerificador.Text;
            string veriTemp = verificador(datos);
            MessageBox.Show(veriTemp);
            vectordatos.Clear();
        }

        private string verificador(string datos)
        {
            int digitoVerificador = 0;
            double temp = 0;
            double multiplo = 0;
            double aux = 0;
            double aux2 = 0;
            for (int i = 0; i < 10; i++)
            {
                char num = datos[i];
                int num1 = (int)Char.GetNumericValue(num);
                vectordatos.Add(num1);
            }
            temp = (vectordatos[0] * vectorControl[0] + vectordatos[1] * vectorControl[1] + vectordatos[2] * vectorControl[2] + vectordatos[3] * vectorControl[3] + vectordatos[4]
                * vectorControl[4] + vectordatos[5] * vectorControl[5] + vectordatos[6] * vectorControl[6] + vectordatos[7] * vectorControl[7] + vectordatos[8] * vectorControl[8]);
            aux = temp / 10;
            multiplo = (double)Math.Ceiling(aux);
            aux2 = multiplo - aux;
            digitoVerificador = (int)(aux2 * 10);
            char verificar = datos[9];
            string vertemp = Convert.ToString(digitoVerificador);
            char verdig = vertemp[0];
            if (verificar == verdig)
            {
                string msj = "codigo correcto ";
                this.BackColor = Color.Green;
                lbControl.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                return msj;
            }
            else
            {
                string msj = "codigo incorrecto ";
                this.BackColor = Color.Red;
                lbControl.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                return msj;
            }
        }

        private string generador(string datos)
        {
            int digitoVerificador = 0;
            double temp = 0;
            double multiplo = 0;
            double aux = 0;
            double aux2 = 0;
            for (int i = 0; i < datos.Length; i++)
            {
                char num = datos[i];
                int num1 = (int)Char.GetNumericValue(num);
                vectordatos.Add(num1);
            }
            temp = (vectordatos[0] * vectorControl[0] + vectordatos[1] * vectorControl[1] + vectordatos[2] * vectorControl[2] + vectordatos[3] * vectorControl[3] + vectordatos[4]
                * vectorControl[4] + vectordatos[5] * vectorControl[5] + vectordatos[6] * vectorControl[6] + vectordatos[7] * vectorControl[7] + vectordatos[8] * vectorControl[8]);
            aux = temp / 10;
            multiplo = (double)Math.Ceiling(aux);
            aux2 = multiplo - aux;
            digitoVerificador = (int)(aux2 * 10);
            string retornar = datos + digitoVerificador;
            return retornar;
        }
    }
}
