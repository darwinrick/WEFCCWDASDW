/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/10/2023
 * Time: 2:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafemanage
{
	partial class UserOrder
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView ItemGV;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrder));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ItemGV = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.ItemGV);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(104, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(824, 560);
			this.panel1.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox3.ForeColor = System.Drawing.Color.LightCoral;
			this.textBox3.Location = new System.Drawing.Point(32, 176);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(136, 23);
			this.textBox3.TabIndex = 12;
			this.textBox3.Text = "Quantity";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightCoral;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Nova Square", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(448, 520);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 32);
			this.button2.TabIndex = 11;
			this.button2.Text = "PLACE THE ORDER";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.LightGray;
			this.label3.Font = new System.Drawing.Font("Nova Square", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.LightCoral;
			this.label3.Location = new System.Drawing.Point(368, 248);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 40);
			this.label3.TabIndex = 10;
			this.label3.Text = "YOUR ORDER";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(192, 288);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(608, 222);
			this.dataGridView1.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.LightGray;
			this.label2.Font = new System.Drawing.Font("Nova Square", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LightCoral;
			this.label2.Location = new System.Drawing.Point(600, 520);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 32);
			this.label2.TabIndex = 8;
			this.label2.Text = "ORDER AMOUNT";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightCoral;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Nova Square", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(32, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "ADD TO CART";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox2.ForeColor = System.Drawing.Color.LightCoral;
			this.textBox2.Location = new System.Drawing.Point(32, 144);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(136, 23);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "SellerName";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold);
			this.textBox1.ForeColor = System.Drawing.Color.LightCoral;
			this.textBox1.Location = new System.Drawing.Point(32, 112);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(136, 23);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "OrderNum";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ItemGV
			// 
			this.ItemGV.BackgroundColor = System.Drawing.Color.White;
			this.ItemGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemGV.Location = new System.Drawing.Point(192, 72);
			this.ItemGV.Name = "ItemGV";
			this.ItemGV.Size = new System.Drawing.Size(608, 150);
			this.ItemGV.TabIndex = 4;
			// 
			// comboBox1
			// 
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox1.Font = new System.Drawing.Font("News Cycle", 11.25F, System.Drawing.FontStyle.Bold);
			this.comboBox1.ForeColor = System.Drawing.Color.LightCoral;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Food",
			"Drinks",
			"Beverages",
			"Desserts"});
			this.comboBox1.Location = new System.Drawing.Point(32, 72);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(136, 30);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "Category";
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
			this.label1.Text = "PLACE ORDER";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(896, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
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
			this.button3.TabIndex = 14;
			this.button3.Text = "ITEM";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
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
			this.button4.TabIndex = 15;
			this.button4.Text = "USER";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LightCoral;
			this.label4.Font = new System.Drawing.Font("Nova Square", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(0, 560);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 32);
			this.label4.TabIndex = 16;
			this.label4.Text = "LogOut";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// UserOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCoral;
			this.ClientSize = new System.Drawing.Size(945, 611);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserOrder";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
