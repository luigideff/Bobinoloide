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

		private bool started = false;
		private BackgroundWorker backgroundWorker1;
		private BackgroundWorker backgroundWorker2;
		private Process targetProcess = Process.GetProcessesByName("Bobinoloide").FirstOrDefault();
		private string targetWindowTitle = "Bobinoloide";
		private string keysText1 = string.Empty;
		private string keysText2 = string.Empty;
		private string intervalTimeText1 = string.Empty;
		private string intervalTimeText2 = string.Empty;
		private int intervalTimeInt1 = int.MinValue;
		private int intervalTimeInt2 = int.MinValue;
		private Input input = new Input();
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
			GetInputText();

			if (string.IsNullOrEmpty(keysText1) && string.IsNullOrEmpty(keysText2))
			{
				MessageBox.Show("Favor informar as teclas a serem pressionadas.");
				return;
			}


			if (string.IsNullOrEmpty(intervalTimeText1) && string.IsNullOrEmpty(intervalTimeText2))
			{
				MessageBox.Show("Favor informar o intervalo em milisegundos");
				return;
			}

			ConvertToInt();

			SetComponentsStarted();

			LoadInputDriver();

			if (!string.IsNullOrEmpty(keysText1) && !string.IsNullOrEmpty(intervalTimeText1))
			{
				backgroundWorker1 = new BackgroundWorker();
				backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
				backgroundWorker1.RunWorkerAsync();
			}

			if (!string.IsNullOrEmpty(keysText2) && !string.IsNullOrEmpty(intervalTimeText2))
			{
				backgroundWorker2 = new BackgroundWorker();
				backgroundWorker2.DoWork += BackgroundWorker2_DoWork;
				backgroundWorker2.RunWorkerAsync();
			}
		}

		private void ConvertToInt()
		{
			if (!string.IsNullOrEmpty(intervalTimeText1))
				intervalTimeInt1 = Convert.ToInt32(intervalTimeText1);
			if (!string.IsNullOrEmpty(intervalTimeText2))
				intervalTimeInt2 = Convert.ToInt32(intervalTimeText2);
		}

		private void GetInputText()
		{
			keysText1 = keysTextBox.Text.Trim();
			keysText2 = keysTextBox2.Text.Trim();
			intervalTimeText1 = intervalBox.Text.Trim();
			intervalTimeText2 = intervalBox2.Text.Trim();
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
			intervalBox.Enabled = false;
			keysTextBox2.Enabled = false;
			intervalBox2.Enabled = false;

			statusLabel.Text = "Started";
			started = true;
		}

		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
				var random = new Random();
                int minValue = intervalTimeInt1 - 25;
                int maxValue = intervalTimeInt1 + 25;				

                string[] keysArray = keysText1.Split(',');

                while (started == true)
                {
					if (randomizer.Checked)
					{
						var shuffledArray = keysArray.OrderBy(x => Guid.NewGuid()).ToArray();
						foreach (string key in shuffledArray)
						{
							intervalTimeInt1 = random.Next(minValue, maxValue);

							if (!IsWindowActive(targetProcess, targetWindowTitle))
							{
								input.SendText(key);
								Thread.Sleep(intervalTimeInt1);
							}
							else
								Thread.Sleep(intervalTimeInt1);
						}
						
					}
					else
					{
						foreach (string key in keysArray)
						{
							intervalTimeInt1 = random.Next(minValue, maxValue);

							if (!IsWindowActive(targetProcess, targetWindowTitle))
							{
								input.SendText(key);
								Thread.Sleep(intervalTimeInt1);
							}
							else
								Thread.Sleep(intervalTimeInt1);
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
				int minValue = intervalTimeInt2 - 25;
				int maxValue = intervalTimeInt2 + 25;				

				string[] keysArray = keysText2.Split(',');

				while (started == true)
				{
					if (randomizer.Checked)
					{
						var shuffledArray = keysArray.OrderBy(x => Guid.NewGuid()).ToArray();
						foreach (string key in shuffledArray)
						{
							intervalTimeInt2 = random.Next(minValue, maxValue);

							if (!IsWindowActive(targetProcess, targetWindowTitle))
							{
								input.SendText(key);
								Thread.Sleep(intervalTimeInt2);
							}
							else
								Thread.Sleep(intervalTimeInt2);
						}

					}
					else
					{
						foreach (string key in keysArray)
						{
							intervalTimeInt2 = random.Next(minValue, maxValue);

							if (!IsWindowActive(targetProcess, targetWindowTitle))
							{
								input.SendText(key);
								Thread.Sleep(intervalTimeInt2);
							}
							else
								Thread.Sleep(intervalTimeInt2);
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
			keysTextBox2.Enabled = true;
			intervalBox2.Enabled = true;

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
	}
}
