using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DetallesTxb();
            DetallesLbl();
            DetallesGbx();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }











        //En estos metodos se parametrizan los elementos como los Textbox,Label,Groupbox y los demas elementos
        private void DetallesTxb()
        {
            textBox1.Enabled = false;
        }
        private void DetallesLbl()
        {
            label1.Text = "SOLICITUD N°";
            label2.Text = "Unidad de Atencion al Estudiante";
            label3.Text = "Aprueba";
            label4.Text = "Deniega";
            label5.Text = "Fecha";
            label6.Text = "Fecha de Solicitud     :";
            //label7,label13,label14,label15,label16,label17.label22,label23,label24-->no se parametriza ya que recibe un valor de la BD
            label8.Text = "C.I.                    :";
            label9.Text = "MATRICULA     :";
            label10.Text = "PROGRAMA      :";
            label11.Text = "JORNADA          :";
            label12.Text = "TELEFONO        :";
            label18.Text = "Apellido Paterno";
            label19.Text = "Apellido Materno";
            label20.Text = "Nombres";
            label21.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            label25.Text = "01";
            label26.Text = "02";
            label27.Text = "03";
            label28.Text = "04";
            label29.Text = "05";
            label30.Text = "06";
            label31.Text = "07";
            label32.Text = "08";
        }
        private void DetallesGbx()
        {
            groupBox1.Text = "";
            groupBox2.Text = "SITUACION FINANCIERA DEL ESTUDIANTE";
        }
    }
}
