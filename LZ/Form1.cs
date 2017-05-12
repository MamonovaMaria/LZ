using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZ
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e)
		{
			char[] arr = textBox.Text.ToCharArray();
			string res = arr[0].ToString();
			for(int i = 1; i < arr.Length; i++)
			{
				int j = 0;
				int k = 0;
				int m = 0;

				for (j = 0; j < i; j++)
				{
					for (int t = 0; t < i - j; t++)
					{
						if (j+t < arr.Length && i+t < arr.Length && arr[j + t] == arr[i + t])
						{
							k = t;
							m = i - j;
						}
						else break;
					}
					if (k >= 1)
						break;
				}

				if (k <= 1)
					res += arr[i];
				else
					res += "(-" + m + "," + (k+1) + ")";
				i = i + k;
			}
			result.Text = res;
		}
	}
}

