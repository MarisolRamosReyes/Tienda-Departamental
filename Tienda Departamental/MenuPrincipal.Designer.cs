namespace Tienda_Departamental
{
    partial class MenuPrincipal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CreditoInicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPagosProximos = new System.Windows.Forms.Button();
            this.btnPagosVencidos = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAumentoCredito = new System.Windows.Forms.Button();
            this.btnSolicitarCredito = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelChildFrom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelChildFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.CreditoInicial);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnCredito);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 768);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 357);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(250, 45);
            this.btnProductos.TabIndex = 10;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CreditoInicial
            // 
            this.CreditoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreditoInicial.AutoSize = true;
            this.CreditoInicial.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditoInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CreditoInicial.Location = new System.Drawing.Point(43, 638);
            this.CreditoInicial.Name = "CreditoInicial";
            this.CreditoInicial.Size = new System.Drawing.Size(25, 28);
            this.CreditoInicial.TabIndex = 8;
            this.CreditoInicial.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crédito Inicial";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 723);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnPagosProximos);
            this.panel2.Controls.Add(this.btnPagosVencidos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 80);
            this.panel2.TabIndex = 5;
            // 
            // btnPagosProximos
            // 
            this.btnPagosProximos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPagosProximos.FlatAppearance.BorderSize = 0;
            this.btnPagosProximos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagosProximos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagosProximos.ForeColor = System.Drawing.Color.White;
            this.btnPagosProximos.Location = new System.Drawing.Point(0, 40);
            this.btnPagosProximos.Name = "btnPagosProximos";
            this.btnPagosProximos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPagosProximos.Size = new System.Drawing.Size(250, 40);
            this.btnPagosProximos.TabIndex = 1;
            this.btnPagosProximos.Text = "Proximos";
            this.btnPagosProximos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagosProximos.UseVisualStyleBackColor = false;
            this.btnPagosProximos.Click += new System.EventHandler(this.btnPagosProximos_Click);
            // 
            // btnPagosVencidos
            // 
            this.btnPagosVencidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPagosVencidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagosVencidos.FlatAppearance.BorderSize = 0;
            this.btnPagosVencidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagosVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagosVencidos.ForeColor = System.Drawing.Color.White;
            this.btnPagosVencidos.Location = new System.Drawing.Point(0, 0);
            this.btnPagosVencidos.Name = "btnPagosVencidos";
            this.btnPagosVencidos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPagosVencidos.Size = new System.Drawing.Size(250, 40);
            this.btnPagosVencidos.TabIndex = 0;
            this.btnPagosVencidos.Text = "Vencidos";
            this.btnPagosVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagosVencidos.UseVisualStyleBackColor = false;
            this.btnPagosVencidos.Click += new System.EventHandler(this.btnPagosVencidos_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.Location = new System.Drawing.Point(0, 232);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPagos.Size = new System.Drawing.Size(250, 45);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnAumentoCredito);
            this.panel1.Controls.Add(this.btnSolicitarCredito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 42);
            this.panel1.TabIndex = 3;
            // 
            // btnAumentoCredito
            // 
            this.btnAumentoCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAumentoCredito.FlatAppearance.BorderSize = 0;
            this.btnAumentoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentoCredito.ForeColor = System.Drawing.Color.White;
            this.btnAumentoCredito.Location = new System.Drawing.Point(0, 3);
            this.btnAumentoCredito.Name = "btnAumentoCredito";
            this.btnAumentoCredito.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAumentoCredito.Size = new System.Drawing.Size(250, 40);
            this.btnAumentoCredito.TabIndex = 5;
            this.btnAumentoCredito.Text = "Aumento de Credito";
            this.btnAumentoCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAumentoCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAumentoCredito.UseVisualStyleBackColor = false;
            this.btnAumentoCredito.Click += new System.EventHandler(this.btnAumentoCredito_Click);
            // 
            // btnSolicitarCredito
            // 
            this.btnSolicitarCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSolicitarCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitarCredito.FlatAppearance.BorderSize = 0;
            this.btnSolicitarCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarCredito.ForeColor = System.Drawing.Color.White;
            this.btnSolicitarCredito.Location = new System.Drawing.Point(0, 0);
            this.btnSolicitarCredito.Name = "btnSolicitarCredito";
            this.btnSolicitarCredito.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSolicitarCredito.Size = new System.Drawing.Size(250, 40);
            this.btnSolicitarCredito.TabIndex = 4;
            this.btnSolicitarCredito.Text = "Solicitar Credito";
            this.btnSolicitarCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitarCredito.UseVisualStyleBackColor = false;
            this.btnSolicitarCredito.Click += new System.EventHandler(this.btnSolicitarCredito_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.Black;
            this.btnCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCredito.FlatAppearance.BorderSize = 0;
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.ForeColor = System.Drawing.Color.White;
            this.btnCredito.Location = new System.Drawing.Point(0, 145);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCredito.Size = new System.Drawing.Size(250, 45);
            this.btnCredito.TabIndex = 2;
            this.btnCredito.Text = "Credito";
            this.btnCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(0, 100);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCompras.Size = new System.Drawing.Size(250, 45);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Tienda_Departamental.Properties.Resources.Ambar_Logo___Original___5000x5000__1_;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(250, 725);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 43);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panelChildFrom
            // 
            this.panelChildFrom.Controls.Add(this.pictureBox1);
            this.panelChildFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFrom.Location = new System.Drawing.Point(250, 0);
            this.panelChildFrom.Name = "panelChildFrom";
            this.panelChildFrom.Size = new System.Drawing.Size(1116, 725);
            this.panelChildFrom.TabIndex = 2;
            this.panelChildFrom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildFrom_Paint);
            this.panelChildFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelChildFrom_MouseDown);
            this.panelChildFrom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelChildFrom_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Tienda_Departamental.Properties.Resources.Ambar_Logo___Original___5000x5000__2_;
            this.pictureBox1.Location = new System.Drawing.Point(297, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelChildFrom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelChildFrom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSolicitarCredito;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnAumentoCredito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPagosVencidos;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnPagosProximos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelChildFrom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CreditoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductos;
    }
}