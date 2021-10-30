using System;
using System.Windows.Forms;

namespace MyTimer {
    public partial class Form1 : Form {
		private const double ADJUST = (60 * 9) + 26.0;
		private int a = 0;


		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
		}

		private void Form1_Load(object sender, EventArgs e) {
			label4.Text = DateTime.Now.AddSeconds(ADJUST).ToString("hh:mm:ss");
			timer2.Start();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
		}

		private void button1_Click_1(object sender, EventArgs e) {
			int num = int.Parse(label1.Text);
			num = ((num != 59) ? (num + 1) : 0);
			label1.Text = $"{num:D2}";
		}

		private void button2_Click(object sender, EventArgs e) {
			int num = int.Parse(label1.Text);
			num = ((num == 0) ? 59 : (num - 1));
			label1.Text = $"{num:D2}";
		}

		private void button4_Click(object sender, EventArgs e) {
			int num = int.Parse(label3.Text);
			num = ((num != 59) ? (num + 1) : 0);
			label3.Text = $"{num:D2}";
		}

		private void button3_Click(object sender, EventArgs e) {
			int num = int.Parse(label3.Text);
			num = ((num == 0) ? 59 : (num - 1));
			label3.Text = $"{num:D2}";
		}

		private void button5_Click(object sender, EventArgs e) {
			button5.Enabled = false;
			button6.Enabled = true;
			timer1.Start();
		}

		private void button6_Click(object sender, EventArgs e) {
			button5.Enabled = true;
			button6.Enabled = false;
			timer1.Stop();
		}

		private void timer1_Tick(object sender, EventArgs e) {
			int num = int.Parse(label1.Text);
			int num2 = int.Parse(label3.Text);
			if (num == 0 && num2 == 0) {
				timer1.Stop();
				using (Form form = new Form2())
					form.ShowDialog(this);
			} else if (num2 == 0) {
				num--;
				num2 = 59;
				label1.Text = $"{num:D2}";
				label3.Text = $"{num2:D2}";
			} else {
				num2--;
				label3.Text = $"{num2:D2}";
			}
		}

		private void timer2_Tick(object sender, EventArgs e) {
			label4.Text = DateTime.Now.AddSeconds(ADJUST).ToString("hh:mm:ss");
		}

	}
}
