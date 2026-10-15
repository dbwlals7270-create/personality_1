using MySqlConnector;
using System;
using System.Windows.Forms;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void TestConnection()
        {
            try
            {
                string connectionString =
                    "Server=127.0.0.1;" +
                    "Port=3306;" +
                    "Database=testdb;" +
                    "Uid=root;" +
                    "Pwd=여기에_비밀번호;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    MessageBox.Show(
                        "MySQL 연결 성공!",
                        "연결 테스트",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "MySQL 연결 실패!\n\n" + ex.Message,
                    "연결 테스트",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // 메인 화면 우측 상단의 [로그인] 버튼을 눌렀을 때 동작하는 이벤트입니다.
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그인 버튼을 클릭했습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RightMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // 로그인 버튼의 모서리를 둥글게 만드는 코드입니다.
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            int borderRadius = 15;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(btn.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, btn.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                btn.Region = new Region(path);
            }
        }

        private void btnCompanySearch_Click(object sender, EventArgs e)
        {
            pnlCompanySearch.Visible = true;
            pnlCompanySearch.BringToFront();

        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            pnlCompanySearch.Visible = false;
        }
    }
}
