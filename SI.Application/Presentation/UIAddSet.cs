using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SI.App.Models;
using SI.App.Repositories;

namespace SI.App.Presentation
{
    public partial class UiAddSet : UserControl
    {
        private ISetRepository Repository { get; }
        private Set _editSet = null;
        public Action ReloadDataGrid = null;
        public UiAddSet(ISetRepository repository)
        {
            Repository = repository;

            InitializeComponent();
            btnAddSet.Click += BtnAddSet_Click;
            Text = "Kullanıc Ekle";
           
        }
        public UiAddSet(Set editSet, ISetRepository repository)
        {
            _editSet = editSet;
            Repository = repository;
            InitializeComponent();
            txtSetName.Text = editSet.Name;
            btnAddSet.Click += BtnEditUser_Click;
            Text = $"{editSet.Name} Seti Düzenleniyor.";
        }
        private void BtnAddSet_Click(object sender, EventArgs e)
        {
            if (txtSetName.TextLength == 0)
            {
                MessageBox.Show("Set Adı Giriniz.");
            }
            else if (Repository.Get(txtSetName.Text) != null)
            {
                MessageBox.Show("Set Daha Önceden Tanımlanmış.");
            }
            else
            {
                Repository.Add(new Set()
                {
                    Name = txtSetName.Text
                });
                MessageBox.Show("Set Eklendi.");
            }
        }
        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            if (txtSetName.TextLength == 0)
            {
                MessageBox.Show("Set Adı Giriniz.");
            }
            else if (Repository.Get(txtSetName.Text) != null)
            {
                MessageBox.Show("Set Daha Önceden Tanımlanmış.");
            }
            else
            {
                _editSet.Name = txtSetName.Text;
                Repository.Update(_editSet);
                ReloadDataGrid.Invoke();
                MessageBox.Show("Set Düzenlendi.");
            }
        }
    }
}
