using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ChartToolCSEdition
{
    public class Parser
    {
        public Parser ()
        {
            this.AllPaths = new ArrayList();
            this.CommonSum = 0;
            this.UnCommonSum = 0;

            string[] year = new string[] { "2020", "2021", "2022", "2023" };
            string[] month = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string repo = @"D:\chart_record\", nowPath = "";
            FileInfo TryOpen;

            this.AllPaths = new ArrayList();
            for (int y = 0; y < year.Length; y++)
            {
                for (int m = 0; m < month.Length; m++)
                {
                    nowPath = year[y] + "_" + month[m] + ".txt";
                    TryOpen = new FileInfo(repo + nowPath);
                    if (TryOpen.Exists)
                    {
                        this.AllPaths.Add(year[y] + "_" + month[m]);
                    }
                }
            }
        }



        /*Field*/
        public int CommonSum;
        public int UnCommonSum;
        private ArrayList AllPaths;
        private string nowWorking;


        /*Property*/
        public string AvaliblePath
        {/*Get String of Available Path from parser*/
            get
            {
                string forReturn = "";
                int i = 1;
                foreach (string item in this.AllPaths)
                {
                    forReturn += $"{i}. " + item;
                    i++;
                    forReturn += "\n";
                }
                return forReturn;
            }
        }

        public ArrayList getAllPaths
        {
            get => this.AllPaths;
        }
        
        public string proNowWorking
        {
            get
            {
                return nowWorking;
            }
            set
            {
                string path = "D:/chart_record/";
                nowWorking = path + value + ".txt";
            }
        }
        
        
        /*Calculate Sum and assign to Uncommon & Common Sum*/
        public void CalculateSum()
        {
            string nowLine = "", intString = "";
            FileStream fs = new FileStream(nowWorking, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Unicode);

            this.UnCommonSum = 0;
            this.CommonSum = 0;
            while (true)
            {
                nowLine = sr.ReadLine();
                if (nowLine == null)
                {
                    break;
                }
                if (nowLine.IndexOf("$") != -1)
                {
                    intString = nowLine.Substring(nowLine.IndexOf("$") + 1);
                    try
                    {
                        this.CommonSum += Convert.ToInt32(intString);
                    }
                    catch (Exception ex)
                    {
                        this.CommonSum += 0;
                    }
                }
                else if (nowLine.IndexOf("&") != -1)
                {
                    intString = nowLine.Substring(nowLine.IndexOf("&") + 1);
                    try
                    {
                        this.UnCommonSum += Convert.ToInt32(intString);
                    }
                    catch (Exception ex)
                    {
                        this.UnCommonSum += 0;
                    }
                }

                intString = "";
            }

            fs.Close();
            sr.Close();
        }
    }
}
