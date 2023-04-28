/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/10/2023
 * Time: 2:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cafemanage
{
	/// <summary>
	/// Description of UserOrder.
	/// </summary>
	public partial class UserOrder : Form
	{
		public UserOrder()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label4Click(object sender, EventArgs e)
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
			ItemForm item = new ItemForm();
			item.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
			UserForm user = new UserForm();
			user.Show();
		}
	}
}
