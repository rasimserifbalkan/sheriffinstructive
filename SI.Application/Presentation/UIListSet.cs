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
using SI.App.Models;
using SI.App.Repositories;

namespace SI.App.Presentation
{
    public partial class UiListSet : UserControl
    {
        public ISetRepository Repository { get; }
        private IWordRepository _wordRepository;
        private IMeaningRepository _meaningRepository;
        private ISettingRepository _settingRepository;
        private IMemorizationRepository _memorizationRepository;

        private Action _startTimer;
        public UiListSet(ISetRepository repository, IWordRepository wordRepository, IMeaningRepository meaningRepository, ISettingRepository settingRepository, IMemorizationRepository memorizationRepository)
        {
            Repository = repository;
            _wordRepository = wordRepository;
            _meaningRepository = meaningRepository;
            _settingRepository = settingRepository;
            _memorizationRepository = memorizationRepository;
            InitializeComponent();
            ReloadDataGrid();
            _startTimer = new Action(() =>
            {
                timerStartLearn.Start();
            });
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var editSet = setBindingSource.Current as Set;
            if (editSet != null)
            {
                Action reloadDataGridAction = new Action(ReloadDataGrid);
                UiAddSet editSetForm = new UiAddSet(editSet, Repository) { Size = StaticProperties.HomePanel.Size };
                editSetForm.ReloadDataGrid = reloadDataGridAction;
                StaticProperties.HomePanel.AddControl(editSetForm);

            }


        }

        void ReloadDataGrid()
        {
            setBindingSource.DataSource = Repository.List();
        }

        private void btnListWord_Click(object sender, EventArgs e)
        {
            var selectedSet = setBindingSource.Current as Set;
            if (selectedSet != null)
            {
                var uiAddWord = new UiAddWord(_wordRepository, _meaningRepository, selectedSet.ID) { Size = StaticProperties.HomePanel.Size };
                StaticProperties.HomePanel.AddControl(uiAddWord);
            }
            else
            {
                MessageBox.Show("Set Bulunamadı.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var editSet = setBindingSource.Current as Set;
            if (editSet != null)
            {
                Action reloadDataGridAction = new Action(ReloadDataGrid);

                Repository.Delete(editSet.ID);
                reloadDataGridAction.Invoke();
                MessageBox.Show("Set Silidi.");
            }
        }

        private void BtnStartLearn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["UIMain"].Hide();
            var selectedSet = setBindingSource.Current as Set;
            if (selectedSet != null)
            {
                StaticProperties.SelectedSetId = selectedSet.ID;
                timerStartLearn.Interval = Convert.ToInt32(_settingRepository.Get("QuestionSecondLimit").SettingValue) * 1000;
                timerStartLearn.Start();
            }
            else
            {
                MessageBox.Show("Set Seçmelisiniz.");
            }

        }

        private void TimerStartLearn_Tick(object sender, EventArgs e)
        {
            timerStartLearn.Stop();

            UIShowQuestion showQuestion = new UIShowQuestion(StaticProperties.SelectedSetId, _startTimer, _wordRepository, _meaningRepository, _memorizationRepository, _settingRepository);
            showQuestion.Show();




        }

        private void BtnMemorization_Click(object sender, EventArgs e)
        {
            var selectedSet = setBindingSource.Current as Set;
            if (selectedSet != null)
            {

                StaticProperties.HomePanel.AddControl(new UIListMemorization(_memorizationRepository, _wordRepository, selectedSet) { Size = StaticProperties.HomePanel.Size });
            }

        }

        private void BrnSetExport_Click(object sender, EventArgs e)
        {
            var selectedSet = setBindingSource.Current as Set;
            if (selectedSet != null)
            {

                var set = Repository.ExportSet(selectedSet.ID);
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(set);

                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        StreamWriter file = new StreamWriter(fbd.SelectedPath + "\\" + selectedSet.Name + ".si");
                        file.Write(json);
                        file.Close();
                        MessageBox.Show("Set Kayıt Edildi.");

                    }
                }
            }

        }

        private void BrnSetImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Si Dosyası |*.si";
            file.FilterIndex = 1;
            file.ShowDialog();

            var json = System.IO.File.ReadAllText(file.FileName);
            var set = Newtonsoft.Json.JsonConvert.DeserializeObject<SetExportModel>(json);
            var newSet = new Set()
            {
                Name = set.Name + " " + DateTime.Now.ToString()
                
            };
            Repository.Add(newSet);

            foreach (var item in set.Words)
            {
                var newWord = new Word() {
                    SetId = newSet.ID,
                    WordText = item.WordText

                };
                _wordRepository.Add(newWord);

                var meanings = set.Meanings.Where(x => x.WordId == item.ID).ToList();
                foreach (var mItem in meanings)
                {
                    var newMeaning = new Meaning() {
                        MeaningWord = mItem.MeaningWord,
                        WordId = newWord.ID

                    };
                    _meaningRepository.Add(newMeaning);
                }
            }
            MessageBox.Show("Set İçeri Aktarıldı.");

        }
    }
}
