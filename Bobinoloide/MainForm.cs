using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Interceptor;
using System.ComponentModel;
using System.Linq;

namespace Bobinoloide
{
	public partial class MainForm : Form
	{
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		[DllImport("user32.dll")]
		private static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder lpString, int nMaxCount);

		private Process targetProcess = Process.GetProcessesByName("Bobinoloide").FirstOrDefault();
		private string targetWindowTitle = "Bobinoloide";
		private Input input = new Input();
		private BackgroundWorker backgroundWorker1;
		private BackgroundWorker backgroundWorker2;
		private bool started = false;

		private int intervalTimeInt = int.MinValue;
		private int seqIntervalInt_1 = int.MinValue;
		private int seqIntervalInt_2 = int.MinValue;
		private int seqIntervalInt_3 = int.MinValue;
		private int seqIntervalInt_4 = int.MinValue;
		private int seqIntervalInt_5 = int.MinValue;
		private int seqIntervalInt_6 = int.MinValue;
		public MainForm()
		{
			InitializeComponent();
		}
		private void startButton_Click(object sender, EventArgs e)
		{
			StartRoutine();
		}

		private void StartRoutine()
		{
			if (string.IsNullOrEmpty(keysTextBox.Text) && string.IsNullOrEmpty(seqKey1.Text))
			{
				MessageBox.Show("Favor informar pelo menos 1 tecla.");
				return;
			}


			if (string.IsNullOrEmpty(intervalBox.Text) && string.IsNullOrEmpty(seqInt1.Text))
			{
				MessageBox.Show("Favor informar pelo menos 1 intervalo.");
				return;
			}

			ConvertToInt();

			SetComponentsStarted();

			LoadInputDriver();

			if (!string.IsNullOrEmpty(keysTextBox.Text) && !string.IsNullOrEmpty(intervalBox.Text))
			{
				backgroundWorker1 = new BackgroundWorker();
				backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
				backgroundWorker1.RunWorkerAsync();
			}

			if (!string.IsNullOrEmpty(seqKey1.Text) && !string.IsNullOrEmpty(seqInt1.Text))
			{
				backgroundWorker2 = new BackgroundWorker();
				backgroundWorker2.DoWork += BackgroundWorker2_DoWork;
				backgroundWorker2.RunWorkerAsync();
			}
		}

		private void ConvertToInt()
		{
			if (!string.IsNullOrEmpty(intervalBox.Text))
				intervalTimeInt = Convert.ToInt32(intervalBox.Text);
			if (!string.IsNullOrEmpty(seqInt1.Text))
				seqIntervalInt_1 = Convert.ToInt32(seqInt1.Text);
			if (!string.IsNullOrEmpty(seqInt2.Text))
				seqIntervalInt_2 = Convert.ToInt32(seqInt2.Text);
			if (!string.IsNullOrEmpty(seqInt3.Text))
				seqIntervalInt_3 = Convert.ToInt32(seqInt3.Text);
			if (!string.IsNullOrEmpty(seqInt4.Text))
				seqIntervalInt_4 = Convert.ToInt32(seqInt4.Text);
			if (!string.IsNullOrEmpty(seqInt5.Text))
				seqIntervalInt_5 = Convert.ToInt32(seqInt5.Text);
			if (!string.IsNullOrEmpty(seqInt6.Text))
				seqIntervalInt_6 = Convert.ToInt32(seqInt6.Text);
		}


		private void LoadInputDriver()
		{
			input.KeyboardFilterMode = KeyboardFilterMode.All;
			input.Load();
		}

		private void SetComponentsStarted()
		{
			startButton.Enabled = false;
			stopButton.Enabled = true;

			keysTextBox.Enabled = false;
			seqKey1.Enabled = false;
			seqKey2.Enabled = false;
			seqKey3.Enabled = false;
			seqKey4.Enabled = false;
			seqKey5.Enabled = false;
			seqKey6.Enabled = false;

			intervalBox.Enabled = false;
			seqInt1.Enabled = false;
			seqInt2.Enabled = false;
			seqInt3.Enabled = false;
			seqInt4.Enabled = false;
			seqInt5.Enabled = false;
			seqInt6.Enabled = false;

			statusLabel.Text = "Started";
			started = true;
		}

		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				var random = new Random();
				int range = Convert.ToInt32(intervalRange.Text);
				int minInterval = intervalTimeInt - range;
				int maxInterval = intervalTimeInt + range;

				string[] keysArray = keysTextBox.Text.Split(',');

