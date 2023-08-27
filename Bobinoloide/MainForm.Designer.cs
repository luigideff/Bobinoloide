namespace Bobinoloide
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.startButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.keysLabel = new System.Windows.Forms.Label();
			this.keysTextBox = new System.Windows.Forms.TextBox();
			this.statusLabel = new System.Windows.Forms.Label();
			this.intervalBox = new System.Windows.Forms.TextBox();
			this.intervalLabel = new System.Windows.Forms.Label();
			this.seqKey1 = new System.Windows.Forms.TextBox();
			this.seqInt1 = new System.Windows.Forms.TextBox();
			this.randomizer = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.seqKey2 = new System.Windows.Forms.TextBox();
			this.seqInt2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.seqKey3 = new System.Windows.Forms.TextBox();
			this.seqInt3 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.seqKey4 = new System.Windows.Forms.TextBox();
			this.seqKey5 = new System.Windows.Forms.TextBox();
			this.seqKey6 = new System.Windows.Forms.TextBox();
			this.seqInt4 = new System.Windows.Forms.TextBox();
			this.seqInt5 = new System.Windows.Forms.TextBox();
			this.seqInt6 = new System.Windows.Forms.TextBox();
			this.clearBtn = new System.Windows.Forms.Button();
			this.intervalRange = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(131, 262);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 15;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(224, 262);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(75, 23);
			this.stopButton.TabIndex = 16;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// keysLabel
			// 
			this.keysLabel.AutoSize = true;
			this.keysLabel.Location = new System.Drawing.Point(159, 26);
			this.keysLabel.Name = "keysLabel";
			this.keysLabel.Size = new System.Drawing.Size(33, 15);
			this.keysLabel.TabIndex = 10;
			this.keysLabel.Text = "Keys";
			// 
			// keysTextBox
			// 
			this.keysTextBox.Location = new System.Drawing.Point(135, 49);
			this.keysTextBox.Name = "keysTextBox";
			this.keysTextBox.Size = new System.Drawing.Size(76, 20);
			this.keysTextBox.TabIndex = 1;
			this.keysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLabel.Location = new System.Drawing.Point(63, 266);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(56, 18);
			this.statusLabel.TabIndex = 6;
			this.statusLabel.Text = "Status";
			// 
			// intervalBox
			// 
			this.intervalBox.Location = new System.Drawing.Point(228, 49);
			this.intervalBox.Name = "intervalBox";
			this.intervalBox.Size = new System.Drawing.Size(76, 20);
			this.intervalBox.TabIndex = 2;
			this.intervalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// intervalLabel
			// 
			this.intervalLabel.AutoSize = true;
			this.intervalLabel.Location = new System.Drawing.Point(231, 26);
			this.intervalLabel.Name = "intervalLabel";
			this.intervalLabel.Size = new System.Drawing.Size(74, 15);
			this.intervalLabel.TabIndex = 11;
			this.intervalLabel.Text = "Interval (ms)";
			// 
			// seqKey1
			// 
			this.seqKey1.Location = new System.Drawing.Point(26, 183);
			this.seqKey1.Name = "seqKey1";
			this.seqKey1.Size = new System.Drawing.Size(42, 20);
			this.seqKey1.TabIndex = 3;
			this.seqKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// seqInt1
			// 
			this.seqInt1.Location = new System.Drawing.Point(82, 183);
			this.seqInt1.Name = "seqInt1";
			this.seqInt1.Size = new System.Drawing.Size(58, 20);
			this.seqInt1.TabIndex = 4;
			this.seqInt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// randomizer
			// 
			this.randomizer.AutoSize = true;
			this.randomizer.Checked = true;
			this.randomizer.CheckState = System.Windows.Forms.CheckState.Checked;
			this.randomizer.Location = new System.Drawing.Point(261, 92);
			this.randomizer.Margin = new System.Windows.Forms.Padding(2);
			this.randomizer.Name = "randomizer";
			this.randomizer.Size = new System.Drawing.Size(97, 19);
			this.randomizer.TabIndex = 99;
			this.randomizer.Text = "Randomizer";
			this.randomizer.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(125, 128);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 18);
			this.label1.TabIndex = 13;
			this.label1.Text = "Sequential (key/interval)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "Key";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(91, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 15);
			this.label3.TabIndex = 11;
			this.label3.Text = "Interval";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(165, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Key";
			// 
			// seqKey2
			// 
			this.seqKey2.Location = new System.Drawing.Point(155, 183);
			this.seqKey2.Name = "seqKey2";
			this.seqKey2.Size = new System.Drawing.Size(42, 20);
			this.seqKey2.TabIndex = 5;
			this.seqKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// seqInt2
			// 
			this.seqInt2.Location = new System.Drawing.Point(212, 183);
			this.seqInt2.Name = "seqInt2";
			this.seqInt2.Size = new System.Drawing.Size(58, 20);
			this.seqInt2.TabIndex = 6;
			this.seqInt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(220, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "Interval";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(297, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "Key";
			// 
			// seqKey3
			// 
			this.seqKey3.Location = new System.Drawing.Point(287, 183);
			this.seqKey3.Name = "seqKey3";
			this.seqKey3.Size = new System.Drawing.Size(42, 20);
			this.seqKey3.TabIndex = 7;
			this.seqKey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// seqInt3
			// 
			this.seqInt3.Location = new System.Drawing.Point(344, 183);
			this.seqInt3.Name = "seqInt3";
			this.seqInt3.Size = new System.Drawing.Size(58, 20);
			this.seqInt3.TabIndex = 8;
			this.seqInt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(352, 163);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 15);
			this.label7.TabIndex = 11;
			this.label7.Text = "Interval";
			// 
			// seqKey4
			// 
			this.seqKey4.Location = new System.Drawing.Point(26, 211);
			this.seqKey4.Name = "seqKey4";
			this.seqKey4.Size = new System.Drawing.Size(42, 20);
			this.seqKey4.TabIndex = 9;
			this.seqKey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// seqKey5
			// 
			this.seqKey5.Location = new System.Drawing.Point(155, 211);
			this.seqKey5.Name = "seqKey5";
			this.seqKey5.Size = new System.Drawing.Size(42, 20);
			this.seqKey5.TabIndex = 11;
			this.seqKey5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// seqKey6
			// 
			this.seqKey6.Location = new System.Drawing.Point(287, 211);
			this.seqKey6.Name = "seqKey6";
			this.seqKey6.Size = new System.Drawing.Size(42, 20);
			this.seqKey6.TabIndex = 13;
			this.seqKey6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// seqInt4
			// 
			this.seqInt4.Location = new System.Drawing.Point(82, 211);
			this.seqInt4.Name = "seqInt4";
			this.seqInt4.Size = new System.Drawing.Size(58, 20);
			this.seqInt4.TabIndex = 10;
			this.seqInt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// seqInt5
			// 
			this.seqInt5.Location = new System.Drawing.Point(212, 211);
			this.seqInt5.Name = "seqInt5";
			this.seqInt5.Size = new System.Drawing.Size(58, 20);
			this.seqInt5.TabIndex = 12;
			this.seqInt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// seqInt6
			// 
			this.seqInt6.Location = new System.Drawing.Point(344, 211);
			this.seqInt6.Name = "seqInt6";
			this.seqInt6.Size = new System.Drawing.Size(58, 20);
			this.seqInt6.TabIndex = 14;
			this.seqInt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// clearBtn
			// 
			this.clearBtn.Location = new System.Drawing.Point(323, 262);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(75, 23);
			this.clearBtn.TabIndex = 17;
			this.clearBtn.Text = "Clear All";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// intervalRange
			// 
			this.intervalRange.Location = new System.Drawing.Point(184, 91);
			this.intervalRange.Name = "intervalRange";
			this.intervalRange.Size = new System.Drawing.Size(56, 20);
			this.intervalRange.TabIndex = 100;
			this.intervalRange.Text = "50";
			this.intervalRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(86, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 15);
			this.label8.TabIndex = 10;
			this.label8.Text = "Interval Range";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 306);
			this.Controls.Add(this.intervalRange);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.randomizer);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.intervalLabel);
			this.Controls.Add(this.seqInt6);
			this.Controls.Add(this.seqInt3);
			this.Controls.Add(this.seqInt5);
			this.Controls.Add(this.seqInt2);
			this.Controls.Add(this.seqInt4);
			this.Controls.Add(this.seqInt1);
			this.Controls.Add(this.intervalBox);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.seqKey6);
			this.Controls.Add(this.seqKey3);
			this.Controls.Add(this.seqKey5);
			this.Controls.Add(this.seqKey2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.seqKey4);
			this.Controls.Add(this.seqKey1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.keysTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.keysLabel);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.startButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bobinoloide";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Label keysLabel;
		private System.Windows.Forms.TextBox keysTextBox;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.TextBox intervalBox;
		private System.Windows.Forms.Label intervalLabel;
		private System.Windows.Forms.TextBox seqKey1;
		private System.Windows.Forms.TextBox seqInt1;
		private System.Windows.Forms.CheckBox randomizer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox seqKey2;
		private System.Windows.Forms.TextBox seqInt2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox seqKey3;
		private System.Windows.Forms.TextBox seqInt3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox seqKey4;
		private System.Windows.Forms.TextBox seqKey5;
		private System.Windows.Forms.TextBox seqKey6;
		private System.Windows.Forms.TextBox seqInt4;
		private System.Windows.Forms.TextBox seqInt5;
		private System.Windows.Forms.TextBox seqInt6;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.TextBox intervalRange;
		private System.Windows.Forms.Label label8;
	}
}

