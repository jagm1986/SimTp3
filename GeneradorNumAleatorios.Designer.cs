namespace TP3_SIM
{
    partial class GeneradorNumAleatorios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CantidadDeIntervalos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.CantidadDeValores = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.ComboBoxDistribucion = new System.Windows.Forms.ComboBox();
            this.GroupBoxParametros = new System.Windows.Forms.GroupBox();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.Lambda = new System.Windows.Forms.Label();
            this.TextBoxLambda = new System.Windows.Forms.TextBox();
            this.TextBoxDesviacion = new System.Windows.Forms.TextBox();
            this.TextBoxMedia = new System.Windows.Forms.TextBox();
            this.Desviacion = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.Media = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.Distribucion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consignaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxValores = new System.Windows.Forms.TextBox();
            this.TextBoxIntervalos = new System.Windows.Forms.TextBox();
            this.checkPoisson = new System.Windows.Forms.CheckBox();
            this.GroupBoxParametros.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CantidadDeIntervalos
            // 
            this.CantidadDeIntervalos.AutoSize = true;
            this.CantidadDeIntervalos.Location = new System.Drawing.Point(41, 125);
            this.CantidadDeIntervalos.Name = "CantidadDeIntervalos";
            this.CantidadDeIntervalos.Size = new System.Drawing.Size(113, 13);
            this.CantidadDeIntervalos.TabIndex = 15;
            this.CantidadDeIntervalos.Text = "Cantidad de Intervalos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(508, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CantidadDeValores
            // 
            this.CantidadDeValores.AutoSize = true;
            this.CantidadDeValores.Location = new System.Drawing.Point(41, 94);
            this.CantidadDeValores.Name = "CantidadDeValores";
            this.CantidadDeValores.Size = new System.Drawing.Size(102, 13);
            this.CantidadDeValores.TabIndex = 14;
            this.CantidadDeValores.Text = "Cantidad de Valores";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(54, 360);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // ComboBoxDistribucion
            // 
            this.ComboBoxDistribucion.FormattingEnabled = true;
            this.ComboBoxDistribucion.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial",
            "Poisson"});
            this.ComboBoxDistribucion.Location = new System.Drawing.Point(171, 48);
            this.ComboBoxDistribucion.Name = "ComboBoxDistribucion";
            this.ComboBoxDistribucion.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxDistribucion.TabIndex = 0;
            this.ComboBoxDistribucion.Text = "Seleccione";
            this.ComboBoxDistribucion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDistribucion_SelectedIndexChanged);
            // 
            // GroupBoxParametros
            // 
            this.GroupBoxParametros.Controls.Add(this.TextBoxA);
            this.GroupBoxParametros.Controls.Add(this.TextBoxB);
            this.GroupBoxParametros.Controls.Add(this.Lambda);
            this.GroupBoxParametros.Controls.Add(this.TextBoxLambda);
            this.GroupBoxParametros.Controls.Add(this.TextBoxDesviacion);
            this.GroupBoxParametros.Controls.Add(this.TextBoxMedia);
            this.GroupBoxParametros.Controls.Add(this.Desviacion);
            this.GroupBoxParametros.Controls.Add(this.B);
            this.GroupBoxParametros.Controls.Add(this.Media);
            this.GroupBoxParametros.Controls.Add(this.A);
            this.GroupBoxParametros.Location = new System.Drawing.Point(44, 181);
            this.GroupBoxParametros.Name = "GroupBoxParametros";
            this.GroupBoxParametros.Size = new System.Drawing.Size(539, 135);
            this.GroupBoxParametros.TabIndex = 4;
            this.GroupBoxParametros.TabStop = false;
            this.GroupBoxParametros.Text = "Parametros";
            // 
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(343, 27);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(121, 20);
            this.TextBoxA.TabIndex = 3;
            this.TextBoxA.TextChanged += new System.EventHandler(this.TextBoxA_TextChanged);
            this.TextBoxA.Hide();

            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(343, 54);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(121, 20);
            this.TextBoxB.TabIndex = 4;
            this.TextBoxB.TextChanged += new System.EventHandler(this.TextBoxB_TextChanged);
            this.TextBoxB.Hide();

            // 
            // Lambda
            // 
            this.Lambda.AutoSize = true;
            this.Lambda.Location = new System.Drawing.Point(40, 90);
            this.Lambda.Name = "Lambda";
            this.Lambda.Size = new System.Drawing.Size(45, 13);
            this.Lambda.TabIndex = 0;
            this.Lambda.Text = "";

            // 
            // TextBoxLambda
            // 
            this.TextBoxLambda.Location = new System.Drawing.Point(127, 87);
            this.TextBoxLambda.Name = "TextBoxLambda";
            this.TextBoxLambda.Size = new System.Drawing.Size(121, 20);
            this.TextBoxLambda.TabIndex = 2;
            this.TextBoxLambda.TextChanged += new System.EventHandler(this.TextBoxLambda_TextChanged);
            this.TextBoxLambda.Hide();
            // 
            // TextBoxDesviacion
            // 
            this.TextBoxDesviacion.Location = new System.Drawing.Point(127, 54);
            this.TextBoxDesviacion.Name = "TextBoxDesviacion";
            this.TextBoxDesviacion.Size = new System.Drawing.Size(121, 20);
            this.TextBoxDesviacion.TabIndex = 1;
            this.TextBoxDesviacion.TextChanged += new System.EventHandler(this.TextBoxDesviacion_TextChanged);
            this.TextBoxDesviacion.Hide();
            // 
            // TextBoxMedia
            // 
            this.TextBoxMedia.Location = new System.Drawing.Point(127, 22);
            this.TextBoxMedia.Name = "TextBoxMedia";
            this.TextBoxMedia.Size = new System.Drawing.Size(121, 20);
            this.TextBoxMedia.TabIndex = 0;
            this.TextBoxMedia.TextChanged += new System.EventHandler(this.TextBoxMedia_TextChanged);
            this.TextBoxMedia.Hide();
            // 
            // Desviacion
            // 
            this.Desviacion.AutoSize = true;
            this.Desviacion.Location = new System.Drawing.Point(40, 61);
            this.Desviacion.Name = "Desviacion";
            this.Desviacion.Size = new System.Drawing.Size(60, 13);
            this.Desviacion.TabIndex = 2;
            this.Desviacion.Text = "";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(323, 57);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(14, 13);
            this.B.TabIndex = 0;
            this.B.Text = "";
            // 
            // Media
            // 
            this.Media.AutoSize = true;
            this.Media.Location = new System.Drawing.Point(40, 34);
            this.Media.Name = "Media";
            this.Media.Size = new System.Drawing.Size(36, 13);
            this.Media.TabIndex = 0;
            this.Media.Text = "";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(323, 30);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 13);
            this.A.TabIndex = 1;
            this.A.Text = "";
            // 
            // Distribucion
            // 
            this.Distribucion.AutoSize = true;
            this.Distribucion.Location = new System.Drawing.Point(41, 56);
            this.Distribucion.Name = "Distribucion";
            this.Distribucion.Size = new System.Drawing.Size(62, 13);
            this.Distribucion.TabIndex = 11;
            this.Distribucion.Text = "Distribucion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consignaToolStripMenuItem,
            this.acercaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // consignaToolStripMenuItem
            // 
            this.consignaToolStripMenuItem.Name = "consignaToolStripMenuItem";
            this.consignaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.consignaToolStripMenuItem.Text = "Consigna";
            this.consignaToolStripMenuItem.Click += new System.EventHandler(this.consignaToolStripMenuItem_Click);
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.acercaToolStripMenuItem.Text = "Acerca";
            this.acercaToolStripMenuItem.Click += new System.EventHandler(this.acercaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // TextBoxValores
            // 
            this.TextBoxValores.Location = new System.Drawing.Point(171, 87);
            this.TextBoxValores.Name = "TextBoxValores";
            this.TextBoxValores.Size = new System.Drawing.Size(121, 20);
            this.TextBoxValores.TabIndex = 2;
            this.TextBoxValores.TextChanged += new System.EventHandler(this.TextBoxValores_TextChanged);
            // 
            // TextBoxIntervalos
            // 
            this.TextBoxIntervalos.Location = new System.Drawing.Point(171, 118);
            this.TextBoxIntervalos.Name = "TextBoxIntervalos";
            this.TextBoxIntervalos.Size = new System.Drawing.Size(121, 20);
            this.TextBoxIntervalos.TabIndex = 3;
            this.TextBoxIntervalos.TextChanged += new System.EventHandler(this.TextBoxIntervalos_TextChanged);
            // 
            // checkPoisson
            // 
            this.checkPoisson.AutoSize = true;
            this.checkPoisson.Enabled = false;
            this.checkPoisson.Location = new System.Drawing.Point(332, 50);
            this.checkPoisson.Name = "checkPoisson";
            this.checkPoisson.Size = new System.Drawing.Size(145, 17);
            this.checkPoisson.TabIndex = 1;
            this.checkPoisson.Text = "Calcular a partir de media";
            this.checkPoisson.UseVisualStyleBackColor = true;
            this.checkPoisson.CheckedChanged += new System.EventHandler(this.checkPoisson_CheckedChanged);
            // 
            // GeneradorNumAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 411);
            this.Controls.Add(this.checkPoisson);
            this.Controls.Add(this.TextBoxIntervalos);
            this.Controls.Add(this.TextBoxValores);
            this.Controls.Add(this.CantidadDeIntervalos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.CantidadDeValores);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.ComboBoxDistribucion);
            this.Controls.Add(this.GroupBoxParametros);
            this.Controls.Add(this.Distribucion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeneradorNumAleatorios";
            this.Text = "Generador de Numeros Aleatorios";
            this.Load += new System.EventHandler(this.GeneradorNumAleatorios_Load);
            this.GroupBoxParametros.ResumeLayout(false);
            this.GroupBoxParametros.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CantidadDeIntervalos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label CantidadDeValores;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox ComboBoxDistribucion;
        private System.Windows.Forms.GroupBox GroupBoxParametros;
        private System.Windows.Forms.Label Lambda;
        private System.Windows.Forms.Label Desviacion;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label Media;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label Distribucion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consignaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxLambda;
        private System.Windows.Forms.TextBox TextBoxDesviacion;
        private System.Windows.Forms.TextBox TextBoxMedia;
        private System.Windows.Forms.TextBox TextBoxValores;
        private System.Windows.Forms.TextBox TextBoxIntervalos;
        private System.Windows.Forms.CheckBox checkPoisson;
    }
}

