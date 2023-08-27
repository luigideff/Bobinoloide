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
			this.keysTextBox2 = new System.Windows.Forms.TextBox();
			this.intervalBox2 = new System.Windows.Forms.TextBox();
			this.randomizer = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(79, 165);
			this.startButton.Margin = new System.Windows.Forms.Padding(4);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(100, 28);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(203, 165);
			this.stopButton.Margin = new System.Windows.Forms.Padding(4);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(100, 28);
			this.stopButton.TabIndex = 6;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// keysLabel
			// 
			this.keysLabel.AutoSize = true;
			this.keysLabel.Location = new System.Drawing.Point(111, 37);
			this.keysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.keysLabel.Name = "keysLabel";
			this.keysLabel.Size = new System.Drawing.Size(37, 16);
			this.keysLabel.TabIndex = 10;
			this.keysLabel.Text = "Keys";
			// 
			// keysTextBox
			// 
			this.keysTextBox.Location = new System.Drawing.Point(79, 67);
			this.keysTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.keysTextBox.Name = "keysTextBox";
			this.keysTextBox.Size = new System.Drawing.Size(100, 22);
			this.keysTextBox.TabIndex = 1;
			this.keysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLabel.Location = new System.Drawing.Point(101, 217);
			this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(56, 18);
			this.statusLabel.TabIndex = 6;
			this.statusLabel.Text = "Status";
			// 
			// intervalBox
			// 
			this.intervalBox.Location = new System.Drawing.Point(203, 67);
			this.intervalBox.Margin = new System.Windows.Forms.Padding(4);
			this.intervalBox.Name = "intervalBox";
			this.intervalBox.Size = new System.Drawing.Size(100, 22);
			this.intervalBox.TabIndex = 2;
			this.intervalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// intervalLabel
			// 
			this.intervalLabel.AutoSize = true;
			this.intervalLabel.Location = new System.Drawing.Point(216, 37);
			this.intervalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.intervalLabel.Name = "intervalLabel";
			this.intervalLabel.Size = new System.Drawing.Size(79, 16);
			this.intervalLabel.TabIndex = 11;
			this.intervalLabel.Text = "Interval (ms)";
			// 
			// keysTextBox2
			// 
			this.keysTextBox2.Location = new System.Drawing.Point(79, 97);
			this.keysTextBox2.Margin = new System.Windows.Forms.Padding(4);
			this.keysTextBox2.Name = "keysTextBox2";
			this.keysTextBox2.Size = new System.Drawing.Size(100, 22);
			this.keysTextBox2.TabIndex = 3;
			this.keysTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// intervalBox2
			// 
			this.intervalBox2.Location = new System.Drawing.Point(203, 97);
			this.intervalBox2.Margin = new System.Windows.Forms.Padding(4);
			this.intervalBox2.Name = "intervalBox2";
			this.intervalBox2.Size = new System.Drawing.Size(100, 22);
			this.intervalBox2.TabIndex = 4;
			this.intervalBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// randomizer
			// 
			this.randomizer.AutoSize = true;
			this.randomizer.Location = new System.Drawing.Point(208, 215);
			this.randomizer.Name = "randomizer";
			this.randomizer.Size = new System.Drawing.Size(102, 20);
			this.randomizer.TabIndex = 12;
			this.randomizer.Text = "Randomizer";
			this.randomizer.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 256);
			this.Controls.Add(this.randomizer);
			this.Controls.Add(this.intervalLabel);
			this.Controls.Add(this.intervalBox2);
			this.Controls.Add(this.intervalBox);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.keysTextBox2);
			this.Controls.Add(this.keysTextBox);
			this.Controls.Add(this.keysLabel);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.startButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
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
		private System.Windows.Forms.TextBox keysTextBox2;
		private System.Windows.Forms.TextBox intervalBox2;
		private System.Windows.Forms.CheckBox randomizer;
	}
}

