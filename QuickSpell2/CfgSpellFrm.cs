using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSpell2
{
    public partial class CfgSpellFrm : Form
    {
        bool isNewSpell = false;
        MainForm mainForm;
        public CfgSpellFrm(MainForm mainForm, bool isNewSpell)
        {
            this.isNewSpell = isNewSpell;
            this.mainForm = mainForm;

            InitializeComponent();
            List<int> customColors = new List<int>();
            foreach (Button b in this.mainForm.spellButtons)
            {
                if (b.BackColor != SystemColors.Control)
                {
                    customColors.Add(ColorTranslator.ToOle(b.BackColor));
                }
            }
            this.colorDialog1.CustomColors = customColors.ToArray();

            if (isNewSpell)
            {
                this.comboBoxSpells.Enabled = false;
            } else
            {
                loadSpellsCombo();
            }
        }

        private void loadSpellsCombo()
        {
           foreach(Button b in this.mainForm.spellButtons)
           {
                this.comboBoxSpells.Items.Add(b.Text);
           }
            this.comboBoxSpells.Enabled = true;
            this.comboBoxSpells.SelectedItem = null;
            this.comboBoxSpells.Text = "Select Spell...";
        }

        private void cancelSpellBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_IndexChanged(object sender, EventArgs e)
        {
            foreach (Button b in this.mainForm.spellButtons)
            {
                if (b.Text.Equals(this.comboBoxSpells.SelectedItem.ToString()))
                {
                    this.textSpellName.Text = b.Text;
                    this.textSpellAction.Text = b.Tag.ToString();
                    this.colorPictureBox.BackColor = b.BackColor;
                    break;
                }
            }
        }

        private void cfgSpellBtn_Click(object sender, EventArgs e)
        {
            if(this.isNewSpell)
            {
                this.mainForm.addSpell(this.textSpellName.Text, this.textSpellAction.Text, this.colorPictureBox.BackColor);
                this.mainForm.SaveSpells();
                this.Close();
            } else
            {
                foreach (Button b in this.mainForm.spellButtons)
                {
                    if(b.Text.Equals(this.comboBoxSpells.SelectedItem.ToString()))
                    {
                        b.Text = this.textSpellName.Text;
                        b.Tag = this.textSpellAction.Text;
                        b.BackColor = this.colorPictureBox.BackColor;
                        this.mainForm.SaveSpells();
                        break;
                    }
                }
            }
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.colorDialog1.Color = this.colorPictureBox.BackColor;
            
            if(this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.colorPictureBox.BackColor = this.colorDialog1.Color;
            }
        }
    }
}
