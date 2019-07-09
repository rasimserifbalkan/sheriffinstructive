using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SI.App.Models;
using SI.App.Presentation;
using SI.App.Repositories;

namespace SI.App
{
    public partial class Enter : Form
    {
        public IUserRepository Repository { get; }

        public Enter(IUserRepository repository)
        {
            Repository = repository;
            InitializeComponent();
            LoadUsers();

        }

        private void Enter_Load(object sender, EventArgs e)
        {

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
                LoadUsers();
                MessageBox.Show("Kullanıcı Eklendi");
            }


        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı.");
                return;

            }
            SessionData.loginUser = userBindingSource.Current as User;
            SessionData.loginUserId = SessionData.loginUser.ID;
            this.Hide();
            new UiMain(Repository,new SetRepository(),new WordRepository(), new MeaningRepository(),new SettingRepository(),new MemorizationRepository()).ShowDialog();


        }

        private void LoadUsers()
        {
            userBindingSource.DataSource = Repository.List();
        }

        private void BtnWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://rasimserifbalkan.com");
        }
    }
}
