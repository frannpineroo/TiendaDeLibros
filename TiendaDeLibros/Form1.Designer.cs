namespace TiendaDeLibros
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arteYDiseñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.computaciónYSistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ficciónYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infantilYJuvenilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deportesYRecreaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblLibros = new System.Windows.Forms.Label();
			this.lblProveedores = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.lblLibros);
			this.tabPage1.Controls.Add(this.vScrollBar1);
			this.tabPage1.Controls.Add(this.menuStrip1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 400);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lblProveedores);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 400);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(741, 3);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(24, 394);
			this.vScrollBar1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arteYDiseñoToolStripMenuItem,
            this.computaciónYSistemasToolStripMenuItem,
            this.ficciónYToolStripMenuItem,
            this.hogarToolStripMenuItem,
            this.infantilYJuvenilToolStripMenuItem,
            this.deportesYRecreaciónToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(3, 3);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(762, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arteYDiseñoToolStripMenuItem
			// 
			this.arteYDiseñoToolStripMenuItem.Name = "arteYDiseñoToolStripMenuItem";
			this.arteYDiseñoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.arteYDiseñoToolStripMenuItem.Text = "Arte y Diseño";
			this.arteYDiseñoToolStripMenuItem.Click += new System.EventHandler(this.arteYDiseñoToolStripMenuItem_Click);
			// 
			// computaciónYSistemasToolStripMenuItem
			// 
			this.computaciónYSistemasToolStripMenuItem.Name = "computaciónYSistemasToolStripMenuItem";
			this.computaciónYSistemasToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
			this.computaciónYSistemasToolStripMenuItem.Text = "Computación y Sistemas";
			// 
			// ficciónYToolStripMenuItem
			// 
			this.ficciónYToolStripMenuItem.Name = "ficciónYToolStripMenuItem";
			this.ficciónYToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
			this.ficciónYToolStripMenuItem.Text = " Ficción y Literatura";
			// 
			// hogarToolStripMenuItem
			// 
			this.hogarToolStripMenuItem.Name = "hogarToolStripMenuItem";
			this.hogarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.hogarToolStripMenuItem.Text = "Hogar";
			// 
			// infantilYJuvenilToolStripMenuItem
			// 
			this.infantilYJuvenilToolStripMenuItem.Name = "infantilYJuvenilToolStripMenuItem";
			this.infantilYJuvenilToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.infantilYJuvenilToolStripMenuItem.Text = "Infantil y Juvenil";
			// 
			// deportesYRecreaciónToolStripMenuItem
			// 
			this.deportesYRecreaciónToolStripMenuItem.Name = "deportesYRecreaciónToolStripMenuItem";
			this.deportesYRecreaciónToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
			this.deportesYRecreaciónToolStripMenuItem.Text = "Deportes y Recreación";
			// 
			// lblLibros
			// 
			this.lblLibros.AutoSize = true;
			this.lblLibros.Location = new System.Drawing.Point(97, 103);
			this.lblLibros.Name = "lblLibros";
			this.lblLibros.Size = new System.Drawing.Size(35, 13);
			this.lblLibros.TabIndex = 2;
			this.lblLibros.Text = "Libros";
			this.lblLibros.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblProveedores
			// 
			this.lblProveedores.AutoSize = true;
			this.lblProveedores.Location = new System.Drawing.Point(23, 36);
			this.lblProveedores.Name = "lblProveedores";
			this.lblProveedores.Size = new System.Drawing.Size(67, 13);
			this.lblProveedores.TabIndex = 0;
			this.lblProveedores.Text = "Proveedores";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(190, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Selecciona una Categoría de libros";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem arteYDiseñoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem computaciónYSistemasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ficciónYToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hogarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infantilYJuvenilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deportesYRecreaciónToolStripMenuItem;
		private System.Windows.Forms.Label lblLibros;
		private System.Windows.Forms.Label lblProveedores;
		private System.Windows.Forms.Label label1;
	}
}

