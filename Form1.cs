using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlPagos
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<PropiedadDueño> ListaPropiedadDueño = new List<PropiedadDueño>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDueños();
            cargarPropiedades();
            MostrarPropiedadDueño();

            comboBox_propiedad_dpi.DataSource = propietarios;
            comboBox_propiedad_dpi.DisplayMember = "dpi";
        }

        public void limpiarTextbox()
        {
            txt_dueño_dpi.Text = "";
            txt_dueño_nombre.Text = "";
            txt_dueño_apellido.Text = "";
            txt_propiedad_numCasa.Text = "";
            comboBox_propiedad_dpi.Text = "";
            txt_propiedad_cuota.Text = "";
        }

        public void actualizarComboBox()
        {
            comboBox_propiedad_dpi.DataSource = null;
            comboBox_propiedad_dpi.DataSource = propietarios;
            comboBox_propiedad_dpi.DisplayMember = "dpi";
            comboBox_propiedad_dpi.SelectedIndex = 0;
        }

        private void button_dueño_registrar_Click(object sender, EventArgs e)
        {
            string fileName = "Propietarios.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(txt_dueño_dpi.Text);
            writer.WriteLine(txt_dueño_nombre.Text);
            writer.WriteLine(txt_dueño_apellido.Text);

            limpiarTextbox();
            writer.Close();
            MessageBox.Show("Datos del propietario guardados");

            cargarDueños();
            actualizarComboBox();
            MostrarPropiedadDueño();
            txt_dueño_dpi.Select();
        }

        private void cargarDueños()
        {
            propietarios.Clear();
            string fileName = "Propietarios.txt";
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(stream))

                while (reader.Peek() > -1)
                {
                    Propietario propietario = new Propietario();
                    propietario.Dpi = Convert.ToInt32(reader.ReadLine());
                    propietario.Nombre = reader.ReadLine();
                    propietario.Apellido = reader.ReadLine();
                    propietarios.Add(propietario);
                }
        }

        private void MostrarPropiedadDueño()
        {
            dataGridViewPropiedadDueño.DataSource = null;
            dataGridViewPropiedadDueño.DataSource = ListaPropiedadDueño;
            dataGridViewPropiedadDueño.Refresh();
        }

        private void comboBox_propiedad_dpi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_propiedad_dpi.ValueMember = "dpi";
            int dpiPropietario = (Convert.ToInt32(comboBox_propiedad_dpi.SelectedValue));

            Propietario dpiEncontrado = propietarios.Find(c => c.Dpi == dpiPropietario);
            if (dpiEncontrado != null)
            {
                lbl_propiedad_nombre.Text = dpiEncontrado.Dpi + ", " + dpiEncontrado.Nombre + " " + dpiEncontrado.Apellido;
            }
        }

        private void button_registrar_propiedad_Click(object sender, EventArgs e)
        {
            string fileName = "Propiedades.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(txt_propiedad_numCasa.Text);
            writer.WriteLine(comboBox_propiedad_dpi.Text);
            writer.WriteLine(txt_propiedad_cuota.Text);

            limpiarTextbox();
            writer.Close();
            MessageBox.Show("Propiedad registrada");

            cargarPropiedades();
            MostrarPropiedadDueño();
            txt_propiedad_numCasa.Select();
        }

        private void cargarPropiedades()
        {
            propiedades.Clear();
            string fileName = "Propiedades.txt";
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(stream))

                while (reader.Peek() > -1)
                {
                    Propiedad propiedad = new Propiedad();
                    propiedad.NumeroCasa = reader.ReadLine();
                    propiedad.DpiPropietario = Convert.ToInt32(reader.ReadLine());
                    propiedad.CuotaMantenimiento = Convert.ToDecimal(reader.ReadLine());
                    propiedades.Add(propiedad);
                }
        }
    }
}
