using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class TextAnalyzer : Form
    {

        internal Dictionary Dictionary { get; set; }

        public TextAnalyzer()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            Dictionary = new Dictionary();
            Dictionary.LoadWords();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            var wordVerifier = new WordVerifier();
            List<string> inputWords = wordVerifier.DivideStringIntoWords(richTextBoxInput.Text);
            VerifyInput(inputWords);
        }

        private void VerifyInput(List<string> inputWords)
        {
            var correctWords = new List<CorrectWord>();
            richTextBoxErrors.Text = "";
            richTextBoxCounts.Text = "";
            progressBar1.Maximum = inputWords.Count();
            foreach (var word in inputWords)
            {
                progressBar1.Increment(1);
                if (Dictionary.Contains(word.ToLower()))
                {
                    var checkExistence = from correctWord in correctWords
                                         where correctWord.Word.Equals(word.ToLower())
                                         select correctWord;

                    if (checkExistence.Count() == 0)
                    {
                        correctWords.Add(new CorrectWord(word.ToLower()));
                    }
                    else
                    {
                        checkExistence.First().Counts++;
                    }
                }
                else
                {
                    richTextBoxErrors.Text += word + "\n";
                }
            }

            // Passing correct words into richTextBoxCounts
            foreach (var word in correctWords)
            {
                richTextBoxCounts.Text += word.Word + " - " + word.Counts + "\n";
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void errorsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
