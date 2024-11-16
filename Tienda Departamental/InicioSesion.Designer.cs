namespace Tienda_Departamental
{
    partial class InicioSesion
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.UserText = new MaterialSkin.Controls.MaterialTextBox();
            this.contrsenatext = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonIngresar = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialDivider1.Location = new System.Drawing.Point(33, 346);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(270, 2);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // UserText
            // 
            this.UserText.AnimateReadOnly = false;
            this.UserText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserText.Depth = 0;
            this.UserText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserText.ForeColor = System.Drawing.Color.White;
            this.UserText.Hint = "Usuario";
            this.UserText.LeadingIcon = null;
            this.UserText.Location = new System.Drawing.Point(44, 180);
            this.UserText.MaxLength = 50;
            this.UserText.MouseState = MaterialSkin.MouseState.OUT;
            this.UserText.Multiline = false;
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(250, 50);
            this.UserText.TabIndex = 1;
            this.UserText.Text = "";
            this.UserText.TrailingIcon = null;
            this.UserText.TextChanged += new System.EventHandler(this.UserText_TextChanged);
            this.UserText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserText_KeyDown);
            // 
            // contrsenatext
            // 
            this.contrsenatext.AnimateReadOnly = false;
            this.contrsenatext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contrsenatext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contrsenatext.Depth = 0;
            this.contrsenatext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contrsenatext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.contrsenatext.Hint = "Contraseña";
            this.contrsenatext.LeadingIcon = null;
            this.contrsenatext.Location = new System.Drawing.Point(44, 267);
            this.contrsenatext.MaxLength = 50;
            this.contrsenatext.MouseState = MaterialSkin.MouseState.OUT;
            this.contrsenatext.Multiline = false;
            this.contrsenatext.Name = "contrsenatext";
            this.contrsenatext.Password = true;
            this.contrsenatext.Size = new System.Drawing.Size(250, 50);
            this.contrsenatext.TabIndex = 2;
            this.contrsenatext.Text = "";
            this.contrsenatext.TrailingIcon = null;
            this.contrsenatext.TextChanged += new System.EventHandler(this.contrsenatext_TextChanged);
            this.contrsenatext.Enter += new System.EventHandler(this.contrsenatext_Enter);
            this.contrsenatext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contrsenatext_KeyDown);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.AutoSize = false;
            this.buttonIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIngresar.BackColor = System.Drawing.Color.Gray;
            this.buttonIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonIngresar.Depth = 0;
            this.buttonIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.buttonIngresar.HighEmphasis = true;
            this.buttonIngresar.Icon = null;
            this.buttonIngresar.Location = new System.Drawing.Point(105, 410);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonIngresar.Size = new System.Drawing.Size(150, 36);
            this.buttonIngresar.TabIndex = 3;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonIngresar.UseAccentColor = false;
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inicio de Sesión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(86, 360);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Aún no te registras? Regístrate\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Tienda_Departamental.Properties.Resources.windowminimize_104316;
            this.pictureBox3.Location = new System.Drawing.Point(299, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tienda_Departamental.Properties.Resources.windowclose_104378;
            this.pictureBox2.Location = new System.Drawing.Point(328, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda_Departamental.Properties.Resources.Ambar_Logo___Original___5000x50001;
            this.pictureBox1.Location = new System.Drawing.Point(55, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(355, 482);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contrsenatext);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.materialDivider1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox UserText;
        private MaterialSkin.Controls.MaterialTextBox contrsenatext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton buttonIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

