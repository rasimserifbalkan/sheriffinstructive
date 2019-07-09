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

namespace SI.App.Presentation
{
    public partial class UiMain : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly ISetRepository _setRepository;
        private IWordRepository _wordRepository;
        private IMeaningRepository _meaningRepository;
        private ISettingRepository _settingRepository;
        private IMemorizationRepository _memorizationRepository;
        public UiMain(IUserRepository userRepository, ISetRepository setRepository, IWordRepository wordRepository, IMeaningRepository meaningRepository, ISettingRepository settingRepository, IMemorizationRepository memorizationRepository)
        {
            _userRepository = userRepository;
            _setRepository = setRepository;
            _wordRepository = wordRepository;
            _meaningRepository = meaningRepository;
            _settingRepository = settingRepository;
            _memorizationRepository = memorizationRepository;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            StaticProperties.HomePanel = homePanel;
            Text = "Sheriff Instructive";
            
        }

        private void MenuAddUser_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UiAddUser(_userRepository) { Size = StaticProperties.HomePanel.Size });
        
         
        }

        private void KullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            StaticProperties.HomePanel.AddControl(new UiListUser(_userRepository) { Size = StaticProperties.HomePanel.Size });
        }

        private void KullanıcıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void SetListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UiListSet(_setRepository, _wordRepository, _meaningRepository,_settingRepository, _memorizationRepository) { Size = StaticProperties.HomePanel.Size });
        }

        private void MenuAddSet_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UiAddSet(_setRepository) { Size = StaticProperties.HomePanel.Size });
        }

        private void KelimeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UiListSet(_setRepository, _wordRepository, _meaningRepository,_settingRepository, _memorizationRepository) { Size = StaticProperties.HomePanel.Size });
        }

        private void AyarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UISettings(_settingRepository) { Size = StaticProperties.HomePanel.Size });
           
        }

        private void KelimeListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UiListSet(_setRepository, _wordRepository, _meaningRepository,_settingRepository, _memorizationRepository) { Size = StaticProperties.HomePanel.Size });
        }

        private void UiMain_Load(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UiListSet(_setRepository, _wordRepository, _meaningRepository, _settingRepository, _memorizationRepository) { Size = StaticProperties.HomePanel.Size });
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void MenuHome_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
        
            Environment.Exit(0);
        }

        private void İçeriSetAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UiListSet(_setRepository, _wordRepository, _meaningRepository, _settingRepository, _memorizationRepository) { Size = StaticProperties.HomePanel.Size });
        }

        private void DışarıSetAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UiListSet(_setRepository, _wordRepository, _meaningRepository, _settingRepository, _memorizationRepository) { Size = StaticProperties.HomePanel.Size });
        }

        private void ProgramHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://rasimserifbalkan üzerinden program ile ilgili bilgi alabilirsiniz.","SI V1.0");
        }

        private void YazılımcıHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticProperties.HomePanel.AddControl(new UIAboutUs() { Size = StaticProperties.HomePanel.Size });
        }
    }
}
