namespace Tienda_Departamental
{
    partial class RegistroUser
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIngresar = new MaterialSkin.Controls.MaterialButton();
            this.contrasenatext = new MaterialSkin.Controls.MaterialTextBox();
            this.UsuarioText = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.NombreText = new MaterialSkin.Controls.MaterialTextBox();
            this.CorreoText = new MaterialSkin.Controls.MaterialTextBox();
            this.confircontrsenatext = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(64, 561);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(227, 16);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ya tienes una cuenta?, Inicia Sesión\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseEnter += new System.EventHandler(this.linkLabel1_MouseEnter);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registro";
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
            this.buttonIngresar.Location = new System.Drawing.Point(100, 597);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonIngresar.Size = new System.Drawing.Size(150, 36);
            this.buttonIngresar.TabIndex = 0;
            this.buttonIngresar.Text = "Registrarme";
            this.buttonIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonIngresar.UseAccentColor = false;
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // contrasenatext
            // 
            this.contrasenatext.AnimateReadOnly = false;
            this.contrasenatext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contrasenatext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contrasenatext.Depth = 0;
            this.contrasenatext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contrasenatext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.contrasenatext.Hint = "Contraseña";
            this.contrasenatext.LeadingIcon = null;
            this.contrasenatext.Location = new System.Drawing.Point(55, 403);
            this.contrasenatext.MaxLength = 50;
            this.contrasenatext.MouseState = MaterialSkin.MouseState.OUT;
            this.contrasenatext.Multiline = false;
            this.contrasenatext.Name = "contrasenatext";
            this.contrasenatext.Password = true;
            this.contrasenatext.Size = new System.Drawing.Size(250, 50);
            this.contrasenatext.TabIndex = 13;
            this.contrasenatext.Text = "";
            this.contrasenatext.TrailingIcon = null;
            // 
            // UsuarioText
            // 
            this.UsuarioText.AnimateReadOnly = false;
            this.UsuarioText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UsuarioText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioText.Depth = 0;
            this.UsuarioText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsuarioText.ForeColor = System.Drawing.Color.White;
            this.UsuarioText.Hint = "Usuario";
            this.UsuarioText.LeadingIcon = null;
            this.UsuarioText.Location = new System.Drawing.Point(55, 241);
            this.UsuarioText.MaxLength = 50;
            this.UsuarioText.MouseState = MaterialSkin.MouseState.OUT;
            this.UsuarioText.Multiline = false;
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(250, 50);
            this.UsuarioText.TabIndex = 12;
            this.UsuarioText.Text = "";
            this.UsuarioText.TrailingIcon = null;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialDivider1.Location = new System.Drawing.Point(46, 544);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(270, 2);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // NombreText
            // 
            this.NombreText.AnimateReadOnly = false;
            this.NombreText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NombreText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreText.Depth = 0;
            this.NombreText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreText.ForeColor = System.Drawing.Color.White;
            this.NombreText.Hint = "Nombre";
            this.NombreText.LeadingIcon = null;
            this.NombreText.Location = new System.Drawing.Point(55, 174);
            this.NombreText.MaxLength = 50;
            this.NombreText.MouseState = MaterialSkin.MouseState.OUT;
            this.NombreText.Multiline = false;
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(250, 50);
            this.NombreText.TabIndex = 19;
            this.NombreText.Text = "";
            this.NombreText.TrailingIcon = null;
            // 
            // CorreoText
            // 
            this.CorreoText.AnimateReadOnly = false;
            this.CorreoText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CorreoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CorreoText.Depth = 0;
            this.CorreoText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CorreoText.ForeColor = System.Drawing.Color.White;
            this.CorreoText.Hint = "Correo";
            this.CorreoText.LeadingIcon = null;
            this.CorreoText.Location = new System.Drawing.Point(55, 322);
            this.CorreoText.MaxLength = 50;
            this.CorreoText.MouseState = MaterialSkin.MouseState.OUT;
            this.CorreoText.Multiline = false;
            this.CorreoText.Name = "CorreoText";
            this.CorreoText.Size = new System.Drawing.Size(250, 50);
            this.CorreoText.TabIndex = 20;
            this.CorreoText.Text = "";
            this.CorreoText.TrailingIcon = null;
            // 
            // confircontrsenatext
            // 
            this.confircontrsenatext.AnimateReadOnly = false;
            this.confircontrsenatext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.confircontrsenatext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confircontrsenatext.Depth = 0;
            this.confircontrsenatext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.confircontrsenatext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.confircontrsenatext.Hint = "Confirmar Contraseña";
            this.confircontrsenatext.LeadingIcon = null;
            this.confircontrsenatext.Location = new System.Drawing.Point(55, 478);
            this.confircontrsenatext.MaxLength = 50;
            this.confircontrsenatext.MouseState = MaterialSkin.MouseState.OUT;
            this.confircontrsenatext.Multiline = false;
            this.confircontrsenatext.Name = "confircontrsenatext";
            this.confircontrsenatext.Password = true;
            this.confircontrsenatext.Size = new System.Drawing.Size(250, 50);
            this.confircontrsenatext.TabIndex = 21;
            this.confircontrsenatext.Text = "";
            this.confircontrsenatext.TrailingIcon = null;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Tienda_Departamental.Properties.Resources.gtkgobackltr_104397;
            this.pictureBox4.Location = new System.Drawing.Point(4, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Tienda_Departamental.Properties.Resources.windowminimize_104316;
            this.pictureBox3.Location = new System.Drawing.Point(299, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tienda_Departamental.Properties.Resources.windowclose_104378;
            this.pictureBox2.Location = new System.Drawing.Point(328, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda_Departamental.Properties.Resources.Ambar_Logo___Original___5000x50001;
            this.pictureBox1.Location = new System.Drawing.Point(55, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(355, 646);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.confircontrsenatext);
            this.Controls.Add(this.CorreoText);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contrasenatext);
            this.Controls.Add(this.UsuarioText);
            this.Controls.Add(this.materialDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUser";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistroUser_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton buttonIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox contrasenatext;
        private MaterialSkin.Controls.MaterialTextBox UsuarioText;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox NombreText;
        private MaterialSkin.Controls.MaterialTextBox CorreoText;
        private MaterialSkin.Controls.MaterialTextBox confircontrsenatext;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}