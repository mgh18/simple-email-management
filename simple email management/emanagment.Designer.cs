namespace simple_email_management
{
    partial class emanagment
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_attach = new System.Windows.Forms.Button();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_bcc = new System.Windows.Forms.TextBox();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.txt_body = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_repass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.add_attach = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.btn_attach);
            this.tabPage1.Controls.Add(this.l5);
            this.tabPage1.Controls.Add(this.l4);
            this.tabPage1.Controls.Add(this.l3);
            this.tabPage1.Controls.Add(this.l2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.txt_subject);
            this.tabPage1.Controls.Add(this.txt_bcc);
            this.tabPage1.Controls.Add(this.txt_cc);
            this.tabPage1.Controls.Add(this.txt_body);
            this.tabPage1.Controls.Add(this.l1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txt_to);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_attach
            // 
            this.btn_attach.Location = new System.Drawing.Point(329, 344);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.Size = new System.Drawing.Size(75, 23);
            this.btn_attach.TabIndex = 14;
            this.btn_attach.Text = "Attach";
            this.btn_attach.UseVisualStyleBackColor = true;
            this.btn_attach.Click += new System.EventHandler(this.btn_attach_Click);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(19, 125);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(31, 15);
            this.l5.TabIndex = 13;
            this.l5.Text = "Text:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(17, 101);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(49, 15);
            this.l4.TabIndex = 12;
            this.l4.Text = "Subject:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(17, 72);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(33, 15);
            this.l3.TabIndex = 11;
            this.l3.Text = "BCC:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(17, 43);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(26, 15);
            this.l2.TabIndex = 10;
            this.l2.Text = "CC:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(72, 93);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(411, 23);
            this.txt_subject.TabIndex = 8;
            // 
            // txt_bcc
            // 
            this.txt_bcc.Location = new System.Drawing.Point(72, 64);
            this.txt_bcc.Name = "txt_bcc";
            this.txt_bcc.Size = new System.Drawing.Size(411, 23);
            this.txt_bcc.TabIndex = 7;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(72, 35);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(411, 23);
            this.txt_cc.TabIndex = 6;
            // 
            // txt_body
            // 
            this.txt_body.Location = new System.Drawing.Point(72, 124);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(411, 216);
            this.txt_body.TabIndex = 3;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(17, 14);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(22, 15);
            this.l1.TabIndex = 2;
            this.l1.Text = "To:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(72, 6);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(411, 23);
            this.txt_to.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inbox";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(8, 177);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(475, 206);
            this.textBox2.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(179, 126);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Save mail";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(98, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Read mail";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Show mails";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(8, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 23);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(480, 112);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.txt_email);
            this.tabPage3.Controls.Add(this.txt_pass);
            this.tabPage3.Controls.Add(this.txt_repass);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txt_username);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(490, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Setting";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Change Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(107, 51);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(117, 23);
            this.txt_email.TabIndex = 9;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(107, 82);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(117, 23);
            this.txt_pass.TabIndex = 8;
            // 
            // txt_repass
            // 
            this.txt_repass.Location = new System.Drawing.Point(107, 113);
            this.txt_repass.Name = "txt_repass";
            this.txt_repass.PasswordChar = '*';
            this.txt_repass.Size = new System.Drawing.Size(117, 23);
            this.txt_repass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(107, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(106, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Download Files";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(107, 22);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(117, 23);
            this.txt_username.TabIndex = 0;
            // 
            // emanagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 419);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "emanagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanagment";
            this.Load += new System.EventHandler(this.emanagment_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CheckBox checkBox1;
        private Button button1;
        private Label label1;
        private TextBox txt_username;
        private TextBox txt_email;
        private TextBox txt_pass;
        private TextBox txt_repass;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label l5;
        private Label l4;
        private Label l3;
        private Label l2;
        private Button button4;
        private TextBox txt_subject;
        private TextBox txt_bcc;
        private TextBox txt_cc;
        private TextBox txt_body;
        private Label l1;
        private Button button3;
        private TextBox txt_to;
        private Button btn_attach;
        private OpenFileDialog add_attach;
        private TextBox textBox2;
        private Button button7;
        private Button button6;
        private Button button5;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}