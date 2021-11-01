
namespace ChartToolCSEdition
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RtxtBox_ShowWorking = new System.Windows.Forms.RichTextBox();
            this.lbl_showSum = new System.Windows.Forms.Label();
            this.groupBoxCount = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxShowAvali = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssL_ShowInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_forRefresh = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsB_help = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBoxCount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RtxtBox_ShowWorking
            // 
            this.RtxtBox_ShowWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtBox_ShowWorking.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtxtBox_ShowWorking.Location = new System.Drawing.Point(3, 24);
            this.RtxtBox_ShowWorking.Name = "RtxtBox_ShowWorking";
            this.RtxtBox_ShowWorking.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtxtBox_ShowWorking.Size = new System.Drawing.Size(274, 507);
            this.RtxtBox_ShowWorking.TabIndex = 0;
            this.RtxtBox_ShowWorking.Text = "";
            this.RtxtBox_ShowWorking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtxtBox_ShowWorking_KeyDown);
            // 
            // lbl_showSum
            // 
            this.lbl_showSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_showSum.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_showSum.Location = new System.Drawing.Point(3, 24);
            this.lbl_showSum.Name = "lbl_showSum";
            this.lbl_showSum.Size = new System.Drawing.Size(176, 76);
            this.lbl_showSum.TabIndex = 5000;
            this.lbl_showSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxCount
            // 
            this.groupBoxCount.Controls.Add(this.lbl_showSum);
            this.groupBoxCount.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCount.Location = new System.Drawing.Point(33, 44);
            this.groupBoxCount.Name = "groupBoxCount";
            this.groupBoxCount.Size = new System.Drawing.Size(182, 103);
            this.groupBoxCount.TabIndex = 7;
            this.groupBoxCount.TabStop = false;
            this.groupBoxCount.Text = "花費統計";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxShowAvali);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(33, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 404);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選擇月份";
            // 
            // listBoxShowAvali
            // 
            this.listBoxShowAvali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShowAvali.FormattingEnabled = true;
            this.listBoxShowAvali.ItemHeight = 17;
            this.listBoxShowAvali.Location = new System.Drawing.Point(3, 24);
            this.listBoxShowAvali.Name = "listBoxShowAvali";
            this.listBoxShowAvali.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxShowAvali.Size = new System.Drawing.Size(176, 377);
            this.listBoxShowAvali.TabIndex = 2;
            this.listBoxShowAvali.TabStop = false;
            this.listBoxShowAvali.SelectedIndexChanged += new System.EventHandler(this.listBoxShowAvali_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RtxtBox_ShowWorking);
            this.groupBox3.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(244, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 534);
            this.groupBox3.TabIndex = 900;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "記帳本";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssL_ShowInformation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(550, 25);
            this.statusStrip1.TabIndex = 901;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssL_ShowInformation
            // 
            this.tssL_ShowInformation.AutoSize = false;
            this.tssL_ShowInformation.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tssL_ShowInformation.LinkVisited = true;
            this.tssL_ShowInformation.Name = "tssL_ShowInformation";
            this.tssL_ShowInformation.Size = new System.Drawing.Size(158, 19);
            this.tssL_ShowInformation.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timer_forRefresh
            // 
            this.timer_forRefresh.Enabled = true;
            this.timer_forRefresh.Interval = 1500;
            this.timer_forRefresh.Tick += new System.EventHandler(this.timer_forRefresh_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsB_help,
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(550, 27);
            this.toolStrip1.TabIndex = 902;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsB_help
            // 
            this.tsB_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsB_help.Image = global::ChartToolCSEdition.Properties.Resources.red_question_mark;
            this.tsB_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsB_help.Name = "tsB_help";
            this.tsB_help.Size = new System.Drawing.Size(29, 24);
            this.tsB_help.Text = "Help Document";
            this.tsB_help.Click += new System.EventHandler(this.tsB_help_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "Save File";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(550, 612);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日用度統計";
            this.groupBoxCount.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RtxtBox_ShowWorking;
        private System.Windows.Forms.Label lbl_showSum;
        private System.Windows.Forms.GroupBox groupBoxCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxShowAvali;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssL_ShowInformation;
        private System.Windows.Forms.Timer timer_forRefresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsB_help;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
    }
}

