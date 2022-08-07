using System.Windows.Forms;

namespace QuickSpell2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addSpellBtn = new System.Windows.Forms.Button();
            this.cfgSpellBtn = new System.Windows.Forms.Button();
            this.groupBoxCfg = new System.Windows.Forms.GroupBox();
            this.groupBoxSpells = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxCfg.SuspendLayout();
            this.groupBoxSpells.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSpellBtn
            // 
            this.addSpellBtn.Location = new System.Drawing.Point(5, 22);
            this.addSpellBtn.Name = "addSpellBtn";
            this.addSpellBtn.Size = new System.Drawing.Size(119, 30);
            this.addSpellBtn.TabIndex = 0;
            this.addSpellBtn.Text = "Add Spell";
            this.addSpellBtn.UseVisualStyleBackColor = true;
            this.addSpellBtn.Click += new System.EventHandler(this.addSpellBtn_Click);
            // 
            // cfgSpellBtn
            // 
            this.cfgSpellBtn.Location = new System.Drawing.Point(5, 53);
            this.cfgSpellBtn.Name = "cfgSpellBtn";
            this.cfgSpellBtn.Size = new System.Drawing.Size(119, 30);
            this.cfgSpellBtn.TabIndex = 1;
            this.cfgSpellBtn.Text = "Configure Spell";
            this.cfgSpellBtn.UseVisualStyleBackColor = true;
            this.cfgSpellBtn.Click += new System.EventHandler(this.cfgSpellBtn_Click);
            // 
            // groupBoxCfg
            // 
            this.groupBoxCfg.Controls.Add(this.addSpellBtn);
            this.groupBoxCfg.Controls.Add(this.cfgSpellBtn);
            this.groupBoxCfg.Location = new System.Drawing.Point(7, 5);
            this.groupBoxCfg.Name = "groupBoxCfg";
            this.groupBoxCfg.Size = new System.Drawing.Size(130, 376);
            this.groupBoxCfg.TabIndex = 2;
            this.groupBoxCfg.TabStop = false;
            this.groupBoxCfg.Text = "Configure";
            // 
            // groupBoxSpells
            // 
            this.groupBoxSpells.AutoSize = true;
            this.groupBoxSpells.Controls.Add(this.flowLayoutPanel);
            this.groupBoxSpells.Location = new System.Drawing.Point(143, 5);
            this.groupBoxSpells.MinimumSize = new System.Drawing.Size(130, 379);
            this.groupBoxSpells.Name = "groupBoxSpells";
            this.groupBoxSpells.Size = new System.Drawing.Size(131, 379);
            this.groupBoxSpells.TabIndex = 3;
            this.groupBoxSpells.TabStop = false;
            this.groupBoxSpells.Text = "Spells";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel.MaximumSize = new System.Drawing.Size(0, 360);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(125, 360);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 389);
            this.Controls.Add(this.groupBoxSpells);
            this.Controls.Add(this.groupBoxCfg);
            this.Name = "MainForm";
            this.Text = "QuickSpell2";
            this.groupBoxCfg.ResumeLayout(false);
            this.groupBoxSpells.ResumeLayout(false);
            this.groupBoxSpells.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addSpellBtn;
        private Button cfgSpellBtn;
        private GroupBox groupBoxCfg;
        private GroupBox groupBoxSpells;
        private FlowLayoutPanel flowLayoutPanel;
    }
}