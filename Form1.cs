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
        enum enLetterStatus { Waiting=0,Correct=1,Wrong=2,Deleted=3 };
        struct stGameResult
        {
            public int NumberOfWords;
            public int CorrectWords;
            public int WrongWords;
            public int TimeTakenToCompleteQuateInSeconds;
            public float NumberOfLettersPerSeconds;
            public int Accuracy;
            public int IndexOfLetterThatWillWritten;

        };

        stGameResult initGameResultStruct()
        {
            stGameResult result = new stGameResult();
            result.NumberOfWords=rtxtTyping.Text.Length;
            result.CorrectWords = 0;
            result.WrongWords = 0;
            result.TimeTakenToCompleteQuateInSeconds = 0;
            result.NumberOfLettersPerSeconds = 0;
            result.IndexOfLetterThatWillWritten = 0;
            return result;
        }

        stGameResult GameResult=new stGameResult();

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

        void ResetGame()
        {
            btnStart.Tag = "0";
            btnStart.Enabled = true;
            btnNewQuate.Enabled = true;
            cbQuateLength.Enabled = true;
            rtxtTyping.Clear();
            cbQuateLength.SelectedIndex = -1;
            lblNumberOfQuates.Text = "0/0";
            lblTime.Text = "0s";
            cbQuateLength.Focus();
            lblRatioWordsPerQuateLength.Visible= false;
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
            if (cbQuateLength.SelectedIndex == -1) return;
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

        void ChangeTimeLabel()
        {
            int Time = Convert.ToInt32(lblTime.Text.Substring(0, lblTime.Text.Length - 1));
            Time++;
            lblTime.Text = Time.ToString() + "s";
        }

        private void timerCountTime_Tick(object sender, EventArgs e)
        {
            ChangeTimeLabel();
            GameResult.TimeTakenToCompleteQuateInSeconds++;
            
        }

        void AddUnderLine(Font font)
        {
            font = new Font(font, FontStyle.Underline);
        }

        bool IsGameEnd()
        {
            return GameResult.NumberOfWords == GameResult.IndexOfLetterThatWillWritten;
        }

        void ChangeLetterFontAndColor(int IndexOfLetter , enLetterStatus LetterStatus)
        {
            Color color = (LetterStatus == enLetterStatus.Waiting) ? Color.FromArgb(192, 255, 255)
                :(LetterStatus == enLetterStatus.Deleted)?Color.Transparent:
                (LetterStatus == enLetterStatus.Correct) ? Color.Green : Color.Red;
            rtxtTyping.Select(IndexOfLetter, 1);
            rtxtTyping.SelectionBackColor = color;
            if(LetterStatus == enLetterStatus.Waiting)
            {
                AddUnderLine(rtxtTyping.SelectionFont);
            }
            else
            {
                rtxtTyping.SelectionFont = new Font(rtxtTyping.SelectionFont, rtxtTyping.SelectionFont.Style & ~FontStyle.Underline); ;
            }
        }

        

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbQuateLength.SelectedIndex == -1)
            {
                MessageBox.Show("Choose Quate Length First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnStart.Tag = "1";
            btnNewQuate.Enabled = false;
            cbQuateLength.Enabled = false;
            btnStart.Enabled = false;
            timerCountTime.Enabled = true;
            lblRatioWordsPerQuateLength.Visible = true;
            GameResult = initGameResultStruct();
            lblRatioWordsPerQuateLength.Text = "0/" + GameResult.NumberOfWords;
            ChangeLetterFontAndColor(0, enLetterStatus.Waiting);
            rtxtTyping.Focus();


        }

        void DecreaseCorrectOrWrongTimesInStructAfterRemoveLetter()
        {
            rtxtTyping.Select(GameResult.IndexOfLetterThatWillWritten, 1);
            if(rtxtTyping.SelectionBackColor == Color.Green)
            {
                GameResult.CorrectWords--;
            }
            else
            {
                GameResult.WrongWords--;
            }
        }

        private void rtxtTyping_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode==Keys.Back)
            {
                //to prevent pip sound when write
                e.Handled = true;

                if (GameResult.IndexOfLetterThatWillWritten > 0)
                {
                    ChangeLetterFontAndColor(GameResult.IndexOfLetterThatWillWritten, enLetterStatus.Deleted);
                    GameResult.IndexOfLetterThatWillWritten--;
                    lblRatioWordsPerQuateLength.Text = GameResult.IndexOfLetterThatWillWritten + "/" + GameResult.NumberOfWords;
                    DecreaseCorrectOrWrongTimesInStructAfterRemoveLetter();
                    ChangeLetterFontAndColor(GameResult.IndexOfLetterThatWillWritten, enLetterStatus.Waiting);
                }
                
            }
            
        }

        void EndGame()
        {
            GameResult.Accuracy = (int)(((float)GameResult.CorrectWords / GameResult.NumberOfWords) * 100);
            GameResult.NumberOfLettersPerSeconds = ((float)GameResult.NumberOfWords / GameResult.TimeTakenToCompleteQuateInSeconds);
            timerCountTime.Enabled = false;
        }

        void ShowResult()
        {
            string Line = "";
            Line += $"Accuracy: {GameResult.Accuracy}%" + Environment.NewLine;
            Line += $"Letter Per Second: {GameResult.NumberOfLettersPerSeconds}";
            MessageBox.Show(Line,"Game Result");
        }

        private void rtxtTyping_KeyPress(object sender, KeyPressEventArgs e)
        {
            //to prevent pip sound when write
            e.Handled = true;

            if((int)e.KeyChar == 8 || IsGameEnd()||btnStart.Tag.ToString()=="0")
            {
                return;
            }

            if ( e.KeyChar == rtxtTyping.Text[GameResult.IndexOfLetterThatWillWritten])
            {
                ChangeLetterFontAndColor(GameResult.IndexOfLetterThatWillWritten, enLetterStatus.Correct);
                GameResult.CorrectWords++;

            }
            else
            {
                ChangeLetterFontAndColor(GameResult.IndexOfLetterThatWillWritten, enLetterStatus.Wrong);
                GameResult.WrongWords++;
            }
            GameResult.IndexOfLetterThatWillWritten++;
            lblRatioWordsPerQuateLength.Text = GameResult.IndexOfLetterThatWillWritten + "/" + GameResult.NumberOfWords;
            if (!IsGameEnd())
            {
                
                ChangeLetterFontAndColor(GameResult.IndexOfLetterThatWillWritten, enLetterStatus.Waiting);
            }
            else
            {
                EndGame();
                ShowResult();
                ResetGame();
            }
        }
    }
}
