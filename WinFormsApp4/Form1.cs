using MySqlConnector;
using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        // 변수를 클래스 내부(필드 위치)로 이동
        string connStr = "Server=localhost;" +
                         "Port=3306;" +
                         "Database=testdb;" +
                         "Uid=root;" +
                         "Pwd=9492;";

        public Form1()
        {
            InitializeComponent();
            TestConnection();
        }

        private void TestConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MessageBox.Show("MySQL 연결성공!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "MySQL 연결실패\n\n" + ex.Message
                );
            }
        }


        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;

            if (id == "god" && password == "9492")
            {
                MainForm mainForm = new MainForm();

                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
            private void buttonRegister_Click(object sender, EventArgs e)
           
        {
            // 회원가입 폼 생성
            RegisterForm registerForm = new RegisterForm();

            // 회원가입 창을 팝업으로 띄우기
            registerForm.ShowDialog();
        }
    }
    }
