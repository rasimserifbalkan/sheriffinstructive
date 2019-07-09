using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SI.App.Repositories;
using SI.App.Models;

namespace SI.App.Presentation
{
    public partial class UIListMemorization : UserControl
    {
        IMemorizationRepository _memorizationRepository;
        IWordRepository _wordRepository;
        IList<Word> _word;
        Set _set;
        public UIListMemorization(IMemorizationRepository memorizationRepository,IWordRepository wordRepository,Set set)
        {
            _memorizationRepository = memorizationRepository;
            _wordRepository = wordRepository;
            _word = _wordRepository.ListMemorizationWord(set.ID, SessionData.loginUserId);
            _set = set;
            InitializeComponent();
            lblSetName.Text = set.Name + " Setinde Ezberlenen Kelime / Cümleler.";
            wordBindingSource.DataSource = _word;
            lblMemCount.Text = wordBindingSource.List.Count.ToString() + " Adet Kelime Ezberlenmiş.";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            wordBindingSource.DataSource = _word.Where(x => x.WordText.ToUpper().Contains(txtSearch.Text.ToUpper()));

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var selected = wordBindingSource.Current as Word;
            if (selected != null)
            {
                var removedMemorization = _memorizationRepository.Get(x => x.WordId == selected.ID && x.SetsId == _set.ID);
                _memorizationRepository.Delete(removedMemorization.ID);
                _word = _wordRepository.ListMemorizationWord(_set.ID, SessionData.loginUserId); wordBindingSource.DataSource = _word;
                MessageBox.Show("Kelime / Cümle Ezberlenenlerden Kaldırıldı.");
                lblMemCount.Text = wordBindingSource.List.Count.ToString()+ " Adet Kelime Ezberlenmiş.";
            }
        }
    }
}
