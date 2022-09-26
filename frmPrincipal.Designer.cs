namespace exe1felipeDS
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.btnSomar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtValor1 = new System.Windows.Forms.TextBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSomar
			// 
			this.btnSomar.AutoSize = true;
			this.btnSomar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSomar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSomar.BackgroundImage")));
			this.btnSomar.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSomar.Location = new System.Drawing.Point(242, 182);
			this.btnSomar.Name = "btnSomar";
			this.btnSomar.Size = new System.Drawing.Size(92, 33);
			this.btnSomar.TabIndex = 0;
			this.btnSomar.Text = "ºC EM ºF";
			this.btnSomar.UseVisualStyleBackColor = false;
			this.btnSomar.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(199, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "TEMPERATURA";
			// 
			// txtValor1
			// 
			this.txtValor1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor1.Location = new System.Drawing.Point(325, 96);
			this.txtValor1.Name = "txtValor1";
			this.txtValor1.Size = new System.Drawing.Size(100, 26);
			this.txtValor1.TabIndex = 2;
			// 
			// btnSair
			// 
			this.btnSair.AutoSize = true;
			this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSair.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(30, 377);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 33);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.AutoSize = true;
			this.btnLimpar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(523, 93);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(88, 33);
			this.btnLimpar.TabIndex = 6;
			this.btnLimpar.Text = "LIMPAR";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(365, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 33);
			this.button1.TabIndex = 7;
			this.button1.Text = "ºC EM ºK";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(242, 243);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 33);
			this.button2.TabIndex = 8;
			this.button2.Text = "ºF EM ºC";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(365, 243);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 33);
			this.button3.TabIndex = 9;
			this.button3.Text = "ºF EM ºK";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(242, 309);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(92, 32);
			this.button4.TabIndex = 10;
			this.button4.Text = "ºK EM ºC";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(365, 309);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(90, 32);
			this.button5.TabIndex = 11;
			this.button5.Text = "ºK EM ºF";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::exe1felipeDS.Properties.Resources.maxresdefault;
			this.ClientSize = new System.Drawing.Size(759, 431);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.txtValor1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSomar);
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FelipeBarbosaExe00";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSomar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtValor1;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}

