
namespace W14_Praktikum_Ryan_Gunawan_0706022110024
{
	partial class FormDataTeam
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
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_NamaTim = new System.Windows.Forms.Label();
			this.lbl_NamaManager = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl_NamaStadium = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_TopSkor = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbl_Pelanggaran = new System.Windows.Forms.Label();
			this.btn_Last = new System.Windows.Forms.Button();
			this.btn_Next = new System.Windows.Forms.Button();
			this.btn_Prev = new System.Windows.Forms.Button();
			this.btn_First = new System.Windows.Forms.Button();
			this.dgv_MatchDate = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_MatchDate)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Team Name :";
			// 
			// lbl_NamaTim
			// 
			this.lbl_NamaTim.AutoSize = true;
			this.lbl_NamaTim.Location = new System.Drawing.Point(161, 95);
			this.lbl_NamaTim.Name = "lbl_NamaTim";
			this.lbl_NamaTim.Size = new System.Drawing.Size(0, 17);
			this.lbl_NamaTim.TabIndex = 1;
			// 
			// lbl_NamaManager
			// 
			this.lbl_NamaManager.AutoSize = true;
			this.lbl_NamaManager.Location = new System.Drawing.Point(160, 122);
			this.lbl_NamaManager.Name = "lbl_NamaManager";
			this.lbl_NamaManager.Size = new System.Drawing.Size(0, 17);
			this.lbl_NamaManager.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Manager :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(88, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Stadium :";
			// 
			// lbl_NamaStadium
			// 
			this.lbl_NamaStadium.AutoSize = true;
			this.lbl_NamaStadium.Location = new System.Drawing.Point(161, 153);
			this.lbl_NamaStadium.Name = "lbl_NamaStadium";
			this.lbl_NamaStadium.Size = new System.Drawing.Size(0, 17);
			this.lbl_NamaStadium.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(68, 183);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Top Scorer :";
			// 
			// lbl_TopSkor
			// 
			this.lbl_TopSkor.AutoSize = true;
			this.lbl_TopSkor.Location = new System.Drawing.Point(161, 183);
			this.lbl_TopSkor.Name = "lbl_TopSkor";
			this.lbl_TopSkor.Size = new System.Drawing.Size(0, 17);
			this.lbl_TopSkor.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(38, 210);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(117, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "Worst Discipline :";
			// 
			// lbl_Pelanggaran
			// 
			this.lbl_Pelanggaran.AutoSize = true;
			this.lbl_Pelanggaran.Location = new System.Drawing.Point(161, 210);
			this.lbl_Pelanggaran.Name = "lbl_Pelanggaran";
			this.lbl_Pelanggaran.Size = new System.Drawing.Size(0, 17);
			this.lbl_Pelanggaran.TabIndex = 9;
			// 
			// btn_Last
			// 
			this.btn_Last.Location = new System.Drawing.Point(225, 13);
			this.btn_Last.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Last.Name = "btn_Last";
			this.btn_Last.Size = new System.Drawing.Size(54, 47);
			this.btn_Last.TabIndex = 59;
			this.btn_Last.Text = ">>";
			this.btn_Last.UseVisualStyleBackColor = true;
			this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
			// 
			// btn_Next
			// 
			this.btn_Next.Location = new System.Drawing.Point(163, 13);
			this.btn_Next.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Next.Name = "btn_Next";
			this.btn_Next.Size = new System.Drawing.Size(54, 47);
			this.btn_Next.TabIndex = 58;
			this.btn_Next.Text = ">";
			this.btn_Next.UseVisualStyleBackColor = true;
			this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
			// 
			// btn_Prev
			// 
			this.btn_Prev.Location = new System.Drawing.Point(101, 13);
			this.btn_Prev.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Prev.Name = "btn_Prev";
			this.btn_Prev.Size = new System.Drawing.Size(54, 47);
			this.btn_Prev.TabIndex = 57;
			this.btn_Prev.Text = "<";
			this.btn_Prev.UseVisualStyleBackColor = true;
			this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
			// 
			// btn_First
			// 
			this.btn_First.Location = new System.Drawing.Point(39, 13);
			this.btn_First.Margin = new System.Windows.Forms.Padding(4);
			this.btn_First.Name = "btn_First";
			this.btn_First.Size = new System.Drawing.Size(54, 47);
			this.btn_First.TabIndex = 56;
			this.btn_First.Text = "<<";
			this.btn_First.UseVisualStyleBackColor = true;
			this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
			// 
			// dgv_MatchDate
			// 
			this.dgv_MatchDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_MatchDate.Location = new System.Drawing.Point(13, 254);
			this.dgv_MatchDate.Name = "dgv_MatchDate";
			this.dgv_MatchDate.RowHeadersWidth = 51;
			this.dgv_MatchDate.RowTemplate.Height = 24;
			this.dgv_MatchDate.Size = new System.Drawing.Size(775, 233);
			this.dgv_MatchDate.TabIndex = 60;
			// 
			// FormDataTeam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 499);
			this.Controls.Add(this.dgv_MatchDate);
			this.Controls.Add(this.btn_Last);
			this.Controls.Add(this.btn_Next);
			this.Controls.Add(this.btn_Prev);
			this.Controls.Add(this.btn_First);
			this.Controls.Add(this.lbl_Pelanggaran);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lbl_TopSkor);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lbl_NamaStadium);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbl_NamaManager);
			this.Controls.Add(this.lbl_NamaTim);
			this.Controls.Add(this.label1);
			this.Name = "FormDataTeam";
			this.Text = "Team";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_MatchDate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_NamaTim;
		private System.Windows.Forms.Label lbl_NamaManager;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl_NamaStadium;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_TopSkor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbl_Pelanggaran;
		private System.Windows.Forms.Button btn_Last;
		private System.Windows.Forms.Button btn_Next;
		private System.Windows.Forms.Button btn_Prev;
		private System.Windows.Forms.Button btn_First;
		private System.Windows.Forms.DataGridView dgv_MatchDate;
	}
}

