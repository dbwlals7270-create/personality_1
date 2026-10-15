namespace WinFormsApp13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCompanySearch = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            RightMain = new Panel();
            pnlCompanySearch = new Panel();
            btnBackHome = new Button();
            btnSearchCompany = new Button();
            grpEnvironment = new GroupBox();
            chkField = new CheckBox();
            chkOffice = new CheckBox();
            chkFocus = new CheckBox();
            chkTeamwork = new CheckBox();
            grpRegion = new GroupBox();
            rdoGyeongnam = new RadioButton();
            rdoBusan = new RadioButton();
            rdoChangwon = new RadioButton();
            grpJob = new GroupBox();
            chkProduction = new CheckBox();
            chkElectronic = new CheckBox();
            chkAIoT = new CheckBox();
            chkSoftware = new CheckBox();
            txtCompanyName = new TextBox();
            lblSearchGuide = new Label();
            lblCompanyName = new Label();
            lblSearchTitle = new Label();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            RightMain.SuspendLayout();
            pnlCompanySearch.SuspendLayout();
            grpEnvironment.SuspendLayout();
            grpRegion.SuspendLayout();
            grpJob.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(btnCompanySearch);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 641);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // btnCompanySearch
            // 
            btnCompanySearch.Cursor = Cursors.Hand;
            btnCompanySearch.FlatAppearance.BorderSize = 0;
            btnCompanySearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnCompanySearch.FlatStyle = FlatStyle.Flat;
            btnCompanySearch.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCompanySearch.ForeColor = Color.White;
            btnCompanySearch.Location = new Point(26, 200);
            btnCompanySearch.Name = "btnCompanySearch";
            btnCompanySearch.Size = new Size(200, 50);
            btnCompanySearch.TabIndex = 4;
            btnCompanySearch.Text = "기업찾기";
            btnCompanySearch.UseVisualStyleBackColor = true;
            btnCompanySearch.Click += btnCompanySearch_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button7.ForeColor = Color.White;
            button7.Location = new Point(26, 560);
            button7.Name = "button7";
            button7.Size = new Size(200, 50);
            button7.TabIndex = 3;
            button7.Text = "고객센터";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button6.ForeColor = Color.White;
            button6.Location = new Point(26, 358);
            button6.Name = "button6";
            button6.Size = new Size(200, 71);
            button6.TabIndex = 2;
            button6.Text = "내가 본 기업/즐겨찾기";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button5.ForeColor = Color.White;
            button5.Location = new Point(26, 273);
            button5.Name = "button5";
            button5.Size = new Size(200, 50);
            button5.TabIndex = 1;
            button5.Text = "마이페이지";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(30, 41, 59);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button4.ForeColor = Color.White;
            button4.Location = new Point(26, 128);
            button4.Name = "button4";
            button4.Size = new Size(200, 50);
            button4.TabIndex = 0;
            button4.Text = "성향검사";
            button4.UseVisualStyleBackColor = false;
            // 
            // RightMain
            // 
            RightMain.BackColor = Color.FromArgb(241, 245, 249);
            RightMain.Controls.Add(pnlCompanySearch);
            RightMain.Controls.Add(button1);
            RightMain.Controls.Add(panel3);
            RightMain.Controls.Add(panel2);
            RightMain.Controls.Add(label1);
            RightMain.Dock = DockStyle.Fill;
            RightMain.Location = new Point(250, 0);
            RightMain.Name = "RightMain";
            RightMain.Padding = new Padding(15);
            RightMain.Size = new Size(725, 641);
            RightMain.TabIndex = 9;
            RightMain.Paint += RightMain_Paint;
            // 
            // pnlCompanySearch
            // 
            pnlCompanySearch.BorderStyle = BorderStyle.FixedSingle;
            pnlCompanySearch.Controls.Add(btnBackHome);
            pnlCompanySearch.Controls.Add(btnSearchCompany);
            pnlCompanySearch.Controls.Add(grpEnvironment);
            pnlCompanySearch.Controls.Add(grpRegion);
            pnlCompanySearch.Controls.Add(grpJob);
            pnlCompanySearch.Controls.Add(txtCompanyName);
            pnlCompanySearch.Controls.Add(lblSearchGuide);
            pnlCompanySearch.Controls.Add(lblCompanyName);
            pnlCompanySearch.Controls.Add(lblSearchTitle);
            pnlCompanySearch.Location = new Point(0, 0);
            pnlCompanySearch.Name = "pnlCompanySearch";
            pnlCompanySearch.Size = new Size(725, 641);
            pnlCompanySearch.TabIndex = 5;
            pnlCompanySearch.Visible = false;
            // 
            // btnBackHome
            // 
            btnBackHome.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnBackHome.Location = new Point(352, 23);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(94, 29);
            btnBackHome.TabIndex = 10;
            btnBackHome.Text = "메인홈으로";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // btnSearchCompany
            // 
            btnSearchCompany.BackColor = Color.Navy;
            btnSearchCompany.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSearchCompany.ForeColor = Color.White;
            btnSearchCompany.Location = new Point(590, 14);
            btnSearchCompany.Name = "btnSearchCompany";
            btnSearchCompany.Size = new Size(116, 58);
            btnSearchCompany.TabIndex = 9;
            btnSearchCompany.Text = "기업 검색";
            btnSearchCompany.UseVisualStyleBackColor = false;
            // 
            // grpEnvironment
            // 
            grpEnvironment.Controls.Add(chkField);
            grpEnvironment.Controls.Add(chkOffice);
            grpEnvironment.Controls.Add(chkFocus);
            grpEnvironment.Controls.Add(chkTeamwork);
            grpEnvironment.Location = new Point(404, 218);
            grpEnvironment.Name = "grpEnvironment";
            grpEnvironment.Size = new Size(308, 410);
            grpEnvironment.TabIndex = 6;
            grpEnvironment.TabStop = false;
            grpEnvironment.Text = "선호하는 근무환경";
            // 
            // chkField
            // 
            chkField.AutoSize = true;
            chkField.Location = new Point(6, 175);
            chkField.Name = "chkField";
            chkField.Size = new Size(131, 24);
            chkField.TabIndex = 3;
            chkField.Text = "현장 업무 중심";
            chkField.UseVisualStyleBackColor = true;
            // 
            // chkOffice
            // 
            chkOffice.AutoSize = true;
            chkOffice.Location = new Point(6, 127);
            chkOffice.Name = "chkOffice";
            chkOffice.Size = new Size(131, 24);
            chkOffice.TabIndex = 2;
            chkOffice.Text = "실내 사무 중심";
            chkOffice.UseVisualStyleBackColor = true;
            // 
            // chkFocus
            // 
            chkFocus.AutoSize = true;
            chkFocus.Location = new Point(6, 80);
            chkFocus.Name = "chkFocus";
            chkFocus.Size = new Size(161, 24);
            chkFocus.TabIndex = 1;
            chkFocus.Text = "혼자 집중하는 환경";
            chkFocus.UseVisualStyleBackColor = true;
            // 
            // chkTeamwork
            // 
            chkTeamwork.AutoSize = true;
            chkTeamwork.Location = new Point(6, 33);
            chkTeamwork.Name = "chkTeamwork";
            chkTeamwork.Size = new Size(176, 24);
            chkTeamwork.TabIndex = 0;
            chkTeamwork.Text = "팀원과 협력하는 환경";
            chkTeamwork.UseVisualStyleBackColor = true;
            // 
            // grpRegion
            // 
            grpRegion.Controls.Add(rdoGyeongnam);
            grpRegion.Controls.Add(rdoBusan);
            grpRegion.Controls.Add(rdoChangwon);
            grpRegion.Location = new Point(20, 413);
            grpRegion.Name = "grpRegion";
            grpRegion.Size = new Size(368, 215);
            grpRegion.TabIndex = 5;
            grpRegion.TabStop = false;
            grpRegion.Text = "희망 근무지역";
            // 
            // rdoGyeongnam
            // 
            rdoGyeongnam.AutoSize = true;
            rdoGyeongnam.Location = new Point(266, 67);
            rdoGyeongnam.Name = "rdoGyeongnam";
            rdoGyeongnam.Size = new Size(95, 24);
            rdoGyeongnam.TabIndex = 8;
            rdoGyeongnam.TabStop = true;
            rdoGyeongnam.Text = "경남 전체";
            rdoGyeongnam.UseVisualStyleBackColor = true;
            // 
            // rdoBusan
            // 
            rdoBusan.AutoSize = true;
            rdoBusan.Location = new Point(131, 67);
            rdoBusan.Name = "rdoBusan";
            rdoBusan.Size = new Size(60, 24);
            rdoBusan.TabIndex = 7;
            rdoBusan.TabStop = true;
            rdoBusan.Text = "부산";
            rdoBusan.UseVisualStyleBackColor = true;
            // 
            // rdoChangwon
            // 
            rdoChangwon.AutoSize = true;
            rdoChangwon.Location = new Point(6, 65);
            rdoChangwon.Name = "rdoChangwon";
            rdoChangwon.Size = new Size(60, 24);
            rdoChangwon.TabIndex = 6;
            rdoChangwon.TabStop = true;
            rdoChangwon.Text = "창원";
            rdoChangwon.UseVisualStyleBackColor = true;
            // 
            // grpJob
            // 
            grpJob.Controls.Add(chkProduction);
            grpJob.Controls.Add(chkElectronic);
            grpJob.Controls.Add(chkAIoT);
            grpJob.Controls.Add(chkSoftware);
            grpJob.Location = new Point(20, 218);
            grpJob.Name = "grpJob";
            grpJob.Size = new Size(368, 189);
            grpJob.TabIndex = 4;
            grpJob.TabStop = false;
            grpJob.Text = "희망 직무";
            // 
            // chkProduction
            // 
            chkProduction.AutoSize = true;
            chkProduction.Location = new Point(172, 71);
            chkProduction.Name = "chkProduction";
            chkProduction.Size = new Size(91, 24);
            chkProduction.TabIndex = 3;
            chkProduction.Text = "생산기술";
            chkProduction.UseVisualStyleBackColor = true;
            // 
            // chkElectronic
            // 
            chkElectronic.AutoSize = true;
            chkElectronic.Location = new Point(6, 71);
            chkElectronic.Name = "chkElectronic";
            chkElectronic.Size = new Size(94, 24);
            chkElectronic.TabIndex = 2;
            chkElectronic.Text = "전기·전자";
            chkElectronic.UseVisualStyleBackColor = true;
            // 
            // chkAIoT
            // 
            chkAIoT.AutoSize = true;
            chkAIoT.Location = new Point(172, 33);
            chkAIoT.Name = "chkAIoT";
            chkAIoT.Size = new Size(97, 24);
            chkAIoT.TabIndex = 1;
            chkAIoT.Text = "AIoT 제어";
            chkAIoT.UseVisualStyleBackColor = true;
            // 
            // chkSoftware
            // 
            chkSoftware.AutoSize = true;
            chkSoftware.Location = new Point(6, 33);
            chkSoftware.Name = "chkSoftware";
            chkSoftware.Size = new Size(160, 24);
            chkSoftware.TabIndex = 0;
            chkSoftware.Text = "AI 소프트웨어 개발";
            chkSoftware.UseVisualStyleBackColor = true;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(17, 142);
            txtCompanyName.Multiline = true;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(266, 35);
            txtCompanyName.TabIndex = 3;
            // 
            // lblSearchGuide
            // 
            lblSearchGuide.AutoSize = true;
            lblSearchGuide.Location = new Point(17, 72);
            lblSearchGuide.Name = "lblSearchGuide";
            lblSearchGuide.Size = new Size(272, 20);
            lblSearchGuide.TabIndex = 2;
            lblSearchGuide.Text = "원하는 기업과 직무 조건을 선택하세요.";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.BackColor = Color.Navy;
            lblCompanyName.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblCompanyName.ForeColor = Color.White;
            lblCompanyName.Location = new Point(17, 107);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(108, 25);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "기업명 검색";
            // 
            // lblSearchTitle
            // 
            lblSearchTitle.AutoSize = true;
            lblSearchTitle.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblSearchTitle.Location = new Point(17, 14);
            lblSearchTitle.Name = "lblSearchTitle";
            lblSearchTitle.Size = new Size(329, 46);
            lblSearchTitle.TabIndex = 0;
            lblSearchTitle.Text = "JOB GPS · 기업찾기";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(618, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 41);
            button1.TabIndex = 2;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = true;
            button1.Paint += button1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(463, 446);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 177);
            panel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(82, 135);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "재검사";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox3.Location = new Point(92, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 30);
            textBox3.TabIndex = 1;
            textBox3.Text = "완료";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(51, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 30);
            textBox1.TabIndex = 0;
            textBox1.Text = "현재 성향검사 상태";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox2);
            panel2.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            panel2.ForeColor = Color.FromArgb(15, 23, 42);
            panel2.Location = new Point(18, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 341);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 43);
            textBox2.TabIndex = 0;
            textBox2.Text = "기업 정보";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 0;
            label1.Text = "JOB GPS";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(220, 0);
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(975, 641);
            Controls.Add(RightMain);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "JOB GPS";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            RightMain.ResumeLayout(false);
            RightMain.PerformLayout();
            pnlCompanySearch.ResumeLayout(false);
            pnlCompanySearch.PerformLayout();
            grpEnvironment.ResumeLayout(false);
            grpEnvironment.PerformLayout();
            grpRegion.ResumeLayout(false);
            grpRegion.PerformLayout();
            grpJob.ResumeLayout(false);
            grpJob.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button4;
        private Button button7;
        private Button button6;
        private Button button5;
        private Panel RightMain;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Button btnCompanySearch;
        private Panel pnlCompanySearch;
        private Label lblSearchGuide;
        private Label lblCompanyName;
        private Label lblSearchTitle;
        private GroupBox grpJob;
        private CheckBox chkProduction;
        private CheckBox chkElectronic;
        private CheckBox chkAIoT;
        private CheckBox chkSoftware;
        private TextBox txtCompanyName;
        private GroupBox grpEnvironment;
        private GroupBox grpRegion;
        private RadioButton rdoGyeongnam;
        private RadioButton rdoBusan;
        private RadioButton rdoChangwon;
        private Button btnSearchCompany;
        private CheckBox chkField;
        private CheckBox chkOffice;
        private CheckBox chkFocus;
        private CheckBox chkTeamwork;
        private Button btnBackHome;
    }
}
