
namespace controlPagos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_dueño_dpi = new System.Windows.Forms.TextBox();
            this.txt_dueño_nombre = new System.Windows.Forms.TextBox();
            this.txt_dueño_apellido = new System.Windows.Forms.TextBox();
            this.txt_propiedad_numCasa = new System.Windows.Forms.TextBox();
            this.comboBox_propiedad_dpi = new System.Windows.Forms.ComboBox();
            this.txt_propiedad_cuota = new System.Windows.Forms.TextBox();
            this.lbl_dueño_dpi = new System.Windows.Forms.Label();
            this.lbl_dueño_nombre = new System.Windows.Forms.Label();
            this.lbl_dueño_apellido = new System.Windows.Forms.Label();
            this.lbl_propiedad_cuota = new System.Windows.Forms.Label();
            this.lbl_propiedad_dpi = new System.Windows.Forms.Label();
            this.lbl_propiedad_numCasa = new System.Windows.Forms.Label();
            this.button_registrar_propiedad = new System.Windows.Forms.Button();
            this.lbl_propiedad_nombre = new System.Windows.Forms.Label();
            this.button_dueño_registrar = new System.Windows.Forms.Button();
            this.dataGridViewPropiedadDueño = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedadDueño)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dueño_dpi
            // 
            this.txt_dueño_dpi.Location = new System.Drawing.Point(218, 54);
            this.txt_dueño_dpi.Name = "txt_dueño_dpi";
            this.txt_dueño_dpi.Size = new System.Drawing.Size(166, 20);
            this.txt_dueño_dpi.TabIndex = 0;
            // 
            // txt_dueño_nombre
            // 
            this.txt_dueño_nombre.Location = new System.Drawing.Point(218, 80);
            this.txt_dueño_nombre.Name = "txt_dueño_nombre";
            this.txt_dueño_nombre.Size = new System.Drawing.Size(166, 20);
            this.txt_dueño_nombre.TabIndex = 1;
            // 
            // txt_dueño_apellido
            // 
            this.txt_dueño_apellido.Location = new System.Drawing.Point(218, 106);
            this.txt_dueño_apellido.Name = "txt_dueño_apellido";
            this.txt_dueño_apellido.Size = new System.Drawing.Size(166, 20);
            this.txt_dueño_apellido.TabIndex = 2;
            // 
            // txt_propiedad_numCasa
            // 
            this.txt_propiedad_numCasa.Location = new System.Drawing.Point(218, 226);
            this.txt_propiedad_numCasa.Name = "txt_propiedad_numCasa";
            this.txt_propiedad_numCasa.Size = new System.Drawing.Size(166, 20);
            this.txt_propiedad_numCasa.TabIndex = 3;
            // 
            // comboBox_propiedad_dpi
            // 
            this.comboBox_propiedad_dpi.FormattingEnabled = true;
            this.comboBox_propiedad_dpi.Location = new System.Drawing.Point(218, 253);
            this.comboBox_propiedad_dpi.Name = "comboBox_propiedad_dpi";
            this.comboBox_propiedad_dpi.Size = new System.Drawing.Size(166, 21);
            this.comboBox_propiedad_dpi.TabIndex = 4;
            this.comboBox_propiedad_dpi.SelectedIndexChanged += new System.EventHandler(this.comboBox_propiedad_dpi_SelectedIndexChanged);
            // 
            // txt_propiedad_cuota
            // 
            this.txt_propiedad_cuota.Location = new System.Drawing.Point(218, 304);
            this.txt_propiedad_cuota.Name = "txt_propiedad_cuota";
            this.txt_propiedad_cuota.Size = new System.Drawing.Size(166, 20);
            this.txt_propiedad_cuota.TabIndex = 5;
            // 
            // lbl_dueño_dpi
            // 
            this.lbl_dueño_dpi.AutoSize = true;
            this.lbl_dueño_dpi.Location = new System.Drawing.Point(93, 60);
            this.lbl_dueño_dpi.Name = "lbl_dueño_dpi";
            this.lbl_dueño_dpi.Size = new System.Drawing.Size(25, 13);
            this.lbl_dueño_dpi.TabIndex = 6;
            this.lbl_dueño_dpi.Text = "DPI";
            // 
            // lbl_dueño_nombre
            // 
            this.lbl_dueño_nombre.AutoSize = true;
            this.lbl_dueño_nombre.Location = new System.Drawing.Point(93, 87);
            this.lbl_dueño_nombre.Name = "lbl_dueño_nombre";
            this.lbl_dueño_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_dueño_nombre.TabIndex = 7;
            this.lbl_dueño_nombre.Text = "Nombre";
            // 
            // lbl_dueño_apellido
            // 
            this.lbl_dueño_apellido.AutoSize = true;
            this.lbl_dueño_apellido.Location = new System.Drawing.Point(93, 113);
            this.lbl_dueño_apellido.Name = "lbl_dueño_apellido";
            this.lbl_dueño_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_dueño_apellido.TabIndex = 8;
            this.lbl_dueño_apellido.Text = "Apellido";
            // 
            // lbl_propiedad_cuota
            // 
            this.lbl_propiedad_cuota.AutoSize = true;
            this.lbl_propiedad_cuota.Location = new System.Drawing.Point(93, 310);
            this.lbl_propiedad_cuota.Name = "lbl_propiedad_cuota";
            this.lbl_propiedad_cuota.Size = new System.Drawing.Size(121, 13);
            this.lbl_propiedad_cuota.TabIndex = 11;
            this.lbl_propiedad_cuota.Text = "Cuota de mantenimiento";
            // 
            // lbl_propiedad_dpi
            // 
            this.lbl_propiedad_dpi.AutoSize = true;
            this.lbl_propiedad_dpi.Location = new System.Drawing.Point(93, 261);
            this.lbl_propiedad_dpi.Name = "lbl_propiedad_dpi";
            this.lbl_propiedad_dpi.Size = new System.Drawing.Size(77, 13);
            this.lbl_propiedad_dpi.TabIndex = 10;
            this.lbl_propiedad_dpi.Text = "DPI propietario";
            // 
            // lbl_propiedad_numCasa
            // 
            this.lbl_propiedad_numCasa.AutoSize = true;
            this.lbl_propiedad_numCasa.Location = new System.Drawing.Point(93, 234);
            this.lbl_propiedad_numCasa.Name = "lbl_propiedad_numCasa";
            this.lbl_propiedad_numCasa.Size = new System.Drawing.Size(85, 13);
            this.lbl_propiedad_numCasa.TabIndex = 9;
            this.lbl_propiedad_numCasa.Text = "Numero de casa";
            // 
            // button_registrar_propiedad
            // 
            this.button_registrar_propiedad.Location = new System.Drawing.Point(242, 336);
            this.button_registrar_propiedad.Name = "button_registrar_propiedad";
            this.button_registrar_propiedad.Size = new System.Drawing.Size(117, 23);
            this.button_registrar_propiedad.TabIndex = 13;
            this.button_registrar_propiedad.Text = "Registrar propiedad";
            this.button_registrar_propiedad.UseVisualStyleBackColor = true;
            this.button_registrar_propiedad.Click += new System.EventHandler(this.button_registrar_propiedad_Click);
            // 
            // lbl_propiedad_nombre
            // 
            this.lbl_propiedad_nombre.AutoSize = true;
            this.lbl_propiedad_nombre.Location = new System.Drawing.Point(218, 279);
            this.lbl_propiedad_nombre.Name = "lbl_propiedad_nombre";
            this.lbl_propiedad_nombre.Size = new System.Drawing.Size(16, 13);
            this.lbl_propiedad_nombre.TabIndex = 14;
            this.lbl_propiedad_nombre.Text = "...";
            // 
            // button_dueño_registrar
            // 
            this.button_dueño_registrar.Location = new System.Drawing.Point(242, 147);
            this.button_dueño_registrar.Name = "button_dueño_registrar";
            this.button_dueño_registrar.Size = new System.Drawing.Size(117, 23);
            this.button_dueño_registrar.TabIndex = 15;
            this.button_dueño_registrar.Text = "Registrar dueño";
            this.button_dueño_registrar.UseVisualStyleBackColor = true;
            this.button_dueño_registrar.Click += new System.EventHandler(this.button_dueño_registrar_Click);
            // 
            // dataGridViewPropiedadDueño
            // 
            this.dataGridViewPropiedadDueño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedadDueño.Location = new System.Drawing.Point(444, 54);
            this.dataGridViewPropiedadDueño.Name = "dataGridViewPropiedadDueño";
            this.dataGridViewPropiedadDueño.Size = new System.Drawing.Size(406, 269);
            this.dataGridViewPropiedadDueño.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.dataGridViewPropiedadDueño);
            this.Controls.Add(this.button_dueño_registrar);
            this.Controls.Add(this.lbl_propiedad_nombre);
            this.Controls.Add(this.button_registrar_propiedad);
            this.Controls.Add(this.lbl_propiedad_cuota);
            this.Controls.Add(this.lbl_propiedad_dpi);
            this.Controls.Add(this.lbl_propiedad_numCasa);
            this.Controls.Add(this.lbl_dueño_apellido);
            this.Controls.Add(this.lbl_dueño_nombre);
            this.Controls.Add(this.lbl_dueño_dpi);
            this.Controls.Add(this.txt_propiedad_cuota);
            this.Controls.Add(this.comboBox_propiedad_dpi);
            this.Controls.Add(this.txt_propiedad_numCasa);
            this.Controls.Add(this.txt_dueño_apellido);
            this.Controls.Add(this.txt_dueño_nombre);
            this.Controls.Add(this.txt_dueño_dpi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedadDueño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dueño_dpi;
        private System.Windows.Forms.TextBox txt_dueño_nombre;
        private System.Windows.Forms.TextBox txt_dueño_apellido;
        private System.Windows.Forms.TextBox txt_propiedad_numCasa;
        private System.Windows.Forms.ComboBox comboBox_propiedad_dpi;
        private System.Windows.Forms.TextBox txt_propiedad_cuota;
        private System.Windows.Forms.Label lbl_dueño_dpi;
        private System.Windows.Forms.Label lbl_dueño_nombre;
        private System.Windows.Forms.Label lbl_dueño_apellido;
        private System.Windows.Forms.Label lbl_propiedad_cuota;
        private System.Windows.Forms.Label lbl_propiedad_dpi;
        private System.Windows.Forms.Label lbl_propiedad_numCasa;
        private System.Windows.Forms.Button button_registrar_propiedad;
        private System.Windows.Forms.Label lbl_propiedad_nombre;
        private System.Windows.Forms.Button button_dueño_registrar;
        private System.Windows.Forms.DataGridView dataGridViewPropiedadDueño;
    }
}

