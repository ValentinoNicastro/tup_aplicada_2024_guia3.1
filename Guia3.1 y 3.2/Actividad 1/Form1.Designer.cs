namespace Actividad_1
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupModelo = new System.Windows.Forms.NumericUpDown();
            this.nupValorProd = new System.Windows.Forms.NumericUpDown();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.gbCalcular = new System.Windows.Forms.GroupBox();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.nupAñoCalcular = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDepreciacion = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorProd)).BeginInit();
            this.gbCalcular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAñoCalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.tbMarca);
            this.gbDatos.Controls.Add(this.nupValorProd);
            this.gbDatos.Controls.Add(this.nupModelo);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(13, 13);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(392, 192);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de Vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de Produccion $";
            // 
            // nupModelo
            // 
            this.nupModelo.Location = new System.Drawing.Point(209, 83);
            this.nupModelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nupModelo.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nupModelo.Name = "nupModelo";
            this.nupModelo.Size = new System.Drawing.Size(100, 20);
            this.nupModelo.TabIndex = 3;
            this.nupModelo.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // nupValorProd
            // 
            this.nupValorProd.Location = new System.Drawing.Point(209, 123);
            this.nupValorProd.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupValorProd.Name = "nupValorProd";
            this.nupValorProd.Size = new System.Drawing.Size(100, 20);
            this.nupValorProd.TabIndex = 4;
            this.nupValorProd.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(209, 43);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 5;
            // 
            // gbCalcular
            // 
            this.gbCalcular.Controls.Add(this.btnCalcular);
            this.gbCalcular.Controls.Add(this.label6);
            this.gbCalcular.Controls.Add(this.tbVidaUtil);
            this.gbCalcular.Controls.Add(this.tbDepreciacion);
            this.gbCalcular.Controls.Add(this.label5);
            this.gbCalcular.Controls.Add(this.label4);
            this.gbCalcular.Controls.Add(this.nupAñoCalcular);
            this.gbCalcular.Controls.Add(this.rbAnual);
            this.gbCalcular.Controls.Add(this.rbLineal);
            this.gbCalcular.Location = new System.Drawing.Point(13, 212);
            this.gbCalcular.Name = "gbCalcular";
            this.gbCalcular.Size = new System.Drawing.Size(392, 226);
            this.gbCalcular.TabIndex = 1;
            this.gbCalcular.TabStop = false;
            this.gbCalcular.Text = "Calcular Depreciacion";
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Location = new System.Drawing.Point(97, 35);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(53, 17);
            this.rbLineal.TabIndex = 0;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            this.rbLineal.CheckedChanged += new System.EventHandler(this.rbLineal_CheckedChanged);
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(257, 35);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(52, 17);
            this.rbAnual.TabIndex = 1;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            this.rbAnual.CheckedChanged += new System.EventHandler(this.rbAnual_CheckedChanged);
            // 
            // nupAñoCalcular
            // 
            this.nupAñoCalcular.Location = new System.Drawing.Point(146, 82);
            this.nupAñoCalcular.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nupAñoCalcular.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nupAñoCalcular.Name = "nupAñoCalcular";
            this.nupAñoCalcular.Size = new System.Drawing.Size(100, 20);
            this.nupAñoCalcular.TabIndex = 6;
            this.nupAñoCalcular.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año a Calcular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tasa Depreciacion";
            // 
            // tbDepreciacion
            // 
            this.tbDepreciacion.Enabled = false;
            this.tbDepreciacion.Location = new System.Drawing.Point(145, 120);
            this.tbDepreciacion.Name = "tbDepreciacion";
            this.tbDepreciacion.Size = new System.Drawing.Size(100, 20);
            this.tbDepreciacion.TabIndex = 6;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Enabled = false;
            this.tbVidaUtil.Location = new System.Drawing.Point(145, 156);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vida Util (Años)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(286, 104);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 45);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Costo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.gbCalcular);
            this.Controls.Add(this.gbDatos);
            this.Name = "Form1";
            this.Text = "Tarsacion De Motos";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorProd)).EndInit();
            this.gbCalcular.ResumeLayout(false);
            this.gbCalcular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAñoCalcular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.NumericUpDown nupModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.NumericUpDown nupValorProd;
        private System.Windows.Forms.GroupBox gbCalcular;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.TextBox tbDepreciacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupAñoCalcular;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbLineal;
    }
}

