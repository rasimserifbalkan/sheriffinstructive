using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SI.App.Models;
using SI.App.Repositories;
namespace SI.App.Presentation
{
    public partial class UiAddWord : UserControl
    {
        private IWordRepository _wordRepository;
        private IMeaningRepository _meaningRepository;
        public IList<Word> WordList { get; set; }
        public int _setId = 0;
        public int MeaningWordId = 0;
        private Word _word = null;
        private Meaning _Meaning = null;
        public UiAddWord()
        {
            InitializeComponent();
        }
        public UiAddWord(IWordRepository wordRepository, IMeaningRepository meaningRepository, int setId)
        {
            _wordRepository = wordRepository;
            this._meaningRepository = meaningRepository;
            _setId = setId;

            InitializeComponent();
            btnAddWord.Click += BtnAddWord_Click;
            LoadWords();


        }

        private void BtnAddWord_Click(object sender, EventArgs e)
        {
            if (_word == null)
            {
                AddWord();
            }
            else
            {
                EditWord();
            }


            LoadWords();

        }


        void AddWord()
        {
            if (txtWord.TextLength == 0)
            {
                MessageBox.Show("Kelime / Cümle Giriniz.");
            }
            else if (_wordRepository.Get(txtWord.Text.Trim()) != null)
            {
                MessageBox.Show("Kelime / Cümle Daha Önceden Tanımlanmış.");
            }
            else
            {
                _wordRepository.Add(new Word()
                {
                    SetId = _setId,
                    WordText = txtWord.Text.Trim()
                });
                MessageBox.Show("Kelime / Cümle Eklendi.");
            }
        }

        void EditWord()
        {
            if (txtWord.TextLength == 0)
            {
                MessageBox.Show("Kelime / Cümle Giriniz.");
            }
            else if (_wordRepository.Get(txtWord.Text.Trim()) != null)
            {
                MessageBox.Show("Kelime / Cümle Daha Önceden Tanımlanmış.");
            }
            else
            {
                _word.WordText = txtWord.Text;
                _wordRepository.Update(_word);
                _word = null;
                lblEditAlert.Visible = false;
                btnAddWord.Text = "Ekle";
                MessageBox.Show("Kelime / Cümle Eklendi.");
            }

        }
        void LoadWords()
        {
            WordList = _wordRepository.List();
            wordBindingSource.DataSource = WordList;
        }

        private void BtnEditWord_Click(object sender, EventArgs e)
        {
            var selectedWord = wordBindingSource.Current as Word;
            if (selectedWord != null)
            {
                txtWord.Text = selectedWord.WordText;
                _word = selectedWord;
                lblEditAlert.Visible = true;
                btnAddWord.Text = "Kaydet";
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            wordBindingSource.DataSource = WordList.Where(x => x.WordText.ToUpper().Contains(txtSearch.Text.ToUpper()));
        }

        private void BtnAddMeaningWord_Click(object sender, EventArgs e)
        {
            var selectedWord = wordBindingSource.Current as Word;
            if (selectedWord != null)
            {
                lblSelectedWord.Text = selectedWord.WordText;
                lblSelectedWord.Visible = true;
                MeaningWordId = selectedWord.ID;
            }
        }

        private void WordDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var selectedWord = wordBindingSource.Current as Word;
            if (selectedWord != null)
            {
                lblSelectedWord.Text = selectedWord.WordText;
                lblSelectedWord.Visible = true;
                MeaningWordId = selectedWord.ID;
                meaningBindingSource.DataSource = _meaningRepository.List(x => x.WordId == selectedWord.ID);
            }
        }
        void AddMeaning(Word selectedWord)
        {
            _meaningRepository.Add(new Meaning()
            {

                WordId = selectedWord.ID,
                MeaningWord = txtMeaning.Text.Trim()
            });
           
            MessageBox.Show("Anlam Tanımlandı.");
        }
        void EditMeaning()
        {
            if (_Meaning == null)
            {
                MessageBox.Show("Anlam Seçmelisiniz.");
            }
            else
            {
                _Meaning.MeaningWord = txtMeaning.Text;
                _Meaning = null;
                _meaningRepository.Update(_Meaning);
                btnAddMeaning.Text = "Ekle";
                lblEditAlert2.Visible = false;
                MessageBox.Show("Anlam Düzenlendi.");
            }
          
        }
        private void BtnAddMeaning_Click(object sender, EventArgs e)
        {
           


            var selectedWord = wordBindingSource.Current as Word;
            if (selectedWord == null)
            {
                MessageBox.Show("Kelime Seçmelisiz.");
            }
            else if (_meaningRepository.List(x => x.MeaningWord.ToUpper().Equals(txtMeaning.Text.ToUpper()) && x.WordId == selectedWord.ID).Count > 0)
            {
                MessageBox.Show("Bu Anlam Daha Önceden Eklenmiş.");
               
            }
            else if (txtMeaning.TextLength == 0)
            {
                MessageBox.Show("Anlam Girmelisiniz.");
            }
            else
            {
                if (_Meaning == null)
                {
                    AddMeaning(selectedWord);
                }
                else
                {
                    EditMeaning();
                }
                LoadMeanings();
            }
         
        }

        public void LoadMeanings()
        {
            var selectedWord = wordBindingSource.Current as Word;
            if (selectedWord != null)
            {
                meaningBindingSource.DataSource = _meaningRepository.List(x => x.WordId == selectedWord.ID);
            }
           
        }

        private void BtnEditMeaning_Click(object sender, EventArgs e)
        {
            var selectedMeaning = meaningBindingSource.Current as Meaning;
            if (selectedMeaning != null)
            {
                txtMeaning.Text = selectedMeaning.MeaningWord;
                _Meaning = selectedMeaning;
                lblEditAlert2.Visible = true;
              
                btnAddMeaning.Text = "Kaydet";
            }
        }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            var selectedWord = wordBindingSource.Current as Word;
            if (selectedWord != null)
            {
                _wordRepository.Delete(selectedWord.ID);
                LoadWords();
                MessageBox.Show("Kelime Silindi.");
            }
        }

        private void BtnDeleteMeaning_Click(object sender, EventArgs e)
        {
            var selectedMeaning = meaningBindingSource.Current as Meaning;
            if (selectedMeaning != null)
            {
                _meaningRepository.Delete(selectedMeaning.ID);
                LoadMeanings();
                MessageBox.Show("Anlam Silindi.");
            }
        }
    }
}
