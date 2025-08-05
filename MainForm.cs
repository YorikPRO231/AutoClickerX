using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace AdvancedAutoClicker
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private const int HOTKEY_ID = 1;
        private const int WM_HOTKEY = 0x0312;

        private bool isRunning = false;
        private Thread clickThread;
        private List<ClickPoint> recordedPoints = new List<ClickPoint>();
        private bool isRecording = false;

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                if (m.WParam.ToInt32() == HOTKEY_ID)
                {
                    if (btnStart.InvokeRequired)
                    {
                        btnStart.Invoke(new Action(() => btnStart.PerformClick()));
                    }
                    else
                    {
                        btnStart.PerformClick();
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!RegisterHotKey(this.Handle, HOTKEY_ID, 0, (int)Keys.F6))
            {
                MessageBox.Show("Не удалось зарегистрировать горячую клавишу F6!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            StopClicking();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                if (rbSequence.Checked && recordedPoints.Count == 0)
                {
                    MessageBox.Show("Запишите последовательность кликов сначала!", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StartClicking();
            }
            else
            {
                StopClicking();
            }
        }

        private void StartClicking()
        {
            isRunning = true;
            btnStart.Text = "Стоп (F6)";
            int interval = (int)numericInterval.Value;

            clickThread = new Thread(() =>
            {
                try
                {
                    while (isRunning)
                    {
                        if (rbSingle.Checked) PerformSingleClick();
                        else if (rbSequence.Checked) PlaybackSequence();

                        Thread.Sleep(interval);
                    }
                }
                catch (ThreadAbortException)
                {
                    Thread.ResetAbort();
                }
                catch (Exception ex)
                {
                    Invoke((MethodInvoker)delegate {
                        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            });

            clickThread.IsBackground = true;
            clickThread.Start();
        }

        private void StopClicking()
        {
            isRunning = false;
            btnStart.Text = "Старт (F6)";

            if (clickThread != null && clickThread.IsAlive)
            {
                if (!clickThread.Join(500))
                {
                    clickThread.Abort();
                }
                clickThread = null;
            }
        }

        private void PerformSingleClick()
        {
            Point targetPos;
            if (cbUseCoordinates.Checked)
            {
                targetPos = new Point((int)numericX.Value, (int)numericY.Value);
                SetCursorPos(targetPos.X, targetPos.Y);
            }
            else
            {
                GetCursorPos(out targetPos);
            }

            if (rbLeftClick.Checked)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, targetPos.X, targetPos.Y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, targetPos.X, targetPos.Y, 0, 0);
            }
            else if (rbRightClick.Checked)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, targetPos.X, targetPos.Y, 0, 0);
                mouse_event(MOUSEEVENTF_RIGHTUP, targetPos.X, targetPos.Y, 0, 0);
            }
            else if (rbDoubleClick.Checked)
            {
                for (int i = 0; i < 2; i++)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, targetPos.X, targetPos.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, targetPos.X, targetPos.Y, 0, 0);
                    Thread.Sleep(50);
                }
            }
        }

        private void PlaybackSequence()
        {
            foreach (var point in recordedPoints)
            {
                if (!isRunning) break;

                SetCursorPos(point.X, point.Y);

                if (point.ClickType == ClickType.Left)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, point.X, point.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, point.X, point.Y, 0, 0);
                }
                else if (point.ClickType == ClickType.Right)
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, point.X, point.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_RIGHTUP, point.X, point.Y, 0, 0);
                }
                else if (point.ClickType == ClickType.Double)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN, point.X, point.Y, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, point.X, point.Y, 0, 0);
                        Thread.Sleep(50);
                    }
                }

                Thread.Sleep(point.DelayAfter);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                isRecording = true;
                recordedPoints.Clear();
                btnRecord.Text = "Запись... (F5 - добавить точку)";
                lblStatus.Text = "Запись начата. Нажмите F5 для добавления точки.";
            }
            else
            {
                isRecording = false;
                btnRecord.Text = "Записать последовательность";
                lblStatus.Text = $"Готово. Записано точек: {recordedPoints.Count}";
            }
        }

        private void btnGetCurrentPos_Click(object sender, EventArgs e)
        {
            Point cursorPos;
            GetCursorPos(out cursorPos);
            numericX.Value = cursorPos.X;
            numericY.Value = cursorPos.Y;
        }

        private void btnClearSequence_Click(object sender, EventArgs e)
        {
            recordedPoints.Clear();
            lblStatus.Text = "Последовательность очищена.";
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            gbSingleClick.Enabled = rbSingle.Checked;
            gbSequence.Enabled = rbSequence.Checked;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isRecording && keyData == Keys.F5)
            {
                AddRecordPoint();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AddRecordPoint()
        {
            Point cursorPos;
            GetCursorPos(out cursorPos);

            ClickType clickType = rbLeftClick.Checked ? ClickType.Left :
                                rbRightClick.Checked ? ClickType.Right : ClickType.Double;

            recordedPoints.Add(new ClickPoint
            {
                X = cursorPos.X,
                Y = cursorPos.Y,
                ClickType = clickType,
                DelayAfter = (int)numericPointDelay.Value
            });

            lblStatus.Text = $"Добавлена точка: {cursorPos.X}, {cursorPos.Y} ({clickType}). Всего: {recordedPoints.Count}";
        }
    }

    public enum ClickType { Left, Right, Double }

    public class ClickPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ClickType ClickType { get; set; }
        public int DelayAfter { get; set; }
    }
}