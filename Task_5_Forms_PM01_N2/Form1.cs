using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5_Forms_PM01_N2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		double f(double x)
		{
			try
			{
				if (x == 2)
				{
					throw new Exception();
				}
				else
				{
					return Math.Log(Math.Abs(x - 2));
				}
			}
			catch
			{
				throw;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBox1.Text);
				double b = double.Parse(textBox2.Text);
				double h = double.Parse(textBox3.Text);
				textBox4.Text = "";
				for (double i = a; i <= b; i += h)
				{
					try
					{
						textBox4.Text += string.Format("y({0}) = {1:f4}\r\n", i, f(i));
					}
					catch
					{
						textBox4.Text += string.Format("y({0}) = не существует\r\n", i);
					}
				}
			}
			catch(FormatException)
			{
				textBox4.Text = string.Format("Введены неверные данные");
			}
			catch
			{
				textBox4.Text = string.Format("Ошибка");
			}
		}	
	}
}
