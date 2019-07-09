using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SI.App.Repositories;
using SI.App.Models;
using System.Speech.Synthesis;
namespace SI.App.Presentation
{
    public partial class UIShowQuestion : Form
    {
        IWordRepository _wordRepository;
        IMeaningRepository _meaningRepository;
        private IMemorizationRepository _memorizationRepository;
        List<Word> _fistWordList = null;
        QuestionsAndAnswers questionsAndAnswers;
        ISettingRepository _settingRepository;

        int _wordId = 0;
        private int _setId = 0;
        private Action _timer;
        public UIShowQuestion(int SetId, Action timer, IWordRepository wordRepository, IMeaningRepository meaningRepository, IMemorizationRepository memorizationRepository, ISettingRepository settingRepository)
        {
            _meaningRepository = meaningRepository;
            _wordRepository = wordRepository;
            _memorizationRepository = memorizationRepository;
            _settingRepository = settingRepository;

            if (_fistWordList == null)
            {
                _fistWordList = _wordRepository.List(SetId, SessionData.loginUserId) as List<Word>;
            }
            questionsAndAnswers = new QuestionsAndAnswers();
            var word = _fistWordList.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            _wordId = word.ID;
            _setId = SetId;
            _timer = timer;
            questionsAndAnswers.Question = word.WordText;
            var answer = _meaningRepository.Get(x => x.WordId == word.ID);
            questionsAndAnswers.AndAnswer = answer.MeaningWord;
            questionsAndAnswers.AndAnswers = _meaningRepository.List(x => x.ID != answer.ID).OrderBy(x => Guid.NewGuid()).Select(e => e.MeaningWord).Take(4).ToList();
            questionsAndAnswers.AndAnswers.Add(questionsAndAnswers.AndAnswer);


            InitializeComponent();
          
            Opacity = Convert.ToInt32(_settingRepository.Get("QuestionWindowOpacity").SettingValue) / 100D;
            var PlayAnswer = _settingRepository.Get("PlayAnswer").SettingValue;

            txtWord.Text = questionsAndAnswers.Question;

            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);


            int i = 0;
            var pnlSize = pnlAnswers.Size;
            int btnYukseklik = pnlSize.Height / questionsAndAnswers.AndAnswers.Count();
            foreach (var item in questionsAndAnswers.AndAnswers.OrderBy(x => Guid.NewGuid()))
            {
                Button button = new Button();
                button.Text = item;
                button.Name = i.ToString() + "_Btn";
                button.Size = new Size(pnlSize.Width - 2, btnYukseklik);
                button.Click += (object sender, EventArgs e) =>
                {
                    var clickButton = sender as Button;
                    if (clickButton.Text == questionsAndAnswers.AndAnswer)
                    {
                        clickButton.BackColor = Color.Green;

                    }
                    if (PlayAnswer == "1")
                    {
                        SpeechSynthesizer ss = new SpeechSynthesizer();
                        ss.SpeakAsync(button.Text);
                    }
                };

                i++;
                button.Dock = DockStyle.Top;

                pnlAnswers.Controls.Add(button);

            }
            var playQuestion = _settingRepository.Get("PlayQuestion").SettingValue == "1" ? true : false;
            if (playQuestion)
            {
                SpeechSynthesizer ss = new SpeechSynthesizer();
                ss.SpeakAsync(txtWord.Text);
            }
        }

        private void BtnAddMeanings_Click(object sender, EventArgs e)
        {
            /*
             * MeaningWord = questionsAndAnswers.Question,
                WordId = wordId
             *
             */
            _memorizationRepository.Add(new Memorization()
            {
                MemorizationDate = DateTime.Now,
                SetsId = _setId,
                UserId = SessionData.loginUserId,
                WordId = _wordId
            });
            this.Close();
            _timer.Invoke();

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _timer.Invoke();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);

        }

        private void BtnShowAnswer_Click(object sender, EventArgs e)
        {
            pnlAnswers.Controls.Clear();
            Label lblAnswer = new Label();
            lblAnswer.Text = questionsAndAnswers.AndAnswer;

            lblAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblAnswer.Location = new System.Drawing.Point(0, 0);
            lblAnswer.Name = "labelAnswer";
            lblAnswer.Size = new System.Drawing.Size(357, 250);
            lblAnswer.TabIndex = 0;

            lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlAnswers.Controls.Add(lblAnswer);
            var windowsCloser = new System.Threading.Thread(() =>
            {
                System.Threading.Thread.Sleep(4000);
            });
            windowsCloser.Start();
            windowsCloser.Join();

            this.Close();
            _timer.Invoke();





        }

        private void btnAnswerToSound(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.SpeakAsync(txtWord.Text);
        }
    }
}
