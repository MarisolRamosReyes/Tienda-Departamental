namespace Tienda_Departamental
{
    partial class SolicitarCredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.Nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.ApellidoPaterno = new MaterialSkin.Controls.MaterialTextBox();
            this.ApellidoMaterno = new MaterialSkin.Controls.MaterialTextBox();
            this.SalarioMinimoNeto = new MaterialSkin.Controls.MaterialTextBox();
            this.Telefono = new MaterialSkin.Controls.MaterialTextBox();
            this.Dirección = new MaterialSkin.Controls.MaterialTextBox();
            this.Correo = new MaterialSkin.Controls.MaterialTextBox();
            this.NombrePDF = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guardarcredito = new MaterialSkin.Controls.MaterialButton();
            this.CreditoInicial = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 22);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(305, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solicitud de Crédito";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(352, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "INE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(288, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fotografía del Solicitante";
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(291, 529);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(167, 25);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Subir fotografía";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(658, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comprobante de Domicilio";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(693, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comprobante del Solicitante";
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(705, 529);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(167, 25);
            this.materialButton2.TabIndex = 9;
            this.materialButton2.Text = "Subir comprobante";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // Nombre
            // 
            this.Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Nombre.AnimateReadOnly = false;
            this.Nombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre.CausesValidation = false;
            this.Nombre.Depth = 0;
            this.Nombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Hint = "Nombre(s)";
            this.Nombre.LeadingIcon = null;
            this.Nombre.Location = new System.Drawing.Point(12, 136);
            this.Nombre.MaxLength = 20;
            this.Nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.Nombre.Multiline = false;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(347, 50);
            this.Nombre.TabIndex = 12;
            this.Nombre.Text = "";
            this.Nombre.TrailingIcon = null;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ApellidoPaterno.AnimateReadOnly = false;
            this.ApellidoPaterno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApellidoPaterno.Depth = 0;
            this.ApellidoPaterno.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ApellidoPaterno.ForeColor = System.Drawing.Color.White;
            this.ApellidoPaterno.Hint = "Apellido Paterno";
            this.ApellidoPaterno.LeadingIcon = null;
            this.ApellidoPaterno.Location = new System.Drawing.Point(378, 136);
            this.ApellidoPaterno.MaxLength = 50;
            this.ApellidoPaterno.MouseState = MaterialSkin.MouseState.OUT;
            this.ApellidoPaterno.Multiline = false;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.Size = new System.Drawing.Size(347, 50);
            this.ApellidoPaterno.TabIndex = 13;
            this.ApellidoPaterno.Text = "";
            this.ApellidoPaterno.TrailingIcon = null;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ApellidoMaterno.AnimateReadOnly = false;
            this.ApellidoMaterno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApellidoMaterno.Depth = 0;
            this.ApellidoMaterno.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ApellidoMaterno.ForeColor = System.Drawing.Color.White;
            this.ApellidoMaterno.Hint = "Apellido Materno";
            this.ApellidoMaterno.LeadingIcon = null;
            this.ApellidoMaterno.Location = new System.Drawing.Point(740, 136);
            this.ApellidoMaterno.MaxLength = 50;
            this.ApellidoMaterno.MouseState = MaterialSkin.MouseState.OUT;
            this.ApellidoMaterno.Multiline = false;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Size = new System.Drawing.Size(347, 50);
            this.ApellidoMaterno.TabIndex = 14;
            this.ApellidoMaterno.Text = "";
            this.ApellidoMaterno.TrailingIcon = null;
            this.ApellidoMaterno.TextChanged += new System.EventHandler(this.ApellidoMaterno_TextChanged);
            // 
            // SalarioMinimoNeto
            // 
            this.SalarioMinimoNeto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalarioMinimoNeto.AnimateReadOnly = false;
            this.SalarioMinimoNeto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SalarioMinimoNeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalarioMinimoNeto.Depth = 0;
            this.SalarioMinimoNeto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalarioMinimoNeto.ForeColor = System.Drawing.Color.White;
            this.SalarioMinimoNeto.Hint = "Salario Mensual Neto";
            this.SalarioMinimoNeto.LeadingIcon = null;
            this.SalarioMinimoNeto.Location = new System.Drawing.Point(752, 275);
            this.SalarioMinimoNeto.MaxLength = 50;
            this.SalarioMinimoNeto.MouseState = MaterialSkin.MouseState.OUT;
            this.SalarioMinimoNeto.Multiline = false;
            this.SalarioMinimoNeto.Name = "SalarioMinimoNeto";
            this.SalarioMinimoNeto.Size = new System.Drawing.Size(335, 50);
            this.SalarioMinimoNeto.TabIndex = 15;
            this.SalarioMinimoNeto.Text = "";
            this.SalarioMinimoNeto.TrailingIcon = null;
            // 
            // Telefono
            // 
            this.Telefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Telefono.AnimateReadOnly = false;
            this.Telefono.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telefono.Depth = 0;
            this.Telefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Telefono.ForeColor = System.Drawing.Color.White;
            this.Telefono.Hint = "Teléfono";
            this.Telefono.LeadingIcon = null;
            this.Telefono.Location = new System.Drawing.Point(12, 205);
            this.Telefono.MaxLength = 50;
            this.Telefono.MouseState = MaterialSkin.MouseState.OUT;
            this.Telefono.Multiline = false;
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(347, 50);
            this.Telefono.TabIndex = 16;
            this.Telefono.Text = "";
            this.Telefono.TrailingIcon = null;
            // 
            // Dirección
            // 
            this.Dirección.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dirección.AnimateReadOnly = false;
            this.Dirección.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Dirección.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dirección.Depth = 0;
            this.Dirección.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dirección.ForeColor = System.Drawing.Color.White;
            this.Dirección.Hint = "Dirección";
            this.Dirección.LeadingIcon = null;
            this.Dirección.Location = new System.Drawing.Point(378, 205);
            this.Dirección.MaxLength = 50;
            this.Dirección.MouseState = MaterialSkin.MouseState.OUT;
            this.Dirección.Multiline = false;
            this.Dirección.Name = "Dirección";
            this.Dirección.Size = new System.Drawing.Size(709, 50);
            this.Dirección.TabIndex = 17;
            this.Dirección.Text = "";
            this.Dirección.TrailingIcon = null;
            // 
            // Correo
            // 
            this.Correo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Correo.AnimateReadOnly = false;
            this.Correo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Correo.Depth = 0;
            this.Correo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Correo.ForeColor = System.Drawing.Color.White;
            this.Correo.Hint = "Correo";
            this.Correo.LeadingIcon = null;
            this.Correo.Location = new System.Drawing.Point(12, 275);
            this.Correo.MaxLength = 50;
            this.Correo.MouseState = MaterialSkin.MouseState.OUT;
            this.Correo.Multiline = false;
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(713, 50);
            this.Correo.TabIndex = 18;
            this.Correo.Text = "";
            this.Correo.TrailingIcon = null;
            // 
            // NombrePDF
            // 
            this.NombrePDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NombrePDF.AutoSize = true;
            this.NombrePDF.Depth = 0;
            this.NombrePDF.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombrePDF.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NombrePDF.Location = new System.Drawing.Point(738, 463);
            this.NombrePDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.NombrePDF.Name = "NombrePDF";
            this.NombrePDF.Size = new System.Drawing.Size(31, 19);
            this.NombrePDF.TabIndex = 19;
            this.NombrePDF.Text = "PDF";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::Tienda_Departamental.Properties.Resources.unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(649, 438);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Tienda_Departamental.Properties.Resources.Credencial;
            this.pictureBox1.Location = new System.Drawing.Point(291, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guardarcredito
            // 
            this.guardarcredito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guardarcredito.AutoSize = false;
            this.guardarcredito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guardarcredito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.guardarcredito.Depth = 0;
            this.guardarcredito.Enabled = false;
            this.guardarcredito.HighEmphasis = true;
            this.guardarcredito.Icon = null;
            this.guardarcredito.Location = new System.Drawing.Point(429, 626);
            this.guardarcredito.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guardarcredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.guardarcredito.Name = "guardarcredito";
            this.guardarcredito.NoAccentTextColor = System.Drawing.Color.Empty;
            this.guardarcredito.Size = new System.Drawing.Size(303, 36);
            this.guardarcredito.TabIndex = 20;
            this.guardarcredito.Text = "Guardar";
            this.guardarcredito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.guardarcredito.UseAccentColor = false;
            this.guardarcredito.UseVisualStyleBackColor = true;
            this.guardarcredito.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // CreditoInicial
            // 
            this.CreditoInicial.AutoSize = true;
            this.CreditoInicial.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditoInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CreditoInicial.Location = new System.Drawing.Point(28, 647);
            this.CreditoInicial.Name = "CreditoInicial";
            this.CreditoInicial.Size = new System.Drawing.Size(25, 28);
            this.CreditoInicial.TabIndex = 22;
            this.CreditoInicial.Text = "0";
            this.CreditoInicial.Visible = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(582, 369);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(3, 200);
            this.materialDivider2.TabIndex = 11;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // SolicitarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1116, 725);
            this.Controls.Add(this.CreditoInicial);
            this.Controls.Add(this.guardarcredito);
            this.Controls.Add(this.NombrePDF);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Dirección);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.SalarioMinimoNeto);
            this.Controls.Add(this.ApellidoMaterno);
            this.Controls.Add(this.ApellidoPaterno);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitarCredito";
            this.Text = "SolicitarCredito";
            this.Load += new System.EventHandler(this.SolicitarCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox Nombre;
        private MaterialSkin.Controls.MaterialTextBox ApellidoPaterno;
        private MaterialSkin.Controls.MaterialTextBox ApellidoMaterno;
        private MaterialSkin.Controls.MaterialTextBox SalarioMinimoNeto;
        private MaterialSkin.Controls.MaterialTextBox Telefono;
        private MaterialSkin.Controls.MaterialTextBox Dirección;
        private MaterialSkin.Controls.MaterialTextBox Correo;
        private MaterialSkin.Controls.MaterialLabel NombrePDF;
        private MaterialSkin.Controls.MaterialButton guardarcredito;
        private System.Windows.Forms.Label CreditoInicial;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}