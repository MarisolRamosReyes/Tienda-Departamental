namespace Tienda_Departamental
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonIncrementar = new System.Windows.Forms.Button();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.buttonDecrementar = new System.Windows.Forms.Button();
            this.buttonComprar = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonComprar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 244);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.buttonIncrementar);
            this.panel2.Controls.Add(this.labelCantidad);
            this.panel2.Controls.Add(this.buttonDecrementar);
            this.panel2.Location = new System.Drawing.Point(174, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 35);
            this.panel2.TabIndex = 5;
            // 
            // buttonIncrementar
            // 
            this.buttonIncrementar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncrementar.Location = new System.Drawing.Point(102, 0);
            this.buttonIncrementar.Name = "buttonIncrementar";
            this.buttonIncrementar.Size = new System.Drawing.Size(36, 35);
            this.buttonIncrementar.TabIndex = 12;
            this.buttonIncrementar.Text = "+";
            this.buttonIncrementar.UseVisualStyleBackColor = true;
            // 
            // labelCantidad
            // 
            this.labelCantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(42, 5);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(58, 23);
            this.labelCantidad.TabIndex = 11;
            this.labelCantidad.Text = "1";
            this.labelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDecrementar
            // 
            this.buttonDecrementar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrementar.Location = new System.Drawing.Point(0, 0);
            this.buttonDecrementar.Name = "buttonDecrementar";
            this.buttonDecrementar.Size = new System.Drawing.Size(36, 35);
            this.buttonDecrementar.TabIndex = 9;
            this.buttonDecrementar.Text = "-";
            this.buttonDecrementar.UseVisualStyleBackColor = true;
            // 
            // buttonComprar
            // 
            this.buttonComprar.AutoSize = false;
            this.buttonComprar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonComprar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonComprar.Depth = 0;
            this.buttonComprar.HighEmphasis = true;
            this.buttonComprar.Icon = null;
            this.buttonComprar.Location = new System.Drawing.Point(74, 200);
            this.buttonComprar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonComprar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonComprar.Size = new System.Drawing.Size(200, 36);
            this.buttonComprar.TabIndex = 4;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonComprar.UseAccentColor = false;
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(171, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(171, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(348, 250);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton buttonComprar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonIncrementar;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button buttonDecrementar;
    }
}
