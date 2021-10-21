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
			this.Addscorer = new System.Windows.Forms.Button();
			this.ScorersList = new System.Windows.Forms.Button();
			this.RemoveScorer = new System.Windows.Forms.Button();
			this.ShowScorer = new System.Windows.Forms.Button();
			this.SortScorersDescByTotalGoals = new System.Windows.Forms.Button();
			this.SortScorersDescByChlGoals = new System.Windows.Forms.Button();
			this.SortScorersDescByLeaqueGoals = new System.Windows.Forms.Button();
			this.SortScorersDescByNationalGoals = new System.Windows.Forms.Button();
			this.Scorers50CHL = new System.Windows.Forms.Button();
			this.Scorers50National = new System.Windows.Forms.Button();
			this.Scorers500Leaques = new System.Windows.Forms.Button();
			this.AddGoals = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Addscorer
			// 
			this.Addscorer.Location = new System.Drawing.Point(74, 12);
			this.Addscorer.Name = "Addscorer";
			this.Addscorer.Size = new System.Drawing.Size(82, 51);
			this.Addscorer.TabIndex = 0;
			this.Addscorer.Text = "AddScorer";
			this.Addscorer.UseVisualStyleBackColor = true;
			this.Addscorer.Click += new System.EventHandler(this.Addscorer_Click);
			// 
			// ScorersList
			// 
			this.ScorersList.Location = new System.Drawing.Point(74, 89);
			this.ScorersList.Name = "ScorersList";
			this.ScorersList.Size = new System.Drawing.Size(82, 64);
			this.ScorersList.TabIndex = 1;
			this.ScorersList.Tag = "Scorers list";
			this.ScorersList.Text = "Scorers list";
			this.ScorersList.UseVisualStyleBackColor = true;
			this.ScorersList.Click += new System.EventHandler(this.button2_Click);
			// 
			// RemoveScorer
			// 
			this.RemoveScorer.Location = new System.Drawing.Point(74, 183);
			this.RemoveScorer.Name = "RemoveScorer";
			this.RemoveScorer.Size = new System.Drawing.Size(82, 41);
			this.RemoveScorer.TabIndex = 2;
			this.RemoveScorer.Text = "remove scorer";
			this.RemoveScorer.UseVisualStyleBackColor = true;
			this.RemoveScorer.Click += new System.EventHandler(this.button3_Click);
			// 
			// ShowScorer
			// 
			this.ShowScorer.Location = new System.Drawing.Point(74, 248);
			this.ShowScorer.Name = "ShowScorer";
			this.ShowScorer.Size = new System.Drawing.Size(81, 39);
			this.ShowScorer.TabIndex = 3;
			this.ShowScorer.Text = "Show scorer";
			this.ShowScorer.UseVisualStyleBackColor = true;
			this.ShowScorer.Click += new System.EventHandler(this.button4_Click);
			// 
			// SortScorersDescByTotalGoals
			// 
			this.SortScorersDescByTotalGoals.Location = new System.Drawing.Point(229, 12);
			this.SortScorersDescByTotalGoals.Name = "SortScorersDescByTotalGoals";
			this.SortScorersDescByTotalGoals.Size = new System.Drawing.Size(206, 61);
			this.SortScorersDescByTotalGoals.TabIndex = 4;
			this.SortScorersDescByTotalGoals.Text = "Sort scorers desc by total goals";
			this.SortScorersDescByTotalGoals.UseVisualStyleBackColor = true;
			this.SortScorersDescByTotalGoals.Click += new System.EventHandler(this.button5_Click);
			// 
			// SortScorersDescByChlGoals
			// 
			this.SortScorersDescByChlGoals.Location = new System.Drawing.Point(229, 92);
			this.SortScorersDescByChlGoals.Name = "SortScorersDescByChlGoals";
			this.SortScorersDescByChlGoals.Size = new System.Drawing.Size(206, 61);
			this.SortScorersDescByChlGoals.TabIndex = 5;
			this.SortScorersDescByChlGoals.Text = "Sort scorers desc by CHL goals";
			this.SortScorersDescByChlGoals.UseVisualStyleBackColor = true;
			this.SortScorersDescByChlGoals.Click += new System.EventHandler(this.button6_Click);
			// 
			// SortScorersDescByLeaqueGoals
			// 
			this.SortScorersDescByLeaqueGoals.Location = new System.Drawing.Point(231, 183);
			this.SortScorersDescByLeaqueGoals.Name = "SortScorersDescByLeaqueGoals";
			this.SortScorersDescByLeaqueGoals.Size = new System.Drawing.Size(204, 40);
			this.SortScorersDescByLeaqueGoals.TabIndex = 6;
			this.SortScorersDescByLeaqueGoals.Text = "Sort scorers desc by leaques goals";
			this.SortScorersDescByLeaqueGoals.UseVisualStyleBackColor = true;
			this.SortScorersDescByLeaqueGoals.Click += new System.EventHandler(this.button7_Click);
			// 
			// SortScorersDescByNationalGoals
			// 
			this.SortScorersDescByNationalGoals.Location = new System.Drawing.Point(231, 248);
			this.SortScorersDescByNationalGoals.Name = "SortScorersDescByNationalGoals";
			this.SortScorersDescByNationalGoals.Size = new System.Drawing.Size(204, 40);
			this.SortScorersDescByNationalGoals.TabIndex = 7;
			this.SortScorersDescByNationalGoals.Text = "Sort scorers desc by national goals";
			this.SortScorersDescByNationalGoals.UseVisualStyleBackColor = true;
			this.SortScorersDescByNationalGoals.Click += new System.EventHandler(this.button8_Click);
			// 
			// Scorers50CHL
			// 
			this.Scorers50CHL.Location = new System.Drawing.Point(493, 21);
			this.Scorers50CHL.Name = "Scorers50CHL";
			this.Scorers50CHL.Size = new System.Drawing.Size(185, 51);
			this.Scorers50CHL.TabIndex = 8;
			this.Scorers50CHL.Text = "scorers with  min. 50 goals in champions leaque";
			this.Scorers50CHL.UseVisualStyleBackColor = true;
			this.Scorers50CHL.Click += new System.EventHandler(this.button9_Click);
			// 
			// Scorers50National
			// 
			this.Scorers50National.Location = new System.Drawing.Point(493, 102);
			this.Scorers50National.Name = "Scorers50National";
			this.Scorers50National.Size = new System.Drawing.Size(185, 51);
			this.Scorers50National.TabIndex = 9;
			this.Scorers50National.Text = "scorers with  min. 50 goals in national representation";
			this.Scorers50National.UseVisualStyleBackColor = true;
			this.Scorers50National.Click += new System.EventHandler(this.button10_Click);
			// 
			// Scorers500Leaques
			// 
			this.Scorers500Leaques.Location = new System.Drawing.Point(493, 183);
			this.Scorers500Leaques.Name = "Scorers500Leaques";
			this.Scorers500Leaques.Size = new System.Drawing.Size(185, 51);
			this.Scorers500Leaques.TabIndex = 10;
			this.Scorers500Leaques.Text = "scorers with  min. 500 goals in  leaques";
			this.Scorers500Leaques.UseVisualStyleBackColor = true;
			this.Scorers500Leaques.Click += new System.EventHandler(this.button11_Click);
			// 
			// AddGoals
			// 
			this.AddGoals.Location = new System.Drawing.Point(494, 257);
			this.AddGoals.Name = "AddGoals";
			this.AddGoals.Size = new System.Drawing.Size(183, 30);
			this.AddGoals.TabIndex = 11;
			this.AddGoals.Text = "Add next goals";
			this.AddGoals.UseVisualStyleBackColor = true;
			this.AddGoals.Click += new System.EventHandler(this.button12_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AddGoals);
			this.Controls.Add(this.Scorers500Leaques);
			this.Controls.Add(this.Scorers50National);
			this.Controls.Add(this.Scorers50CHL);
			this.Controls.Add(this.SortScorersDescByNationalGoals);
			this.Controls.Add(this.SortScorersDescByLeaqueGoals);
			this.Controls.Add(this.SortScorersDescByChlGoals);
			this.Controls.Add(this.SortScorersDescByTotalGoals);
			this.Controls.Add(this.ShowScorer);
			this.Controls.Add(this.RemoveScorer);
			this.Controls.Add(this.ScorersList);
			this.Controls.Add(this.Addscorer);
			this.Name = "Form1";
			this.Text = "The best scorers";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Addscorer;
		private System.Windows.Forms.Button ScorersList;
		private System.Windows.Forms.Button RemoveScorer;
		private System.Windows.Forms.Button ShowScorer;
		private System.Windows.Forms.Button SortScorersDescByTotalGoals;
		private System.Windows.Forms.Button SortScorersDescByChlGoals;
		private System.Windows.Forms.Button SortScorersDescByLeaqueGoals;
		private System.Windows.Forms.Button SortScorersDescByNationalGoals;
		private System.Windows.Forms.Button Scorers50CHL;
		private System.Windows.Forms.Button Scorers50National;
		private System.Windows.Forms.Button Scorers500Leaques;
		private System.Windows.Forms.Button AddGoals;
	}
}

