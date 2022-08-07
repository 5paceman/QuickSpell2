using System.Windows.Forms;

namespace QuickSpell2
{
    partial class CfgSpellFrm
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
            this.cfgSpellBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSpellName = new System.Windows.Forms.TextBox();
            this.textSpellAction = new System.Windows.Forms.TextBox();
            this.cancelSpellBtn = new System.Windows.Forms.Button();
            this.comboBoxSpells = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.colorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cfgSpellBtn
            // 
            this.cfgSpellBtn.Location = new System.Drawing.Point(124, 144);
            this.cfgSpellBtn.Name = "cfgSpellBtn";
            this.cfgSpellBtn.Size = new System.Drawing.Size(102, 26);
            this.cfgSpellBtn.TabIndex = 2;
            this.cfgSpellBtn.Text = "Done";
            this.cfgSpellBtn.UseVisualStyleBackColor = true;
            this.cfgSpellBtn.Click += new System.EventHandler(this.cfgSpellBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spell Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Spell Name";
            // 
            // textSpellName
            // 
            this.textSpellName.Location = new System.Drawing.Point(10, 43);
            this.textSpellName.Name = "textSpellName";
            this.textSpellName.Size = new System.Drawing.Size(218, 20);
            this.textSpellName.TabIndex = 5;
            // 
            // textSpellAction
            // 
            this.textSpellAction.Location = new System.Drawing.Point(10, 85);
            this.textSpellAction.Name = "textSpellAction";
            this.textSpellAction.Size = new System.Drawing.Size(218, 20);
            this.textSpellAction.TabIndex = 6;
            // 
            // cancelSpellBtn
            // 
            this.cancelSpellBtn.Location = new System.Drawing.Point(10, 144);
            this.cancelSpellBtn.Name = "cancelSpellBtn";
            this.cancelSpellBtn.Size = new System.Drawing.Size(102, 26);
            this.cancelSpellBtn.TabIndex = 7;
            this.cancelSpellBtn.Text = "Close";
            this.cancelSpellBtn.UseVisualStyleBackColor = true;
            this.cancelSpellBtn.Click += new System.EventHandler(this.cancelSpellBtn_Click);
            // 
            // comboBoxSpells
            // 
            this.comboBoxSpells.FormattingEnabled = true;
            this.comboBoxSpells.Location = new System.Drawing.Point(10, 5);
            this.comboBoxSpells.Name = "comboBoxSpells";
            this.comboBoxSpells.Size = new System.Drawing.Size(218, 21);
            this.comboBoxSpells.TabIndex = 8;
            this.comboBoxSpells.Text = "New Spell";
            this.comboBoxSpells.SelectedIndexChanged += new System.EventHandler(this.comboBox_IndexChanged);
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPictureBox.Location = new System.Drawing.Point(49, 118);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(21, 16);
            this.colorPictureBox.TabIndex = 9;
            this.colorPictureBox.TabStop = false;
            this.colorPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(12, 118);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(37, 13);
            this.colorLabel.TabIndex = 10;
            this.colorLabel.Text = "Color: ";
            // 
            // CfgSpellFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 178);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorPictureBox);
            this.Controls.Add(this.comboBoxSpells);
            this.Controls.Add(this.cancelSpellBtn);
            this.Controls.Add(this.textSpellAction);
            this.Controls.Add(this.textSpellName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cfgSpellBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CfgSpellFrm";
            this.Text = "Configure Spell";
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cfgSpellBtn;
        private Label label1;
        private Label label2;
        public TextBox textSpellName;
        public TextBox textSpellAction;
        private Button cancelSpellBtn;
        private ComboBox comboBoxSpells;
        private ColorDialog colorDialog1;
        private PictureBox colorPictureBox;
        private Label colorLabel;
    }
}