				while (started == true)
				{
					if (randomizer.Checked)
					{
						var shuffledArray = keysArray.OrderBy(x => Guid.NewGuid()).ToArray();
						foreach (string key in shuffledArray)
						{
							intervalTimeInt = random.Next(minInterval, maxInterval);

							if (!IsWindowActive(targetProcess, targetWindowTitle))
							{
								input.SendText(key);
								Thread.Sleep(intervalTimeInt);
							}
							else
								Thread.Sleep(intervalTimeInt);
						}

					}
					else
					{
						foreach (string key in keysArray)
						{
							intervalTimeInt = random.Next(minInterval, maxInterval);

							if (!IsWindowActive(targetProcess, targetWindowTitle))
							{
								input.SendText(key);
								Thread.Sleep(intervalTimeInt);
							}
							else
								Thread.Sleep(intervalTimeInt);
						}
					}
				}

				if (started == false)
					input.Unload();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro na execução. Stacktrace: " + ex.StackTrace);
			}
		}

		private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				var random = new Random();
				int range = Convert.ToInt32(intervalRange.Text);
				int minInterval = seqIntervalInt_1 - range;
				int maxInterval = seqIntervalInt_1 + range;

				while (started == true)
				{
					if (!IsWindowActive(targetProcess, targetWindowTitle))
					{
						input.SendText(seqKey1.Text);
						Thread.Sleep(random.Next(minInterval, maxInterval));

						if (!string.IsNullOrEmpty(seqKey2.Text) && !string.IsNullOrEmpty(seqInt2.Text))
						{
							minInterval = seqIntervalInt_2 - range;
							maxInterval = seqIntervalInt_2 + range;
							input.SendText(seqKey2.Text);
							Thread.Sleep(random.Next(minInterval, maxInterval));
						}
						if (!string.IsNullOrEmpty(seqKey3.Text) && !string.IsNullOrEmpty(seqInt3.Text))
						{
							minInterval = seqIntervalInt_3 - range;
							maxInterval = seqIntervalInt_3 + range;
							input.SendText(seqKey3.Text);
							Thread.Sleep(random.Next(minInterval, maxInterval));
						}
						if (!string.IsNullOrEmpty(seqKey4.Text) && !string.IsNullOrEmpty(seqInt4.Text))
						{
							minInterval = seqIntervalInt_4 - range;
							maxInterval = seqIntervalInt_4 + range;
							input.SendText(seqKey4.Text);
							Thread.Sleep(random.Next(minInterval, maxInterval));
						}
						if (!string.IsNullOrEmpty(seqKey5.Text) && !string.IsNullOrEmpty(seqInt5.Text))
						{
							minInterval = seqIntervalInt_5 - range;
							maxInterval = seqIntervalInt_5 + range;
							input.SendText(seqKey5.Text);
							Thread.Sleep(random.Next(minInterval, maxInterval));
						}
						if (!string.IsNullOrEmpty(seqKey6.Text) && !string.IsNullOrEmpty(seqInt6.Text))
						{
							minInterval = seqIntervalInt_6 - range;
							maxInterval = seqIntervalInt_6 + range;
							input.SendText(seqKey6.Text);
							Thread.Sleep(random.Next(minInterval, maxInterval));
						}
					}
					else
						Thread.Sleep(seqIntervalInt_1);
				}

				if (started == false)
					input.Unload();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro na execução. Stacktrace: " + ex.StackTrace);
			}
		}


		private void stopButton_Click(object sender, EventArgs e)
		{
			SetComponentsStopped();
		}

		private void SetComponentsStopped()
		{
			startButton.Enabled = true;
			stopButton.Enabled = false;
			keysTextBox.Enabled = true;
			intervalBox.Enabled = true;
			seqKey1.Enabled = true;
			seqInt1.Enabled = true;

			started = false;
			statusLabel.Text = "Stopped";
		}

		private static bool IsWindowActive(Process process, string windowTitle)
		{
			IntPtr foregroundWindowHandle = GetForegroundWindow();

			if (foregroundWindowHandle != IntPtr.Zero)
			{
				uint foregroundProcessId;
				GetWindowThreadProcessId(foregroundWindowHandle, out foregroundProcessId);

				if (process.Id == foregroundProcessId)
				{
					const int maxWindowTitleLength = 256;
					var windowTitleBuilder = new System.Text.StringBuilder(maxWindowTitleLength);
					int length = GetWindowText(foregroundWindowHandle, windowTitleBuilder, maxWindowTitleLength);

					if (length > 0)
					{
						string activeWindowTitle = windowTitleBuilder.ToString().Substring(0, length);
						if (activeWindowTitle == windowTitle)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			keysTextBox.Text = string.Empty;
			seqKey1.Text = string.Empty;
			seqKey2.Text = string.Empty;
			seqKey3.Text = string.Empty;
			seqKey4.Text = string.Empty;
			seqKey5.Text = string.Empty;
			seqKey6.Text = string.Empty;

			intervalBox.Text = string.Empty;
			seqInt1.Text = string.Empty;
			seqInt2.Text = string.Empty;
			seqInt3.Text = string.Empty;
			seqInt4.Text = string.Empty;
			seqInt5.Text = string.Empty;
			seqInt6.Text = string.Empty;
		}
	}
}
