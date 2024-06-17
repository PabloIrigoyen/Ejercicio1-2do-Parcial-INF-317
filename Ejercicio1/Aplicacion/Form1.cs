using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;


namespace Aplicacion
{
    public partial class Form1 : Form
    {
        private Logica.Logica estudianteService;
        public Form1()
        {
            InitializeComponent();
            estudianteService = new Logica.Logica();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id=int.Parse(textBox1.Text);
            try
            {
                Conexion.Conexion student = estudianteService.GetStudentById(Id);

                if (student != null)
                {
                    textBox2.Text = $"{student.Id}";
                    textBox3.Text = $"{student.Nombre}";
                    textBox4.Text = $"{student.Apellido}";
                    textBox5.Text = $"{student.Edad}";

                }
                else
                {
                    MessageBox.Show("No se encontro estudiante con ese id vuelva a intentarlo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar el estudiante: " + ex.Message);
            }
        }
    }
}
