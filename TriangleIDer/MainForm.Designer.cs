using System;
using System.Windows.Forms;

namespace TriangleIDer
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
            this.ParameterPanel = new System.Windows.Forms.Panel();
            this.TriangleViewPanel = new System.Windows.Forms.Panel();
            this.TB_SideC = new System.Windows.Forms.TextBox();
            this.TB_SideB = new System.Windows.Forms.TextBox();
            this.TB_SideA = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ParameterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParameterPanel
            // 
            this.ParameterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterPanel.Controls.Add(this.TriangleViewPanel);
            this.ParameterPanel.Controls.Add(this.TB_SideC);
            this.ParameterPanel.Controls.Add(this.TB_SideB);
            this.ParameterPanel.Controls.Add(this.TB_SideA);
            this.ParameterPanel.Controls.Add(this.StatusLabel);
            this.ParameterPanel.Controls.Add(this.label3);
            this.ParameterPanel.Controls.Add(this.label2);
            this.ParameterPanel.Controls.Add(this.label1);
            this.ParameterPanel.Location = new System.Drawing.Point(13, 13);
            this.ParameterPanel.Name = "ParameterPanel";
            this.ParameterPanel.Size = new System.Drawing.Size(268, 133);
            this.ParameterPanel.TabIndex = 0;
            // 
            // TriangleViewPanel
            // 
            this.TriangleViewPanel.Location = new System.Drawing.Point(161, 3);
            this.TriangleViewPanel.Name = "TriangleViewPanel";
            this.TriangleViewPanel.Size = new System.Drawing.Size(104, 72);
            this.TriangleViewPanel.TabIndex = 13;
            this.TriangleViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TriangleViewPanel_Paint);
            // 
            // TB_SideC
            // 
            this.TB_SideC.Location = new System.Drawing.Point(55, 55);
            this.TB_SideC.Name = "TB_SideC";
            this.TB_SideC.Size = new System.Drawing.Size(100, 20);
            this.TB_SideC.TabIndex = 12;
            this.TB_SideC.TextChanged += new System.EventHandler(this.TB_Side_TextChanged);
            this.TB_SideC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sideTextBox_KeyPress);
            // 
            // TB_SideB
            // 
            this.TB_SideB.Location = new System.Drawing.Point(55, 29);
            this.TB_SideB.Name = "TB_SideB";
            this.TB_SideB.Size = new System.Drawing.Size(100, 20);
            this.TB_SideB.TabIndex = 11;
            this.TB_SideB.TextChanged += new System.EventHandler(this.TB_Side_TextChanged);
            this.TB_SideB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sideTextBox_KeyPress);
            // 
            // TB_SideA
            // 
            this.TB_SideA.Location = new System.Drawing.Point(55, 3);
            this.TB_SideA.Name = "TB_SideA";
            this.TB_SideA.Size = new System.Drawing.Size(100, 20);
            this.TB_SideA.TabIndex = 10;
            this.TB_SideA.TextChanged += new System.EventHandler(this.TB_Side_TextChanged);
            this.TB_SideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sideTextBox_KeyPress);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusLabel.Location = new System.Drawing.Point(3, 99);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(1);
            this.StatusLabel.Size = new System.Drawing.Size(270, 15);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Please Input Numeric Values > 0 Into Sides A, B, and C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Side C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Side B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 157);
            this.Controls.Add(this.ParameterPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(309, 196);
            this.MinimumSize = new System.Drawing.Size(309, 196);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Triangle Identifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ParameterPanel.ResumeLayout(false);
            this.ParameterPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel ParameterPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private TextBox TB_SideA;
        private TextBox TB_SideC;
        private TextBox TB_SideB;
        private Panel TriangleViewPanel;
    }
}

