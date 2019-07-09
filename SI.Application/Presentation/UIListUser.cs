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
    public partial class UiListUser : UserControl
    {
        public IUserRepository Repository { get; }
        public UiListUser(IUserRepository repository)
        {
            Repository = repository;
            InitializeComponent();
       
            ReloadDataGrid();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var selectedUser = userBindingSource1.Current as User;
            if (selectedUser != null)
            {
                Action reloadDataGridAction = new Action(ReloadDataGrid);
                
                UiAddUser editUserForm = new UiAddUser(selectedUser, Repository) { Size = StaticProperties.HomePanel.Size };
                editUserForm.ReloadDataGrid = reloadDataGridAction;
                StaticProperties.HomePanel.AddControl(editUserForm);
            }

        }

        void ReloadDataGrid()
        {
            userBindingSource1.DataSource = Repository.List();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedUser = userBindingSource1.Current as User;
            if (selectedUser != null)
            {
                int deletedUserId = selectedUser.ID;
                Repository.Delete(selectedUser.ID);
                ReloadDataGrid();
                MessageBox.Show("Kullanıcı Silindi.");
                if (deletedUserId == SessionData.loginUserId)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }

            }
        }
    }
}
