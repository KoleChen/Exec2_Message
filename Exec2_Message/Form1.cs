using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			TimeLabel.Text = string.Empty;
			GreetLabel.Text = string.Empty;
		}

		
		
		private void TimeButton_Click(object sender, EventArgs e)
		{
			DateTime time = DateTime.Now;//取得現在時間的小時數

			int hour = Convert.ToInt32(time.Hour);//將現在時間的小時取出來轉換成Int 再設條件
			if (0 <= hour && hour < 12)
			{
				GreetLabel.Text = ("早安");
			}
			else if (12 <= hour && hour < 18)
			{
				GreetLabel.Text = ("午安");
			}
			else
			{
				GreetLabel.Text =("晚安");
			}

			TimeLabel.Text = ($"現在時間是{time:yyyy/MM/dd HH:mm:ss}");
		}

		

		
	}
}
