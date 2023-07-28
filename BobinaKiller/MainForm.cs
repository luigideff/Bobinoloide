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
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder lpString, int nMaxCount);

        private bool started = false;
        private BackgroundWorker backgroundWorker1;
        private Process targetProcess = Process.GetProcessesByName("Bobinoloide").FirstOrDefault();
        private string targetWindowTitle = "Bobinoloide";
        private string keysText = string.Empty;
        private string intervalTimeText = string.Empty;
        private int intervalTimeInt = int.MinValue;

        private void startButton_Click(object sender, EventArgs e)
        {
            keysText = keysTextBox.Text.Trim();
            intervalTimeText = intervalBox.Text.Trim();

            if (string.IsNullOrEmpty(keysText))
            {
                MessageBox.Show("Favor informar as teclas a serem pressionadas.");
                return;
            }


            if (string.IsNullOrEmpty(intervalTimeText))
            {
                MessageBox.Show("Favor informar o intervalo em milisegundos");
                return;
            }
            else
                intervalTimeInt = Convert.ToInt32(intervalTimeText);

            startButton.Enabled = false;
            stopButton.Enabled = true;
            keysTextBox.Enabled = false;
            intervalBox.Enabled = false;

            statusLabel.Text = "Started";
            started = true;

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerAsync();
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Input input = new Input();

                // Be sure to set your keyboard filter to be able to capture key presses and simulate key presses
                // KeyboardFilterMode.All captures all events; 'Down' only captures presses for non-special keys; 'Up' only captures releases for non-special keys; 'E0' and 'E1' capture presses/releases for special keys
                input.KeyboardFilterMode = KeyboardFilterMode.All;
                // You can set a MouseFilterMode as well, but you don't need to set a MouseFilterMode to simulate mouse clicks

                // Finally, load the driver
                input.Load();

                string[] keysArray = keysText.Split(',');

                while (started == true)
                {
                    foreach (string key in keysArray)
                    {
                        if (!IsWindowActive(targetProcess, targetWindowTitle))
                        {
                            input.SendText(key);
                            Thread.Sleep(intervalTimeInt);
                        }
                        else
                        Thread.Sleep(intervalTimeInt);
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
            startButton.Enabled = true;
            stopButton.Enabled = false;
            keysTextBox.Enabled = true;
            intervalBox.Enabled = true;

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
