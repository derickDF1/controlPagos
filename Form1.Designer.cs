
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.lbl_cuota_total_mayor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOrden = new System.Windows.Forms.ComboBox();
            this.dataGridViewAltasBajas = new System.Windows.Forms.DataGridView();
            this.buttonCuotasAltas = new System.Windows.Forms.Button();
            this.buttonCuotasBajas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedadDueño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAltasBajas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_dueño_dpi
            // 
            this.txt_dueño_dpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dueño_dpi.Location = new System.Drawing.Point(171, 40);
            this.txt_dueño_dpi.Name = "txt_dueño_dpi";
            this.txt_dueño_dpi.Size = new System.Drawing.Size(166, 22);
            this.txt_dueño_dpi.TabIndex = 0;
            // 
            // txt_dueño_nombre
            // 
            this.txt_dueño_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dueño_nombre.Location = new System.Drawing.Point(171, 66);
            this.txt_dueño_nombre.Name = "txt_dueño_nombre";
            this.txt_dueño_nombre.Size = new System.Drawing.Size(166, 22);
            this.txt_dueño_nombre.TabIndex = 1;
            // 
            // txt_dueño_apellido
            // 
            this.txt_dueño_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dueño_apellido.Location = new System.Drawing.Point(171, 92);
            this.txt_dueño_apellido.Name = "txt_dueño_apellido";
            this.txt_dueño_apellido.Size = new System.Drawing.Size(166, 22);
            this.txt_dueño_apellido.TabIndex = 2;
            // 
            // txt_propiedad_numCasa
            // 
            this.txt_propiedad_numCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_propiedad_numCasa.Location = new System.Drawing.Point(164, 40);
            this.txt_propiedad_numCasa.Name = "txt_propiedad_numCasa";
            this.txt_propiedad_numCasa.Size = new System.Drawing.Size(166, 22);
            this.txt_propiedad_numCasa.TabIndex = 5;
            // 
            // comboBox_propiedad_dpi
            // 
            this.comboBox_propiedad_dpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_propiedad_dpi.FormattingEnabled = true;
            this.comboBox_propiedad_dpi.Location = new System.Drawing.Point(164, 67);
            this.comboBox_propiedad_dpi.Name = "comboBox_propiedad_dpi";
            this.comboBox_propiedad_dpi.Size = new System.Drawing.Size(166, 24);
            this.comboBox_propiedad_dpi.TabIndex = 6;
            this.comboBox_propiedad_dpi.SelectedIndexChanged += new System.EventHandler(this.comboBox_propiedad_dpi_SelectedIndexChanged);
            // 
            // txt_propiedad_cuota
            // 
            this.txt_propiedad_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_propiedad_cuota.Location = new System.Drawing.Point(164, 118);
            this.txt_propiedad_cuota.Name = "txt_propiedad_cuota";
            this.txt_propiedad_cuota.Size = new System.Drawing.Size(166, 22);
            this.txt_propiedad_cuota.TabIndex = 7;
            // 
            // lbl_dueño_dpi
            // 
            this.lbl_dueño_dpi.AutoSize = true;
            this.lbl_dueño_dpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dueño_dpi.Location = new System.Drawing.Point(13, 46);
            this.lbl_dueño_dpi.Name = "lbl_dueño_dpi";
            this.lbl_dueño_dpi.Size = new System.Drawing.Size(30, 16);
            this.lbl_dueño_dpi.TabIndex = 6;
            this.lbl_dueño_dpi.Text = "DPI";
            // 
            // lbl_dueño_nombre
            // 
            this.lbl_dueño_nombre.AutoSize = true;
            this.lbl_dueño_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dueño_nombre.Location = new System.Drawing.Point(13, 73);
            this.lbl_dueño_nombre.Name = "lbl_dueño_nombre";
            this.lbl_dueño_nombre.Size = new System.Drawing.Size(57, 16);
            this.lbl_dueño_nombre.TabIndex = 7;
            this.lbl_dueño_nombre.Text = "Nombre";
            // 
            // lbl_dueño_apellido
            // 
            this.lbl_dueño_apellido.AutoSize = true;
            this.lbl_dueño_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dueño_apellido.Location = new System.Drawing.Point(13, 99);
            this.lbl_dueño_apellido.Name = "lbl_dueño_apellido";
            this.lbl_dueño_apellido.Size = new System.Drawing.Size(58, 16);
            this.lbl_dueño_apellido.TabIndex = 8;
            this.lbl_dueño_apellido.Text = "Apellido";
            // 
            // lbl_propiedad_cuota
            // 
            this.lbl_propiedad_cuota.AutoSize = true;
            this.lbl_propiedad_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propiedad_cuota.Location = new System.Drawing.Point(6, 124);
            this.lbl_propiedad_cuota.Name = "lbl_propiedad_cuota";
            this.lbl_propiedad_cuota.Size = new System.Drawing.Size(152, 16);
            this.lbl_propiedad_cuota.TabIndex = 11;
            this.lbl_propiedad_cuota.Text = "Cuota de mantenimiento";
            // 
            // lbl_propiedad_dpi
            // 
            this.lbl_propiedad_dpi.AutoSize = true;
            this.lbl_propiedad_dpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propiedad_dpi.Location = new System.Drawing.Point(6, 75);
            this.lbl_propiedad_dpi.Name = "lbl_propiedad_dpi";
            this.lbl_propiedad_dpi.Size = new System.Drawing.Size(98, 16);
            this.lbl_propiedad_dpi.TabIndex = 10;
            this.lbl_propiedad_dpi.Text = "DPI propietario";
            // 
            // lbl_propiedad_numCasa
            // 
            this.lbl_propiedad_numCasa.AutoSize = true;
            this.lbl_propiedad_numCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propiedad_numCasa.Location = new System.Drawing.Point(6, 48);
            this.lbl_propiedad_numCasa.Name = "lbl_propiedad_numCasa";
            this.lbl_propiedad_numCasa.Size = new System.Drawing.Size(108, 16);
            this.lbl_propiedad_numCasa.TabIndex = 9;
            this.lbl_propiedad_numCasa.Text = "Numero de casa";
            // 
            // button_registrar_propiedad
            // 
            this.button_registrar_propiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registrar_propiedad.Location = new System.Drawing.Point(173, 149);
            this.button_registrar_propiedad.Name = "button_registrar_propiedad";
            this.button_registrar_propiedad.Size = new System.Drawing.Size(142, 26);
            this.button_registrar_propiedad.TabIndex = 8;
            this.button_registrar_propiedad.Text = "Registrar propiedad";
            this.button_registrar_propiedad.UseVisualStyleBackColor = true;
            this.button_registrar_propiedad.Click += new System.EventHandler(this.button_registrar_propiedad_Click);
            // 
            // lbl_propiedad_nombre
            // 
            this.lbl_propiedad_nombre.AutoSize = true;
            this.lbl_propiedad_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propiedad_nombre.Location = new System.Drawing.Point(161, 94);
            this.lbl_propiedad_nombre.Name = "lbl_propiedad_nombre";
            this.lbl_propiedad_nombre.Size = new System.Drawing.Size(17, 16);
            this.lbl_propiedad_nombre.TabIndex = 14;
            this.lbl_propiedad_nombre.Text = "...";
            // 
            // button_dueño_registrar
            // 
            this.button_dueño_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dueño_registrar.Location = new System.Drawing.Point(195, 133);
            this.button_dueño_registrar.Name = "button_dueño_registrar";
            this.button_dueño_registrar.Size = new System.Drawing.Size(117, 26);
            this.button_dueño_registrar.TabIndex = 4;
            this.button_dueño_registrar.Text = "Registrar dueño";
            this.button_dueño_registrar.UseVisualStyleBackColor = true;
            this.button_dueño_registrar.Click += new System.EventHandler(this.button_dueño_registrar_Click);
            // 
            // dataGridViewPropiedadDueño
            // 
            this.dataGridViewPropiedadDueño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedadDueño.Location = new System.Drawing.Point(375, 54);
            this.dataGridViewPropiedadDueño.Name = "dataGridViewPropiedadDueño";
            this.dataGridViewPropiedadDueño.Size = new System.Drawing.Size(495, 269);
            this.dataGridViewPropiedadDueño.TabIndex = 9;
            // 
            // lbl_cuota_total_mayor
            // 
            this.lbl_cuota_total_mayor.AutoSize = true;
            this.lbl_cuota_total_mayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuota_total_mayor.Location = new System.Drawing.Point(372, 563);
            this.lbl_cuota_total_mayor.Name = "lbl_cuota_total_mayor";
            this.lbl_cuota_total_mayor.Size = new System.Drawing.Size(17, 16);
            this.lbl_cuota_total_mayor.TabIndex = 15;
            this.lbl_cuota_total_mayor.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Propietario con la cuota más alta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ordenar Por:";
            // 
            // comboBoxOrden
            // 
            this.comboBoxOrden.FormattingEnabled = true;
            this.comboBoxOrden.Items.AddRange(new object[] {
            "Por defecto",
            "Cuota de mantenimiento: Ascendente",
            "Cuota de mantenimiento: Descendente"});
            this.comboBoxOrden.Location = new System.Drawing.Point(693, 27);
            this.comboBoxOrden.Name = "comboBoxOrden";
            this.comboBoxOrden.Size = new System.Drawing.Size(177, 21);
            this.comboBoxOrden.TabIndex = 18;
            this.comboBoxOrden.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrden_SelectedIndexChanged);
            // 
            // dataGridViewAltasBajas
            // 
            this.dataGridViewAltasBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAltasBajas.Location = new System.Drawing.Point(375, 352);
            this.dataGridViewAltasBajas.Name = "dataGridViewAltasBajas";
            this.dataGridViewAltasBajas.Size = new System.Drawing.Size(495, 185);
            this.dataGridViewAltasBajas.TabIndex = 19;
            // 
            // buttonCuotasAltas
            // 
            this.buttonCuotasAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCuotasAltas.Location = new System.Drawing.Point(12, 511);
            this.buttonCuotasAltas.Name = "buttonCuotasAltas";
            this.buttonCuotasAltas.Size = new System.Drawing.Size(161, 26);
            this.buttonCuotasAltas.TabIndex = 21;
            this.buttonCuotasAltas.Text = "Ver 3 cuotas mas altas";
            this.buttonCuotasAltas.UseVisualStyleBackColor = true;
            this.buttonCuotasAltas.Click += new System.EventHandler(this.buttonCuotasAltas_Click);
            // 
            // buttonCuotasBajas
            // 
            this.buttonCuotasBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCuotasBajas.Location = new System.Drawing.Point(207, 511);
            this.buttonCuotasBajas.Name = "buttonCuotasBajas";
            this.buttonCuotasBajas.Size = new System.Drawing.Size(158, 26);
            this.buttonCuotasBajas.TabIndex = 22;
            this.buttonCuotasBajas.Text = "Ver 3 cuotas mas bajas";
            this.buttonCuotasBajas.UseVisualStyleBackColor = true;
            this.buttonCuotasBajas.Click += new System.EventHandler(this.buttonCuotasBajas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(372, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cuotas Totales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(372, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Historial de cuotas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_dueño_dpi);
            this.groupBox1.Controls.Add(this.txt_dueño_dpi);
            this.groupBox1.Controls.Add(this.txt_dueño_nombre);
            this.groupBox1.Controls.Add(this.txt_dueño_apellido);
            this.groupBox1.Controls.Add(this.lbl_dueño_nombre);
            this.groupBox1.Controls.Add(this.lbl_dueño_apellido);
            this.groupBox1.Controls.Add(this.button_dueño_registrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 181);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR CLIENTES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_propiedad_numCasa);
            this.groupBox2.Controls.Add(this.txt_propiedad_numCasa);
            this.groupBox2.Controls.Add(this.comboBox_propiedad_dpi);
            this.groupBox2.Controls.Add(this.txt_propiedad_cuota);
            this.groupBox2.Controls.Add(this.lbl_propiedad_dpi);
            this.groupBox2.Controls.Add(this.lbl_propiedad_cuota);
            this.groupBox2.Controls.Add(this.button_registrar_propiedad);
            this.groupBox2.Controls.Add(this.lbl_propiedad_nombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 214);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INGRESAR PROPIEDADES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCuotasBajas);
            this.Controls.Add(this.buttonCuotasAltas);
            this.Controls.Add(this.dataGridViewAltasBajas);
            this.Controls.Add(this.comboBoxOrden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cuota_total_mayor);
            this.Controls.Add(this.dataGridViewPropiedadDueño);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedadDueño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAltasBajas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lbl_cuota_total_mayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOrden;
        private System.Windows.Forms.DataGridView dataGridViewAltasBajas;
        private System.Windows.Forms.Button buttonCuotasAltas;
        private System.Windows.Forms.Button buttonCuotasBajas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

