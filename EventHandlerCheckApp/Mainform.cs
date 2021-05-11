using NLog;
using System;
using System.Windows.Forms;

namespace EventHandlerCheckApp
{
    public partial class Mainform : Form
    {
        static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logger.Info("MainForm로드");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = TxtUserID.Text + "\n" + TxtPassword.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result}");
            try
            {
                var val = TxtPassword.Text.Substring(3, 2);
                MessageBox.Show($"{val}");
                logger.Info("제대로 완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외발생 , 관리자에게 문의요망");
                logger.Error("예외발생 , 관리자에게 문의요망");
                logger.Error($"{ex}");
            }

        }



        private void Mainform_Resize(object sender, EventArgs e)
        {

        }
    }
}
