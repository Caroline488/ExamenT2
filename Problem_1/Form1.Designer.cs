namespace Problem_1
{
    partial class Enunciado1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            dgvMascota = new DataGridView();
            btn_registroMascota = new Button();
            cbo_Mdueño = new ComboBox();
            txt_Mraza = new TextBox();
            txt_Medad = new TextBox();
            txt_Mnombre = new TextBox();
            lbl_Mdueño = new Label();
            lbl_Mraza = new Label();
            lbl_Medad = new Label();
            lbl_Mnombre = new Label();
            groupBox1 = new GroupBox();
            btn_registroDueño = new Button();
            txt_Dtelefono = new TextBox();
            txt_Ddireccion = new TextBox();
            txt_Dnombre = new TextBox();
            lbl_telefono = new Label();
            lbl_direccion = new Label();
            lbl_nombre = new Label();
            groupBox3 = new GroupBox();
            btn_BMbuscar = new Button();
            txt_BMnombre = new TextBox();
            lbl_BMnombre = new Label();
            lbl_resbusquedaMascota = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascota).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMascota);
            groupBox2.Controls.Add(btn_registroMascota);
            groupBox2.Controls.Add(cbo_Mdueño);
            groupBox2.Controls.Add(txt_Mraza);
            groupBox2.Controls.Add(txt_Medad);
            groupBox2.Controls.Add(txt_Mnombre);
            groupBox2.Controls.Add(lbl_Mdueño);
            groupBox2.Controls.Add(lbl_Mraza);
            groupBox2.Controls.Add(lbl_Medad);
            groupBox2.Controls.Add(lbl_Mnombre);
            groupBox2.Location = new Point(12, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(917, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de mascota";
            // 
            // dgvMascota
            // 
            dgvMascota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascota.Location = new Point(392, 32);
            dgvMascota.Name = "dgvMascota";
            dgvMascota.RowHeadersWidth = 51;
            dgvMascota.Size = new Size(461, 175);
            dgvMascota.TabIndex = 9;
            // 
            // btn_registroMascota
            // 
            btn_registroMascota.Location = new Point(76, 186);
            btn_registroMascota.Name = "btn_registroMascota";
            btn_registroMascota.Size = new Size(160, 29);
            btn_registroMascota.TabIndex = 8;
            btn_registroMascota.Text = "Registrar";
            btn_registroMascota.UseVisualStyleBackColor = true;
            btn_registroMascota.Click += btn_registroMascota_Click;
            // 
            // cbo_Mdueño
            // 
            cbo_Mdueño.FormattingEnabled = true;
            cbo_Mdueño.Location = new Point(108, 131);
            cbo_Mdueño.Name = "cbo_Mdueño";
            cbo_Mdueño.Size = new Size(198, 28);
            cbo_Mdueño.TabIndex = 7;
            cbo_Mdueño.KeyPress += cbo_Mdueño_KeyPress;
            // 
            // txt_Mraza
            // 
            txt_Mraza.Location = new Point(108, 98);
            txt_Mraza.Name = "txt_Mraza";
            txt_Mraza.Size = new Size(198, 27);
            txt_Mraza.TabIndex = 6;
            // 
            // txt_Medad
            // 
            txt_Medad.Location = new Point(108, 65);
            txt_Medad.MaxLength = 2;
            txt_Medad.Name = "txt_Medad";
            txt_Medad.Size = new Size(198, 27);
            txt_Medad.TabIndex = 5;
            txt_Medad.KeyPress += txt_Dtelefono_KeyPress;
            // 
            // txt_Mnombre
            // 
            txt_Mnombre.Location = new Point(108, 32);
            txt_Mnombre.Name = "txt_Mnombre";
            txt_Mnombre.Size = new Size(198, 27);
            txt_Mnombre.TabIndex = 4;
            // 
            // lbl_Mdueño
            // 
            lbl_Mdueño.AutoSize = true;
            lbl_Mdueño.Location = new Point(20, 134);
            lbl_Mdueño.Name = "lbl_Mdueño";
            lbl_Mdueño.Size = new Size(53, 20);
            lbl_Mdueño.TabIndex = 3;
            lbl_Mdueño.Text = "Dueño";
            // 
            // lbl_Mraza
            // 
            lbl_Mraza.AutoSize = true;
            lbl_Mraza.Location = new Point(20, 101);
            lbl_Mraza.Name = "lbl_Mraza";
            lbl_Mraza.Size = new Size(41, 20);
            lbl_Mraza.TabIndex = 2;
            lbl_Mraza.Text = "Raza";
            // 
            // lbl_Medad
            // 
            lbl_Medad.AutoSize = true;
            lbl_Medad.Location = new Point(20, 68);
            lbl_Medad.Name = "lbl_Medad";
            lbl_Medad.Size = new Size(43, 20);
            lbl_Medad.TabIndex = 1;
            lbl_Medad.Text = "Edad";
            // 
            // lbl_Mnombre
            // 
            lbl_Mnombre.AutoSize = true;
            lbl_Mnombre.Location = new Point(20, 35);
            lbl_Mnombre.Name = "lbl_Mnombre";
            lbl_Mnombre.Size = new Size(64, 20);
            lbl_Mnombre.TabIndex = 0;
            lbl_Mnombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_registroDueño);
            groupBox1.Controls.Add(txt_Dtelefono);
            groupBox1.Controls.Add(txt_Ddireccion);
            groupBox1.Controls.Add(txt_Dnombre);
            groupBox1.Controls.Add(lbl_telefono);
            groupBox1.Controls.Add(lbl_direccion);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de dueños";
            // 
            // btn_registroDueño
            // 
            btn_registroDueño.Location = new Point(76, 161);
            btn_registroDueño.Name = "btn_registroDueño";
            btn_registroDueño.Size = new Size(160, 29);
            btn_registroDueño.TabIndex = 6;
            btn_registroDueño.Text = "Registrar";
            btn_registroDueño.UseVisualStyleBackColor = true;
            btn_registroDueño.Click += btn_registroDueño_Click;
            // 
            // txt_Dtelefono
            // 
            txt_Dtelefono.Location = new Point(108, 101);
            txt_Dtelefono.MaxLength = 9;
            txt_Dtelefono.Name = "txt_Dtelefono";
            txt_Dtelefono.Size = new Size(198, 27);
            txt_Dtelefono.TabIndex = 5;
            txt_Dtelefono.KeyPress += txt_Dtelefono_KeyPress;
            // 
            // txt_Ddireccion
            // 
            txt_Ddireccion.Location = new Point(108, 68);
            txt_Ddireccion.Name = "txt_Ddireccion";
            txt_Ddireccion.Size = new Size(198, 27);
            txt_Ddireccion.TabIndex = 4;
            // 
            // txt_Dnombre
            // 
            txt_Dnombre.Location = new Point(108, 35);
            txt_Dnombre.Name = "txt_Dnombre";
            txt_Dnombre.Size = new Size(198, 27);
            txt_Dnombre.TabIndex = 3;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(20, 104);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(67, 20);
            lbl_telefono.TabIndex = 2;
            lbl_telefono.Text = "Telefono";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(20, 71);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(72, 20);
            lbl_direccion.TabIndex = 1;
            lbl_direccion.Text = "Direccion";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(20, 38);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(64, 20);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_resbusquedaMascota);
            groupBox3.Controls.Add(btn_BMbuscar);
            groupBox3.Controls.Add(txt_BMnombre);
            groupBox3.Controls.Add(lbl_BMnombre);
            groupBox3.Location = new Point(12, 467);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(917, 97);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Busqueda de Mascota";
            // 
            // btn_BMbuscar
            // 
            btn_BMbuscar.Location = new Point(360, 48);
            btn_BMbuscar.Name = "btn_BMbuscar";
            btn_BMbuscar.Size = new Size(122, 29);
            btn_BMbuscar.TabIndex = 2;
            btn_BMbuscar.Text = "Buscar";
            btn_BMbuscar.UseVisualStyleBackColor = true;
            btn_BMbuscar.Click += btn_BMbuscar_Click;
            // 
            // txt_BMnombre
            // 
            txt_BMnombre.Location = new Point(108, 50);
            txt_BMnombre.Name = "txt_BMnombre";
            txt_BMnombre.Size = new Size(198, 27);
            txt_BMnombre.TabIndex = 1;
            // 
            // lbl_BMnombre
            // 
            lbl_BMnombre.AutoSize = true;
            lbl_BMnombre.Location = new Point(20, 35);
            lbl_BMnombre.Name = "lbl_BMnombre";
            lbl_BMnombre.Size = new Size(64, 20);
            lbl_BMnombre.TabIndex = 0;
            lbl_BMnombre.Text = "Nombre";
            // 
            // lbl_resbusquedaMascota
            // 
            lbl_resbusquedaMascota.AutoSize = true;
            lbl_resbusquedaMascota.Location = new Point(527, 53);
            lbl_resbusquedaMascota.Name = "lbl_resbusquedaMascota";
            lbl_resbusquedaMascota.Size = new Size(75, 20);
            lbl_resbusquedaMascota.TabIndex = 3;
            lbl_resbusquedaMascota.Text = "Resultado";
            // 
            // Enunciado1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 576);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Enunciado1";
            Text = "Enunciado 1";
            Load += Enunciado1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascota).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label lbl_telefono;
        private Label lbl_direccion;
        private Label lbl_nombre;
        private TextBox txt_Dnombre;
        private Button btn_registroDueño;
        private TextBox txt_Dtelefono;
        private TextBox txt_Ddireccion;
        private Label lbl_Mraza;
        private Label lbl_Medad;
        private Label lbl_Mnombre;
        private Label lbl_Mdueño;
        private TextBox txt_Mraza;
        private TextBox txt_Medad;
        private TextBox txt_Mnombre;
        private Button btn_registroMascota;
        private ComboBox cbo_Mdueño;
        private DataGridView dgvMascota;
        private GroupBox groupBox3;
        private Button btn_BMbuscar;
        private TextBox txt_BMnombre;
        private Label lbl_BMnombre;
        private Label lbl_resbusquedaMascota;
    }
}
