using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BIS_Lab6 {
	public partial class Form1 : Form {
		

		public Form1() {
			InitializeComponent();

			{
				int dim = 4;
				int[] arr = new [] {
					 7, 12,  1, 14,
					 2, 13,  8, 11,
					16,  3, 10,  5,
					 9,  6, 15,  4
				};
				string message = "ВРЕМЕНА МЕНЯЮТСЯ";

				Debug.Assert(arr.Length == dim*dim);
				Debug.Assert(message.Length == dim*dim);

				var sb = new StringBuilder();
				for(var i = 0; i < dim*dim; i++) {
					sb.Append(message[arr[i] - 1]);
				}
				var result = sb.ToString();


				var squares = new Control[dim*dim];

				msgPanel.SuspendLayout();
				Program.clearTable(msgPanel);

				for(var i = 0; i < dim*dim; i++) {
					var it = new Label();
					it.Text = message[i].ToString();
					it.AutoSize = true;
					var j = i;
					it.MouseEnter += (a, b) => squares[j].ForeColor = Color.Red;
					it.MouseLeave += (a, b) => squares[j].ForeColor = SystemColors.ControlText;

					msgPanel.Controls.Add(it, i, 0);
					msgPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
					msgPanel.ColumnCount++;
				}

				msgPanel.ResumeLayout(false);
				msgPanel.PerformLayout();


				squarePanel.SuspendLayout();
				Program.clearTable(squarePanel);

				for(var i = 0; i < dim; i++) {
					squarePanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
					squarePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				}
				squarePanel.ColumnCount = dim;
				squarePanel.RowCount = dim;

				for(var i = 0; i < dim*dim; i++) {
					var it = new Label();
					it.Text = arr[i].ToString();
					it.AutoSize = true;
					it.Font = new Font(it.Font.FontFamily, 16, it.Font.Style, GraphicsUnit.Point, it.Font.GdiCharSet);

					squarePanel.Controls.Add(it, i % dim, i / dim);
					squares[arr[i] - 1] = it;
				}

				squarePanel.ResumeLayout(false);
				squarePanel.PerformLayout();

				resultLabel.Text = result;
			}

			{
				var dim = 3;
				var arr = new [] {
					6, 1, 8,
					7, 5, 3,
					2, 9, 4,
				};
				var message = "ЕВИНЖРЫЕА";


				Debug.Assert(arr.Length == dim*dim);
				Debug.Assert(message.Length == dim*dim);

				var sb = new StringBuilder(dim*dim);
				for(var i = 0; i < dim*dim; i++) sb.Append('\0');
				for(var i = 0; i < dim*dim; i++) {
					sb[arr[i] - 1] = message[i];
				}
				var result = sb.ToString();

				var squares = new Control[dim*dim];

				msgLabel2.Text = message;

				squarePanel2.SuspendLayout();
				Program.clearTable(squarePanel2);

				for(var i = 0; i < dim; i++) {
					squarePanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
					squarePanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				}
				squarePanel2.ColumnCount = dim;
				squarePanel2.RowCount = dim;

				for(var i = 0; i < dim*dim; i++) {
					var it = new Label();
					it.Text = arr[i].ToString();
					it.AutoSize = true;
					it.Font = new Font(it.Font.FontFamily, 16, it.Font.Style, GraphicsUnit.Point, it.Font.GdiCharSet);

					squarePanel2.Controls.Add(it, i % dim, i / dim);
					squares[arr[i] - 1] = it;
				}

				squarePanel2.ResumeLayout(false);
				squarePanel2.PerformLayout();

				resultPanel2.SuspendLayout();
				Program.clearTable(resultPanel2);

				for(var i = 0; i < dim*dim; i++) {
					var it = new Label();
					it.Text = result[i].ToString();
					it.AutoSize = true;
					var j = i;
					it.MouseEnter += (a, b) => squares[j].ForeColor = Color.Red;
					it.MouseLeave += (a, b) => squares[j].ForeColor = SystemColors.ControlText;

					resultPanel2.Controls.Add(it, i, 0);
					resultPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
					resultPanel2.ColumnCount++;
				}

				resultPanel2.ResumeLayout(false);
				resultPanel2.PerformLayout();
			}
		}
	}
}
