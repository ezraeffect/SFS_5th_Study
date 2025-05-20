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
/*
 * • Task, async, await을 사용하여 아래 기능을 구현
 * • 버튼을 클릭하여 텍스트 파일을 선택하면, 파일의 내용을 텍스트박스에 표시해주는 프로그램
 *  1. 텍스트 파일을 비동기적으로 읽어오는 ReadFileAsync 메소드 작성
 *  2. StreamReader를 이용하여 파일의 내용을 불러오고, StreamReader에 내장된 ReadToEndAsync() 메소드를 사용하여 읽어오는 부분도 비동기처리
 */
namespace day_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task<string> ReadFileAsync(string path)
        {
            if (!string.IsNullOrWhiteSpace(path) || File.Exists(path))
            {
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader(path))
                    {
                        return await sr.ReadToEndAsync();
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    return e.Message;
                }
            }
            else
            {
                return "파일 경로가 잘못되었습니다";
            }
        }

        private void button_OpenDialog_Click(object sender, EventArgs e)
        {
            DialogResult readResult = openFileDialog1.ShowDialog();
            if (readResult == DialogResult.OK)
            {
                textBox_filePath.Text = openFileDialog1.FileName;
            }
            else { textBox_filePath.Text = string.Empty; }
        }

        private async void button_Start_Click(object sender, EventArgs e)
        {
            string filePath = textBox_filePath.Text;

            string fileText = await ReadFileAsync(filePath);

            textBox_Result.AppendText(fileText);

            textBox_Result.AppendText("\r\n읽기 완료");
        }
    }
}
