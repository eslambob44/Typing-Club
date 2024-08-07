using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Club
{
    public partial class frmMain : Form
    {

        enum enQuateLvl { Short=0 , Medium=1 , Long=2 , All =3 };

        List<string> Quates = new List<string>();
        List<string> GetQuatesByDifficultyLvl(enQuateLvl QuateLvl, string QuatesLocation= @"D:\\programmin\\first jorney\\Typing Club\\Quates")
        {
            string DifficultyLvl =(QuateLvl==enQuateLvl.All)?"":QuateLvl.ToString();
            string[] QuatesDir = Directory.GetFiles(QuatesLocation);
            List<string> Quates = new List<string>();
            foreach(string Quate in QuatesDir)
            {
                string QuateFileName = Path.GetFileName(Quate);
                if(QuateFileName.IndexOf(DifficultyLvl)!=-1)
                {
                    StreamReader File = new StreamReader(Quate);
                    Quates.Add(File.ReadToEnd());
                    Quates[Quates.Count - 1]=Quates[Quates.Count - 1].Replace("\r", "");
                    File.Close();
                }
            }

            return Quates;
        }

        void FillcbQuateLength()
        {
            foreach (enQuateLvl Quate in Enum.GetValues(typeof(enQuateLvl)))
            {
                cbQuateLength.Items.Add(Quate.ToString());
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<string> Quates = GetQuatesByDifficultyLvl(enQuateLvl.All);
            FillcbQuateLength();
        }

        string GetQuate()
        {

            int IndexOfSelected = Quates.IndexOf(rtxtTyping.Text);


            if (IndexOfSelected == -1 || IndexOfSelected == Quates.Count - 1)
            {
                return Quates[0];
            }
            else
            {
                return Quates[IndexOfSelected + 1];
            }
        }

        private void cbQuateLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quates = GetQuatesByDifficultyLvl((enQuateLvl)cbQuateLength.SelectedIndex);
            rtxtTyping.Text = GetQuate();
            lblNumberOfQuates.Text = (Quates.IndexOf(rtxtTyping.Text)+1)+"/"+Quates.Count;
        }

        private void btnNewQuate_Click(object sender, EventArgs e)
        {
            if (cbQuateLength.SelectedIndex == -1)
            {
                MessageBox.Show("Choose Quate Length First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            rtxtTyping.Text = GetQuate();
            lblNumberOfQuates.Text = (Quates.IndexOf(rtxtTyping.Text) + 1) + "/" + Quates.Count;
        }

        private void timerCountTime_Tick(object sender, EventArgs e)
        {
            int Time =Convert.ToInt32(lblTime.Text.Substring(0, lblTime.Text.Length - 1));
            Time++;
            lblTime.Text = Time.ToString() + "s";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbQuateLength.SelectedIndex == -1)
            {
                MessageBox.Show("Choose Quate Length First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            
        }
    }
}
