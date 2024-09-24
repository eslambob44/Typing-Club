using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Club
{
    public partial class frmShowResult : Form
    {
        private float _Accuracy, _WordsPerSecond;

        private void frmShowResult_Load(object sender, EventArgs e)
        {
            lblAccuracy.Text = _Accuracy.ToString()+"%";
            pbAccuracy.Value = (int)_Accuracy;
            lblWordsPerSecond.Text = _WordsPerSecond.ToString("0.00");
        }

        public frmShowResult(float Accuracy, float WordsPerSecond)
        {
            _Accuracy = Accuracy;
            _WordsPerSecond = WordsPerSecond;
            InitializeComponent();
        }

        
    }
}
