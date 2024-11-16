namespace Tienda_Departamental
{
    partial class SalirForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelmensaje = new System.Windows.Forms.Label();
            this.btnsi = new MaterialSkin.Controls.MaterialButton();
            this.btnno = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnno);
            this.panel1.Controls.Add(this.btnsi);
            this.panel1.Controls.Add(this.labelmensaje);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 250);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda_Departamental.Properties.Resources.gifSalir;
            this.pictureBox1.Location = new System.Drawing.Point(199, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelmensaje
            // 
            this.labelmensaje.AutoSize = true;
            this.labelmensaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmensaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelmensaje.Location = new System.Drawing.Point(113, 34);
            this.labelmensaje.Name = "labelmensaje";
            this.labelmensaje.Size = new System.Drawing.Size(289, 18);
            this.labelmensaje.TabIndex = 1;
            this.labelmensaje.Text = "¿Estás seguro de que deseas salir?";
            // 
            // btnsi
            // 
            this.btnsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsi.Depth = 0;
            this.btnsi.HighEmphasis = true;
            this.btnsi.Icon = null;
            this.btnsi.Location = new System.Drawing.Point(136, 179);
            this.btnsi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsi.Name = "btnsi";
            this.btnsi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnsi.Size = new System.Drawing.Size(64, 36);
            this.btnsi.TabIndex = 2;
            this.btnsi.Text = "Si";
            this.btnsi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnsi.UseAccentColor = false;
            this.btnsi.UseVisualStyleBackColor = true;
            this.btnsi.Click += new System.EventHandler(this.btnsi_Click);
            // 
            // btnno
            // 
            this.btnno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnno.Depth = 0;
            this.btnno.HighEmphasis = true;
            this.btnno.Icon = null;
            this.btnno.Location = new System.Drawing.Point(300, 179);
            this.btnno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnno.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnno.Name = "btnno";
            this.btnno.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnno.Size = new System.Drawing.Size(64, 36);
            this.btnno.TabIndex = 4;
            this.btnno.Text = "No";
            this.btnno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnno.UseAccentColor = false;
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // SalirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalirForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnno;
        private MaterialSkin.Controls.MaterialButton btnsi;
        private System.Windows.Forms.Label labelmensaje;
    }
}