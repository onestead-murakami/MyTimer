
using System.Windows.Forms;

namespace MyTimer {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows フォーム デザイナーで生成されたコード

		private Label label1;

		private Timer timer1;

		private Button button1;

		private Label label2;

		private Label label3;

		private Button button2;

		private Button button3;

		private Button button4;

		private Button button5;

		private Button button6;

		private TextBox textBox1;

		private Label label4;

		private Timer timer2;

		private Label label5;

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {

			components = new System.ComponentModel.Container();
			label1 = new System.Windows.Forms.Label();
			timer1 = new System.Windows.Forms.Timer(components);
			button1 = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			button2 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			textBox1 = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			timer2 = new System.Windows.Forms.Timer(components);
			label5 = new System.Windows.Forms.Label();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 144f, System.Drawing.FontStyle.Bold);
			label1.Location = new System.Drawing.Point(10, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(274, 192);
			label1.TabIndex = 1;
			label1.Text = "01";
			timer1.Interval = 1000;
			timer1.Tick += new System.EventHandler(timer1_Tick);
			button1.Location = new System.Drawing.Point(753, 19);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(46, 23);
			button1.TabIndex = 2;
			button1.Text = "↑";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click_1);
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 144f, System.Drawing.FontStyle.Bold);
			label2.Location = new System.Drawing.Point(267, 9);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(177, 192);
			label2.TabIndex = 3;
			label2.Text = ":";
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 144f, System.Drawing.FontStyle.Bold);
			label3.Location = new System.Drawing.Point(422, 9);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(274, 192);
			label3.TabIndex = 4;
			label3.Text = "10";
			button2.Location = new System.Drawing.Point(805, 19);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(46, 23);
			button2.TabIndex = 5;
			button2.Text = "↓";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button3.Location = new System.Drawing.Point(805, 64);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(46, 23);
			button3.TabIndex = 7;
			button3.Text = "↓";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(button3_Click);
			button4.Location = new System.Drawing.Point(753, 64);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(46, 23);
			button4.TabIndex = 6;
			button4.Text = "↑";
			button4.UseVisualStyleBackColor = true;
			button4.Click += new System.EventHandler(button4_Click);
			button5.Location = new System.Drawing.Point(753, 108);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(98, 24);
			button5.TabIndex = 8;
			button5.Text = "開\u3000始";
			button5.UseVisualStyleBackColor = true;
			button5.Click += new System.EventHandler(button5_Click);
			button6.Location = new System.Drawing.Point(753, 147);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(98, 24);
			button6.TabIndex = 9;
			button6.Text = "停\u3000止";
			button6.UseVisualStyleBackColor = true;
			button6.Click += new System.EventHandler(button6_Click);
			textBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 36f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
			textBox1.Location = new System.Drawing.Point(12, 213);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(839, 225);
			textBox1.TabIndex = 10;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("MS UI Gothic", 48f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
			label4.Location = new System.Drawing.Point(605, 453);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(246, 64);
			label4.TabIndex = 11;
			label4.Text = "12:12:12";
			timer2.Interval = 1000;
			timer2.Tick += new System.EventHandler(timer2_Tick);
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("MS UI Gothic", 48f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
			label5.Location = new System.Drawing.Point(327, 453);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(272, 64);
			label5.TabIndex = 12;
			label5.Text = "今の時間";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(866, 541);
			base.Controls.Add(label5);
			base.Controls.Add(label4);
			base.Controls.Add(textBox1);
			base.Controls.Add(button6);
			base.Controls.Add(button5);
			base.Controls.Add(button3);
			base.Controls.Add(button4);
			base.Controls.Add(button2);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(button1);
			base.Controls.Add(label1);
			base.Name = "Form1";
			Text = "Form1";
			base.Load += new System.EventHandler(Form1_Load);
			ResumeLayout(false);
			PerformLayout();
		}

        #endregion
    }
}

