using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cafemanage
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Label4Click(object sender, EventArgs e)
		{
			this.Hide();
			GuestOrder guest = new GuestOrder();
			guest.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		void Button1Enter(object sender, EventArgs e)
		{
			
		}
	}
}
