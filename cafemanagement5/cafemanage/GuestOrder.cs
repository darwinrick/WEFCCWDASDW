using System;
using System.Drawing;
using System.Windows.Forms;

namespace cafemanage
{
	/// <summary>
	/// Description of ItemForm.
	/// </summary>
	public partial class GuestOrder : Form
	{
		public GuestOrder()
		{
			InitializeComponent();
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button2Click(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm login = new MainForm();
			login.Show();
		}
	}
}
