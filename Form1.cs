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
        List<PropiedadDueño> totales = new List<PropiedadDueño>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDueños();
            cargarPropiedades();
            cargarPropiedadDueño();
            MostrarPropiedadDueño();
            cuotasTotales();
            cuotaTotalMayor();
            comboBox_propiedad_dpi.DataSource = propietarios;
            comboBox_propiedad_dpi.DisplayMember = "dpi";
            comboBoxOrden.SelectedIndex = 0;
        }

        public void limpiarTextbox()
        {
            txt_dueño_dpi.Text = "";
            txt_dueño_nombre.Text = "";
            txt_dueño_apellido.Text = "";
            txt_propiedad_numCasa.Text = "";
            actualizarComboBox();
            txt_propiedad_cuota.Text = "";
            cuotasTotales();
            cuotaTotalMayor();
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
                lbl_propiedad_nombre.Text = dpiEncontrado.Nombre + " " + dpiEncontrado.Apellido;
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
            guardarPropiedadDueño();
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

        private void guardarPropiedadDueño ()
        {
            string fileName = "ListaPropiedadDueño.txt";
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Propiedad propiedad in propiedades)
            {
                Propietario propietario = propietarios.Find(c => c.Dpi == propiedad.DpiPropietario);

                // Guardar el reporte en el archivo
                writer.WriteLine(propietario.Dpi);
                writer.WriteLine(propietario.Nombre);
                writer.WriteLine(propietario.Apellido);
                writer.WriteLine(propiedad.NumeroCasa);
                writer.WriteLine(propiedad.CuotaMantenimiento);
            }
            writer.Close();
            cargarPropiedadDueño();
        }

        private void cargarPropiedadDueño()
        {
            ListaPropiedadDueño.Clear();
            string fileName = "ListaPropiedadDueño.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
                {
                PropiedadDueño propiedadDueño = new PropiedadDueño();
                propiedadDueño.Dpi = Convert.ToInt32(reader.ReadLine());
                propiedadDueño.Nombre = reader.ReadLine();
                propiedadDueño.Apellido = reader.ReadLine();
                propiedadDueño.NumCasa = reader.ReadLine();
                propiedadDueño.CuotaMantenimiento = Convert.ToDecimal(reader.ReadLine());
                ListaPropiedadDueño.Add(propiedadDueño);
                }
            reader.Close();
            MostrarPropiedadDueño();
        }

        private void cuotaTotalMayor()
        {
            decimal cuotaMayor = 0;
            int DpiPropietario = 0;
            string nombrePropietario = "";

            foreach (PropiedadDueño propiedadDueño in totales)
            {
                if (propiedadDueño.CuotaMantenimiento > cuotaMayor)
                {
                    cuotaMayor = propiedadDueño.CuotaMantenimiento;
                    nombrePropietario = propiedadDueño.Nombre + " " + propiedadDueño.Apellido;
                    DpiPropietario = propiedadDueño.Dpi;
                }
            }

            // Mostrar el máximo kilometraje en la etiqueta
            lbl_cuota_total_mayor.Text = "Dpi: " + DpiPropietario + ", " + nombrePropietario + ", con cuota total de : Q" + cuotaMayor;
        }

        private void comboBoxOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrden.SelectedIndex == 0)
            {
                dataGridViewPropiedadDueño.DataSource = null;
                dataGridViewPropiedadDueño.DataSource = ListaPropiedadDueño;
            }
            else if (comboBoxOrden.SelectedIndex == 1)
            {
                List<PropiedadDueño> listaAscendente = ListaPropiedadDueño.OrderBy(c => c.CuotaMantenimiento).ToList();

                dataGridViewPropiedadDueño.DataSource = null;
                dataGridViewPropiedadDueño.DataSource = listaAscendente;
            }

            else if (comboBoxOrden.SelectedIndex == 2)
            {
                List<PropiedadDueño> listaDescendente = ListaPropiedadDueño.OrderByDescending(c => c.CuotaMantenimiento).ToList();
                dataGridViewPropiedadDueño.DataSource = null;
                dataGridViewPropiedadDueño.DataSource = listaDescendente;
            }
        }

        private void cuotasTotales()
        {
            totales.Clear();
            foreach (Propietario propietario in propietarios)
            {
                decimal sueldoAcumulado = 0;

                foreach (Propiedad propiedad in propiedades)
                {
                    if (propietario.Dpi == propiedad.DpiPropietario)
                    {
                        sueldoAcumulado += propiedad.CuotaMantenimiento;
                    }
                }

                PropiedadDueño total = new PropiedadDueño();
                total.Dpi = propietario.Dpi;
                total.Nombre = propietario.Nombre;
                total.Apellido = propietario.Apellido;
                total.CuotaMantenimiento = sueldoAcumulado;

                foreach (Propiedad propiedad in propiedades)
                {
                    if (propiedad.DpiPropietario == propietario.Dpi)
                    {
                        total.NumCasa = propiedad.NumeroCasa;
                        break;
                    }
                }

                totales.Add(total);
            }

            dataGridViewAltasBajas.DataSource = null;
            dataGridViewAltasBajas.DataSource = totales;
            dataGridViewAltasBajas.Refresh();

        }

        private void buttonCuotasAltas_Click(object sender, EventArgs e)
        {
            List<Propiedad> tresCuotasMasAltas = propiedades.OrderByDescending(c => c.CuotaMantenimiento).Take(3).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (Propiedad propiedad in tresCuotasMasAltas)
            {
                sb.AppendLine("Casa No.: " + propiedad.NumeroCasa + ", Cuota: " + propiedad.CuotaMantenimiento);
            }

            MessageBox.Show(sb.ToString(), "Cuotas más altas de mantenimiento");
        }

        private void buttonCuotasBajas_Click(object sender, EventArgs e)
        {
            List<Propiedad> tresCuotasMasAltas = propiedades.OrderBy(c => c.CuotaMantenimiento).Take(3).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (Propiedad propiedad in tresCuotasMasAltas)
            {
                sb.AppendLine("Casa No.: " + propiedad.NumeroCasa + ", Cuota: " + propiedad.CuotaMantenimiento);
            }

            MessageBox.Show(sb.ToString(), "Cuotas más bajas de mantenimiento");
        }
    }
}