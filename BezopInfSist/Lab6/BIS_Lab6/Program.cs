using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BIS_Lab6 {
	static class Program {
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		public static void clearTable(TableLayoutPanel p) {
			p.Controls.Clear();
			p.ColumnCount = 0;
			p.RowCount = 0;
			p.ColumnStyles.Clear();
			p.RowStyles.Clear();
		}
	}
}
