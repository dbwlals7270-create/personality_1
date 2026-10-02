namespace WinFormsApp4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            button6 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Location = new Point(703, 48);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "로그아웃";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 2;
            label1.Text = "나의 성향 및 역량 분석";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 80);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 371);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Location = new Point(729, 4);
            button2.Name = "button2";
            button2.Size = new Size(68, 29);
            button2.TabIndex = 5;
            button2.Text = "프로필";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuBar;
            button3.Location = new Point(44, 259);
            button3.Name = "button3";
            button3.Size = new Size(119, 70);
            button3.TabIndex = 5;
            button3.Text = "성향,역량 검사";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuBar;
            button4.Location = new Point(42, 217);
            button4.Name = "button4";
            button4.Size = new Size(119, 73);
            button4.TabIndex = 5;
            button4.Text = "추천 매칭 결과";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuBar;
            button5.Location = new Point(42, 75);
            button5.Name = "button5";
            button5.Size = new Size(119, 72);
            button5.TabIndex = 5;
            button5.Text = "직업 정보 탐색";
            button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 155);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(462, 20);
            label3.TabIndex = 6;
            label3.Text = "아래 항목을 입력하시면 알고리즘이 최적의 직업을 추천해드립니다.";
            // 
            // panel3
            // 
            panel3.Location = new Point(585, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 370);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Location = new Point(578, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 370);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Location = new Point(601, 80);
            panel5.Name = "panel5";
            panel5.Size = new Size(199, 371);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button4);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(600, 80);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 371);
            panel6.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.MenuBar;
            button6.Location = new Point(44, 25);
            button6.Name = "button6";
            button6.Size = new Size(119, 70);
            button6.TabIndex = 6;
            button6.Text = "주요 관심 분야";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.MenuBar;
            button7.Location = new Point(44, 141);
            button7.Name = "button7";
            button7.Size = new Size(119, 70);
            button7.TabIndex = 7;
            button7.Text = "보유 자격증";
            button7.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel6);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "사용자 로그인 정보";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Button button7;
        private Button button6;
    }
}