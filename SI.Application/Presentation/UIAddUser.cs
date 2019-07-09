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
    public partial class UiAddUser : UserControl
    {
        private IUserRepository Repository { get; }
        private User _editUser = null;
        public Action ReloadDataGrid = null;

        public UiAddUser(IUserRepository repository)
        {
            Repository = repository;
          
            InitializeComponent();
            btnAddUser.Click += BtnAddUser_Click;
            Text = "Kullanıc Ekle";
        }

        public UiAddUser(User editUser, IUserRepository repository)
        {
            _editUser = editUser;
            Repository = repository;
            InitializeComponent();
            txtUser.Text = editUser.Name;
            btnAddUser.Click += BtnEditUser_Click;
            Text = $"{editUser.Name} Kullanıcısı Düzenleniyor.";
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUser.TextLength == 0)
            {
                MessageBox.Show("Kullanıcı Adı Giriniz.");
            }
            else if (Repository.Get(txtUser.Text) != null)
            {
                MessageBox.Show("Kullanıcı Daha Önceden Tanımlanmış.");
            }
            else
            {
                Repository.Add(new User()
                {
                    Name = txtUser.Text
                });
                MessageBox.Show("Kullanıcı Eklendi.");
            }
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            if (txtUser.TextLength == 0)
            {
                MessageBox.Show("Kullanıcı Adı Giriniz.");
            }
            else if (Repository.Get(txtUser.Text) != null)
            {
                MessageBox.Show("Kullanıcı Daha Önceden Tanımlanmış.");
            }
            else
            {
                _editUser.Name = txtUser.Text;
                Repository.Update(_editUser);
                ReloadDataGrid.Invoke();
                MessageBox.Show("Kullanıcı Düzenlendi.");
            }
        }
    }
}
