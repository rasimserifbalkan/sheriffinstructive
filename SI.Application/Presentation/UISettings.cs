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

namespace SI.App.Presentation
{
    public partial class UISettings : UserControl
    {
        ISettingRepository _settingRepository;
        public UISettings(ISettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
            InitializeComponent();
            GetSettings();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var QuestionSecondLimitValue = _settingRepository.Get("QuestionSecondLimit");
            QuestionSecondLimitValue.SettingValue = numQuestionSecondLimit.Value.ToString();
            _settingRepository.Update(QuestionSecondLimitValue);

            var ScreenSizeValue = _settingRepository.Get("ScreenSize");
            ScreenSizeValue.SettingValue = numScreenSize.Value.ToString();
            _settingRepository.Update(ScreenSizeValue);


            var PlayQuestion = _settingRepository.Get("PlayQuestion");
            PlayQuestion.SettingValue = chkPlayQuestion.Checked == true ? "1" : "0";
            _settingRepository.Update(PlayQuestion);

            var QuestionWindowOpacity = _settingRepository.Get("QuestionWindowOpacity");
            QuestionWindowOpacity.SettingValue = ((int)numOpacity.Value).ToString();
            _settingRepository.Update(QuestionWindowOpacity);

            var PlayAnswer = _settingRepository.Get("PlayAnswer");
            PlayAnswer.SettingValue = chkPlayAnswer.Checked == true ? "1" : "0";
            _settingRepository.Update(PlayAnswer);

            MessageBox.Show("Ayarlar Kayıt Edildi.");
            GetSettings();
        }
        void GetSettings()
        {
            numQuestionSecondLimit.Value = Convert.ToInt32(_settingRepository.Get("QuestionSecondLimit").SettingValue);
            numScreenSize.Value = Convert.ToInt32(_settingRepository.Get("ScreenSize").SettingValue);
            chkPlayQuestion.Checked = _settingRepository.Get("PlayQuestion").SettingValue == "1" ? true : false;
            chkPlayAnswer.Checked = _settingRepository.Get("PlayAnswer").SettingValue == "1" ? true : false;
            numOpacity.Value = Convert.ToInt32(_settingRepository.Get("QuestionWindowOpacity").SettingValue);
        }
    }
}
