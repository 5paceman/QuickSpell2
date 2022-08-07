using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace QuickSpell2
{

    public partial class MainForm : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string sClass, string sWindow);

        [DllImport("user32.dll", EntryPoint = "FindWindowExA")]
        private static extern IntPtr FindWindowExA(IntPtr hWndParent, IntPtr hWndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public ArrayList spellButtons = new ArrayList();

        private string savedFileName = "spells.book";
        public MainForm()
        {
            InitializeComponent();
            LoadSavedSpells();
        }

        private void LoadSavedSpells()
        {
            if (File.Exists(savedFileName))
            {
                using (StreamReader sr = new StreamReader(savedFileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] button = line.Split(':');
                        if (button.Length == 3)
                        {
                            addSpell(button[0], button[1], Color.FromArgb(int.Parse(button[2])));
                        }
                    }
                }
            }
        }

        public void SaveSpells()
        {
            if (File.Exists(savedFileName))
            {
                File.Delete(savedFileName);
            }
            using (StreamWriter sr = new StreamWriter(File.Create(savedFileName)))
            {
                foreach(Button b in this.spellButtons)
                {
                    sr.WriteLine(b.Text + ":" + b.Tag + ":" + b.BackColor.ToArgb().ToString());
                }
            }
            
        }

        private string Left(string s, int count)
        {
            return s.Substring(0, count);
        }

        private string Right(string s, int count)
        {
            return s.Substring(s.Length - count, count);
        }

        private void onSpellButton_Click(object sender, EventArgs e)
        {
            string spellAction = ((Button)sender).Tag.ToString();
            IntPtr hMeridian = FindWindow("Meridian 59", null);
            IntPtr hCombo = FindWindowExA(hMeridian, IntPtr.Zero, "COMBOBOX", null);
            IntPtr hEdit = FindWindowExA(hCombo, IntPtr.Zero, "EDIT", null);

            string temp;
            int nLength;
            int nSemi = -1;
            bool bFirst = true;

            nSemi = spellAction.IndexOf(';');
            while(nSemi != -1)
            {
                temp = Left(spellAction, nSemi);

                if(Left(temp, 1).Equals("~"))
                {
                    Thread.Sleep(1500);
                    temp = Right(temp, temp.Length - 1);
                } else
                {
                    if (!bFirst)
                        Thread.Sleep(500);
                }

                SendMessage(hEdit, /* WM_SETTEXT */ 0x000C, 0, temp);
                SendMessage(hEdit, /* WM_KEYDOWN */ 0x0100, /* VK_RETURN */ 0x0D, "");
                SendMessage(hEdit, /* WM_KEYUP */ 0x0101, /* VK_RETURN */ 0x0D, "");

                nLength = spellAction.Length;
                spellAction = Right(spellAction, nLength - nSemi - 1);
                nSemi = spellAction.IndexOf(';');
                bFirst = false;
            }

            if (Left(spellAction, 1).Equals("~"))
            {
                Thread.Sleep(1500);
                spellAction = Right(spellAction, spellAction.Length - 1);
            } else
            {
                Thread.Sleep(500);
            }

            SendMessage(hEdit, /* WM_SETTEXT */ 0x000C, 0, spellAction);
            SendMessage(hEdit, /* WM_KEYDOWN */ 0x0100, /* VK_RETURN */ 0x0D, "");
            SendMessage(hEdit, /* WM_KEYUP */ 0x0101, /* VK_RETURN */ 0x0D, "");

            SetForegroundWindow(hMeridian);
        }

        public void addSpell(string spellName, string spellAction, Color color)
        {
            if((spellButtons.Count + 1) % 10 == 0)
            {
                this.Size = this.Size + new Size(124, 0);
                this.groupBoxSpells.Size = this.groupBoxSpells.Size + new Size(124, 0);
            }

            Button spellButton = new Button();
            spellButton.Text = spellName;
            spellButton.Size = new Size(119, 30);
            spellButton.Click += new System.EventHandler(onSpellButton_Click);
            spellButton.Tag = spellAction;
            spellButton.BackColor = color;
            this.spellButtons.Add(spellButton);
            this.flowLayoutPanel.Controls.Add(spellButton);


        }

        private void addSpellBtn_Click(object sender, EventArgs e)
        {
            CfgSpellFrm cfgSpellFrm = new CfgSpellFrm(this, true);
            cfgSpellFrm.ShowDialog(this);
        }

        private void cfgSpellBtn_Click(object sender, EventArgs e)
        {
            CfgSpellFrm cfgSpellFrm = new CfgSpellFrm(this, false);
            cfgSpellFrm.ShowDialog(this);
        }
    }
}