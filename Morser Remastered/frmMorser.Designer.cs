namespace Morser_Remastered
{
	partial class frmMorser
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbMorsecode = new System.Windows.Forms.TextBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblTextMorse = new System.Windows.Forms.Label();
			this.btnTextToMorse = new System.Windows.Forms.Button();
			this.btnMorseToText = new System.Windows.Forms.Button();
			this.btnMorseToAcoustic = new System.Windows.Forms.Button();
			this.btnMorseToVisual = new System.Windows.Forms.Button();
			this.lblFunctions = new System.Windows.Forms.Label();
			this.btnCopy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbMorsecode
			// 
			this.tbMorsecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tbMorsecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbMorsecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbMorsecode.ForeColor = System.Drawing.Color.White;
			this.tbMorsecode.Location = new System.Drawing.Point(12, 23);
			this.tbMorsecode.Multiline = true;
			this.tbMorsecode.Name = "tbMorsecode";
			this.tbMorsecode.Size = new System.Drawing.Size(308, 45);
			this.tbMorsecode.TabIndex = 0;
			this.tbMorsecode.TextChanged += new System.EventHandler(this.tbMorsecode_TextChanged);
			// 
			// tbResult
			// 
			this.tbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbResult.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbResult.ForeColor = System.Drawing.Color.White;
			this.tbResult.Location = new System.Drawing.Point(12, 87);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.ReadOnly = true;
			this.tbResult.Size = new System.Drawing.Size(308, 45);
			this.tbResult.TabIndex = 1;
			this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.BackColor = System.Drawing.Color.Transparent;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
			this.lblResult.Location = new System.Drawing.Point(9, 71);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(56, 13);
			this.lblResult.TabIndex = 2;
			this.lblResult.Text = "RESULT";
			// 
			// lblTextMorse
			// 
			this.lblTextMorse.AutoSize = true;
			this.lblTextMorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextMorse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
			this.lblTextMorse.Location = new System.Drawing.Point(12, 7);
			this.lblTextMorse.Name = "lblTextMorse";
			this.lblTextMorse.Size = new System.Drawing.Size(123, 13);
			this.lblTextMorse.TabIndex = 3;
			this.lblTextMorse.Text = "TEXT/MORSECODE";
			// 
			// btnTextToMorse
			// 
			this.btnTextToMorse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnTextToMorse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
			this.btnTextToMorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTextToMorse.ForeColor = System.Drawing.Color.White;
			this.btnTextToMorse.Location = new System.Drawing.Point(11, 151);
			this.btnTextToMorse.Name = "btnTextToMorse";
			this.btnTextToMorse.Size = new System.Drawing.Size(151, 30);
			this.btnTextToMorse.TabIndex = 4;
			this.btnTextToMorse.Text = "Text to morsecode";
			this.btnTextToMorse.UseVisualStyleBackColor = false;
			this.btnTextToMorse.Click += new System.EventHandler(this.btnTextToMorse_Click);
			// 
			// btnMorseToText
			// 
			this.btnMorseToText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnMorseToText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
			this.btnMorseToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMorseToText.ForeColor = System.Drawing.Color.White;
			this.btnMorseToText.Location = new System.Drawing.Point(169, 151);
			this.btnMorseToText.Name = "btnMorseToText";
			this.btnMorseToText.Size = new System.Drawing.Size(151, 30);
			this.btnMorseToText.TabIndex = 5;
			this.btnMorseToText.Text = "Morsecode to text";
			this.btnMorseToText.UseVisualStyleBackColor = false;
			this.btnMorseToText.Click += new System.EventHandler(this.btnMorseToText_Click);
			// 
			// btnMorseToAcoustic
			// 
			this.btnMorseToAcoustic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnMorseToAcoustic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
			this.btnMorseToAcoustic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMorseToAcoustic.ForeColor = System.Drawing.Color.White;
			this.btnMorseToAcoustic.Location = new System.Drawing.Point(11, 193);
			this.btnMorseToAcoustic.Name = "btnMorseToAcoustic";
			this.btnMorseToAcoustic.Size = new System.Drawing.Size(151, 30);
			this.btnMorseToAcoustic.TabIndex = 6;
			this.btnMorseToAcoustic.Text = "Morsecode to acoustic";
			this.btnMorseToAcoustic.UseVisualStyleBackColor = false;
			this.btnMorseToAcoustic.Click += new System.EventHandler(this.btnMorseToAcoustic_Click);
			// 
			// btnMorseToVisual
			// 
			this.btnMorseToVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnMorseToVisual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
			this.btnMorseToVisual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMorseToVisual.ForeColor = System.Drawing.Color.White;
			this.btnMorseToVisual.Location = new System.Drawing.Point(169, 193);
			this.btnMorseToVisual.Name = "btnMorseToVisual";
			this.btnMorseToVisual.Size = new System.Drawing.Size(151, 30);
			this.btnMorseToVisual.TabIndex = 7;
			this.btnMorseToVisual.Text = "Morsecode to visual";
			this.btnMorseToVisual.UseVisualStyleBackColor = false;
			this.btnMorseToVisual.Click += new System.EventHandler(this.btnMorseToVisual_Click);
			// 
			// lblFunctions
			// 
			this.lblFunctions.AutoSize = true;
			this.lblFunctions.BackColor = System.Drawing.Color.Transparent;
			this.lblFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFunctions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
			this.lblFunctions.Location = new System.Drawing.Point(12, 135);
			this.lblFunctions.Name = "lblFunctions";
			this.lblFunctions.Size = new System.Drawing.Size(78, 13);
			this.lblFunctions.TabIndex = 8;
			this.lblFunctions.Text = "FUNCTIONS";
			// 
			// btnCopy
			// 
			this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
			this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopy.ForeColor = System.Drawing.Color.White;
			this.btnCopy.Location = new System.Drawing.Point(266, 87);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(54, 45);
			this.btnCopy.TabIndex = 9;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = false;
			this.btnCopy.Visible = false;
			this.btnCopy.VisibleChanged += new System.EventHandler(this.btnCopy_VisibleChanged);
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// frmMorser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.ClientSize = new System.Drawing.Size(332, 234);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.lblFunctions);
			this.Controls.Add(this.btnMorseToVisual);
			this.Controls.Add(this.btnMorseToAcoustic);
			this.Controls.Add(this.btnMorseToText);
			this.Controls.Add(this.btnTextToMorse);
			this.Controls.Add(this.lblTextMorse);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.tbMorsecode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmMorser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Morser Remastered";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbMorsecode;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblTextMorse;
		private System.Windows.Forms.Button btnTextToMorse;
		private System.Windows.Forms.Button btnMorseToText;
		private System.Windows.Forms.Button btnMorseToAcoustic;
		private System.Windows.Forms.Button btnMorseToVisual;
		private System.Windows.Forms.Label lblFunctions;
		private System.Windows.Forms.Button btnCopy;
	}
}

