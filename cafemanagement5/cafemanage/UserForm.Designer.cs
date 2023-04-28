/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/10/2023
 * Time: 3:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafemanage
{
	partial class UserForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox UpassTb;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox UphoneTb;
		private System.Windows.Forms.DataGridView UsersGV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox UnameTb;
		private System.Windows.Forms.Panel panel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UpassTb = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.UphoneTb = new System.Windows.Forms.TextBox();
			this.UsersGV = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.UnameTb = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.LightCoral;
			this.label2.Font = new System.Drawing.Font("Nova Square", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 560);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 32);
			this.label2.TabIndex = 23;
			this.label2.Text = "LogOut";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightCoral;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Nova Square", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(208, 360);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 32);
			this.button5.TabIndex = 18;
			this.button5.Text = "DELETE";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightCoral;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Nova Square", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(112, 360);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 32);
			this.button2.TabIndex = 17;
			this.button2.Text = "EDIT";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.LightGray;
			this.label6.Font = new System.Drawing.Font("Nova Square", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.LightCoral;
			this.label6.Location = new System.Drawing.Point(472, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(200, 40);
			this.label6.TabIndex = 16;
			this.label6.Text = "USERS LIST";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.LightGray;
			this.label5.Font = new System.Drawing.Font("Nova Square", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.LightCoral;
			this.label5.Location = new System.Drawing.Point(16, 280);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 24);
			this.label5.TabIndex = 15;
			this.label5.Text = "PASSWORD";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LightGray;
			this.label4.Font = new System.Drawing.Font("Nova Square", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.LightCoral;
			this.label4.Location = new System.Drawing.Point(16, 240);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 24);
			this.label4.TabIndex = 14;
			this.label4.Text = "PHONE";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.LightGray;
			this.label3.Font = new System.Drawing.Font("Nova Square", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.LightCoral;
			this.label3.Location = new System.Drawing.Point(16, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 24);
			this.label3.TabIndex = 13;
			this.label3.Text = "USERNAME";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UpassTb
			// 
			this.UpassTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UpassTb.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold);
			this.UpassTb.ForeColor = System.Drawing.Color.LightCoral;
			this.UpassTb.Location = new System.Drawing.Point(152, 280);
			this.UpassTb.Name = "UpassTb";
			this.UpassTb.Size = new System.Drawing.Size(136, 23);
			this.UpassTb.TabIndex = 12;
			this.UpassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Nova Square", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.LightCoral;
			this.button4.Location = new System.Drawing.Point(8, 176);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(88, 48);
			this.button4.TabIndex = 24;
			this.button4.Text = "ITEMS";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Nova Square", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.LightCoral;
			this.button3.Location = new System.Drawing.Point(8, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 48);
			this.button3.TabIndex = 22;
			this.button3.Text = "ORDER";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightCoral;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Nova Square", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(16, 360);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "ADD";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// UphoneTb
			// 
			this.UphoneTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UphoneTb.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold);
			this.UphoneTb.ForeColor = System.Drawing.Color.LightCoral;
			this.UphoneTb.Location = new System.Drawing.Point(152, 240);
			this.UphoneTb.Name = "UphoneTb";
			this.UphoneTb.Size = new System.Drawing.Size(136, 23);
			this.UphoneTb.TabIndex = 6;
			this.UphoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// UsersGV
			// 
			this.UsersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.UsersGV.BackgroundColor = System.Drawing.Color.White;
			this.UsersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UsersGV.EnableHeadersVisualStyles = false;
			this.UsersGV.GridColor = System.Drawing.Color.LightSalmon;
			this.UsersGV.Location = new System.Drawing.Point(336, 128);
			this.UsersGV.Name = "UsersGV";
			this.UsersGV.RowHeadersVisible = false;
			this.UsersGV.Size = new System.Drawing.Size(472, 408);
			this.UsersGV.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LightGray;
			this.label1.Font = new System.Drawing.Font("Nova Square", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightCoral;
			this.label1.Location = new System.Drawing.Point(312, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "MANAGE USER";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(896, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// UnameTb
			// 
			this.UnameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UnameTb.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold);
			this.UnameTb.ForeColor = System.Drawing.Color.LightCoral;
			this.UnameTb.Location = new System.Drawing.Point(152, 200);
			this.UnameTb.Name = "UnameTb";
			this.UnameTb.Size = new System.Drawing.Size(136, 23);
			this.UnameTb.TabIndex = 5;
			this.UnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.UpassTb);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.UphoneTb);
			this.panel1.Controls.Add(this.UnameTb);
			this.panel1.Controls.Add(this.UsersGV);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(104, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(824, 560);
			this.panel1.TabIndex = 20;
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCoral;
			this.ClientSize = new System.Drawing.Size(945, 611);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserForm";
			this.Load += new System.EventHandler(this.UserFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
