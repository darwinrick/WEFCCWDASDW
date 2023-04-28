/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/10/2023
 * Time: 3:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace cafemanage
{
	/// <summary>
	/// Description of UserForm.
	/// </summary>
	public partial class UserForm : Form
	{
		
		MySqlConnection Conn;
    	string connstring = "server=127.0.0.1;port=3306;database=cafedb;uid='root';password=''";
		
		public UserForm()
		{
			Conn = new MySqlConnection(connstring);
			InitializeComponent();
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Hide();
			UserOrder uorder = new UserOrder();
			uorder.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
			ItemForm item = new ItemForm();
			item.Show();
		}
		void Label2Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm login = new MainForm();
			login.Show();
		}
		
		void populate()
		{
			
			Conn.Open();
			
			string Query = "SELECT * FROM userstbl";
			MySqlDataAdapter sda = new MySqlDataAdapter(Query, Conn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			UsersGV.DataSource = ds.Tables[0];
			
			Conn.Close();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			Conn.Open();
			string Query = "INSERT into userstbl values('"+UnameTb.Text+"','"+UphoneTb.Text+"','"+UpassTb.Text+"')";
			
			MySqlCommand cmd = new MySqlCommand(Query, Conn);
			cmd.Parameters.AddWithValue("@Uname", UnameTb.Text);
   	 		cmd.Parameters.AddWithValue("@Uphone", UphoneTb.Text);
        	cmd.Parameters.AddWithValue("@Upass", UpassTb.Text);
        	cmd.ExecuteNonQuery();
        	
			MessageBox.Show("User Successfully Created!");
			Conn.Close();
		}
		void UserFormLoad(object sender, EventArgs e)
		{
			populate();
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
