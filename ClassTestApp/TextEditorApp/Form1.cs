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

namespace TextEditorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Test\Help\PFRO.log"; // 파일 인코딩 확인
            byte[] result;

            using (FileStream stream = File.Open(filename, FileMode.Open)) 
            //using을 쓰면 file close를 안써도댐
            {
                result = new byte[stream.Length]; // 파일크기만큼 byte만듬 
                await stream.ReadAsync(result, 0, (int)stream.Length);
            }

            richTextBox1.Text = Encoding.UTF8.GetString(result);
        }
    }
}
