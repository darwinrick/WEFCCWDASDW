/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/10/2023
 * Time: 2:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cafemanage
{
	/// <summary>
	/// Description of ItemForm.
	/// </summary>
	public partial class ItemForm : Form
	{
		public ItemForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ItemGVCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm login = new MainForm();
			login.Show();
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Hide();
			UserOrder order = new UserOrder();
			order.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
			UserForm uform = new UserForm();
			uform.Show();
		}
	}
}
