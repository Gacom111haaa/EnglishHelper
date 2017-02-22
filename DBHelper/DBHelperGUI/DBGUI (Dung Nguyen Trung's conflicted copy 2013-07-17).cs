using DBHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBHelperGUI
{
	public partial class DBGUI : Form
	{
		IEnglishSentencesRepository target = null;
		public DBGUI()
		{
			InitializeComponent();
			if(target == null)
			{
				target = new EnglishSentencesRepository();
			}
		}

		private void DBGUI_Load(object sender, EventArgs e)
		{
			Refresh();
		}

		private void btCreate_Click(object sender, EventArgs e)
		{
			
			var actual = new EnglishSentences
			{
				Content = GenerateString(100),
				Level = new System.Random().Next(1, 1000)
			};
			target.Create(actual);
		}

		public string GenerateString(int len)
		{
			string PWD_CHARSET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVXYZ1234567890";
			if (len > 4000) len = 4000;
			var buffer = new byte[len * 2];
			new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(buffer);

			using (var stream = new System.IO.MemoryStream(buffer, 0, buffer.Length, false, false))
				using (var reader = new System.IO.BinaryReader(stream))
			{
				var builder = new System.Text.StringBuilder(buffer.Length, buffer.Length);
				while (len-- > 0)
				{
					var i = (reader.ReadUInt16() & 8) % PWD_CHARSET.Length;
					builder.Append(PWD_CHARSET[i]);
				}
				return builder.ToString();
			}
		}

		private void btRefresh_Click(object sender, EventArgs e)
		{
			Refresh();
		}

		private void btUpdate_Click(object sender, EventArgs e)
		{
			
		}

		private void btDelete_Click(object sender, EventArgs e)
		{

		}
		
		public void Refresh()
		{
			var actual = target.ToList();
			dataGridView1.DataSource = actual;
		}
	}
}
