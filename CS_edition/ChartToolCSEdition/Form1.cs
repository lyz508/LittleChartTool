using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartToolCSEdition;
using System.Collections;
using System.Diagnostics;

namespace ChartToolCSEdition
{
    public partial class Form1 : Form
    {
        /*Field*/
        private Parser parser;
        private ArrayList allpaths;
        private bool IsAllowMultipe;
        
        public Form1 ()
        {
            InitializeComponent();
            parser = new Parser();
            allpaths = parser.getAllPaths;
            IsAllowMultipe = false;

            /*Add to the ComboBox*/
            if (allpaths.Count != 0)
            {
                for (int i=allpaths.Count-1; i>=0; i--)
                {
                    this.listBoxShowAvali.Items.Add(allpaths[i]);
                }

                this.listBoxShowAvali.SetSelected(0, true);
            }
            else
            {
                MessageBox.Show("Something wrong on reading files...", "ERRORRRRRR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Selected Index Changed -> Open the specified file and Show sum on the label*/
        private void listBoxShowAvali_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (listBoxShowAvali.SelectedItems.Count == 1)
            {
                /*Get chosen file*/
                string chosenFile = (string)listBoxShowAvali.SelectedItem;

                /*Call parser*/
                parser.proNowWorking = chosenFile;
                parser.CalculateSum();

                /*Show on rtxtBox*/
                this.RtxtBox_ShowWorking.LoadFile(parser.proNowWorking, RichTextBoxStreamType.UnicodePlainText);
                
                /*Move Caret and set focus to RtxtBox*/
                this.RtxtBox_ShowWorking.SelectionStart = RtxtBox_ShowWorking.TextLength;
                this.RtxtBox_ShowWorking.ScrollToCaret();
                this.RtxtBox_ShowWorking.Focus();

                /*Show on label*/
                string showOnLabel = "";
                showOnLabel += $"日用度花費: {parser.CommonSum}";
                if (parser.UnCommonSum != 0)
                    showOnLabel += $"\n非日用度花費:{parser.UnCommonSum}";

                this.groupBoxCount.Text = "花費統計";
                this.lbl_showSum.Text = showOnLabel;

                /*Show on the status strip*/
                this.tssL_ShowInformation.Text = "當月用度計算完成";
                this.timer_forRefresh.Stop();
                this.timer_forRefresh.Start();
            }
            else
            { // Calculate all sum of selected file
                int AllCommon = 0, Alluncommon = 0;
                
                foreach (string selectedItem in listBoxShowAvali.SelectedItems)
                {
                    parser.proNowWorking = selectedItem;
                    parser.CalculateSum();

                    AllCommon += parser.CommonSum;
                    Alluncommon += parser.UnCommonSum;
                }

                /*Show on the label*/
                string showOnLabel = "";
                showOnLabel += $"日用度花費: {AllCommon}";
                if (Alluncommon != 0)
                    showOnLabel += $"\n非日用度花費:{Alluncommon}";

                this.groupBoxCount.Text = "選取的項目統計";
                this.lbl_showSum.Text = showOnLabel;


                /*Show on the status strip*/
                this.tssL_ShowInformation.Text = $"計算了 " +
                    $"{this.listBoxShowAvali.SelectedItems.Count} 個月的用度總和";
                this.timer_forRefresh.Stop();
                this.timer_forRefresh.Start();
            }
        }

        /*Save opening File*/
        private void SaveChanges()
        {
            /*RichtxtBox SaveLoad*/
            RtxtBox_ShowWorking.SaveFile(parser.proNowWorking, RichTextBoxStreamType.UnicodePlainText);
            RtxtBox_ShowWorking.LoadFile(parser.proNowWorking, RichTextBoxStreamType.UnicodePlainText);

            /*Move Caret and set focus to RtxtBox*/
            this.RtxtBox_ShowWorking.SelectionStart = RtxtBox_ShowWorking.TextLength;
            this.RtxtBox_ShowWorking.ScrollToCaret();
            this.RtxtBox_ShowWorking.Focus();

            /*Show on label*/
            parser.CalculateSum();
            string showOnLabel = "";
            showOnLabel += $"日用度花費: {parser.CommonSum}";
            if (parser.UnCommonSum != 0)
                showOnLabel += $"\n非日用度花費:{parser.UnCommonSum}";
            this.lbl_showSum.Text = showOnLabel;

            /*Show on StatusBar*/
            this.tssL_ShowInformation.Text = "保存成功";
            this.timer_forRefresh.Stop();
            this.timer_forRefresh.Start();
        }

        /*Judgement for Shortcut*/
        private void RtxtBox_ShowWorking_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q 
                && e.Control == true)
            {   //Close file
                this.Close();
            }
            else if (e.KeyCode == Keys.S 
                && e.Control == true)
            {   //Save Changes
                this.SaveChanges();
            }
            else if (e.KeyCode == Keys.M && e.Alt == true)
            {   //Allow multiple choice on quick Keyboard Press
                if (this.IsAllowMultipe)
                {
                    this.IsAllowMultipe = false;
                }
                else
                {
                    this.IsAllowMultipe = true;   
                }

                /*Show on status bar*/
                this.tssL_ShowInformation.Text = $"允許選擇多個項目: {this.IsAllowMultipe}";
                this.timer_forRefresh.Stop();
                this.timer_forRefresh.Start();
            }
            else if (e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9 
                && e.Alt == true)
            {   //Select files
                int file = e.KeyValue - ((int)Keys.D0);

                if (IsAllowMultipe == false)
                {//can only choose one file per operation 
                    this.listBoxShowAvali.SelectedItems.Clear();
                    this.listBoxShowAvali.SelectedItems.Add(listBoxShowAvali.Items[file - 1]);
                }
                else
                {//allow multiple choice on operation
                    this.listBoxShowAvali.SelectedItems.Add(listBoxShowAvali.Items[file - 1]);
                }

                /*Show on the Status Strip*/
                this.tssL_ShowInformation.Text = $"切換至第 {file} 個月份";
                this.timer_forRefresh.Stop();
                this.timer_forRefresh.Start();
            }
            else if (e.KeyCode == Keys.H && e.Alt == true)
            {
                this.tsB_help_Click(this.tsB_help, AddingNewEventArgs.Empty);
            }
        }


        /*Refresh for some content*/
        private void timer_forRefresh_Tick (object sender, EventArgs e)
        {
            this.tssL_ShowInformation.Text = "";
        }


        ///*ToolStrips*///
        /*Show application document (in HackMD)*/
        private void tsB_help_Click (object sender, EventArgs e)
        {
            string TargetUrl = "https://hackmd.io/w2Qa037dSOqHvS9v2ewsnA?view";
            try
            {
                Process.Start("explorer.exe", TargetUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*Save File*/
        private void saveToolStripButton_Click (object sender, EventArgs e)
        {
            this.SaveChanges();
        }
    }
}
