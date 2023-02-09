using System;
using System.Text;
using System.Windows.Forms;

namespace Lab7 {
	public partial class Form1 : Form {
		char[] alphabet = new[] {
			'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 
			'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 
			'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 
			'э', 'ю', 'я', 
		};

		public Form1() {
			InitializeComponent();
			offsetNUD.Minimum = -alphabet.Length;
			offsetNUD.Maximum =  alphabet.Length;
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			upd();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			upd();
		}

		private void upd() {
			var text = textTB.Text;
			var offset = (int) offsetNUD.Value;
			var alp = alphabet.Length;

			var encr = new StringBuilder(text.Length);
			var decr = new StringBuilder(text.Length);
			foreach(var ch in text) {
				if(char.IsWhiteSpace(ch)) {
					encr.Append(ch);
					decr.Append(ch);
					continue;
				}
				var index = Array.IndexOf(alphabet, char.ToLower(ch));
				if(index == -1) {
					decrL.Text = "неправильный символ `" + ch + "` в тексте";
					encrL.Text = "";
					return;
				}
				encr.Append(alphabet[((index + offset) % alp + alp) % alp]);
				decr.Append(alphabet[((index - offset) % alp + alp) % alp]);
			}
			encrL.Text = encr.ToString();
			decrL.Text = decr.ToString();
		}
	}
}
