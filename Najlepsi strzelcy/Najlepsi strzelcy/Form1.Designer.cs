namespace Najlepsi_strzelcy
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(74, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 51);
			this.button1.TabIndex = 0;
			this.button1.Text = "AddScorer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(74, 89);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 64);
			this.button2.TabIndex = 1;
			this.button2.Tag = "Scorers list";
			this.button2.Text = "Scorers list";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(74, 183);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(82, 41);
			this.button3.TabIndex = 2;
			this.button3.Text = "remove scorer";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(74, 248);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(81, 39);
			this.button4.TabIndex = 3;
			this.button4.Text = "Show scorer";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(229, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(206, 61);
			this.button5.TabIndex = 4;
			this.button5.Text = "Sort scorers desc by total goals";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(229, 92);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(206, 61);
			this.button6.TabIndex = 5;
			this.button6.Text = "Sort scorers desc by CHL goals";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(231, 183);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(204, 40);
			this.button7.TabIndex = 6;
			this.button7.Text = "Sort scorers desc by leaques goals";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(231, 248);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(204, 40);
			this.button8.TabIndex = 7;
			this.button8.Text = "Sort scorers desc by leaques goals";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(493, 21);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(185, 51);
			this.button9.TabIndex = 8;
			this.button9.Text = "scorers with  min. 50 goals in champions leaque";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(493, 102);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(185, 51);
			this.button10.TabIndex = 9;
			this.button10.Text = "scorers with  min. 50 goals in national representation";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(493, 183);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(185, 51);
			this.button11.TabIndex = 10;
			this.button11.Text = "scorers with  min. 500 goals in  leaques";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(494, 257);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(183, 30);
			this.button12.TabIndex = 11;
			this.button12.Text = "Add next goals";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "The best scorers";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
	}
}

