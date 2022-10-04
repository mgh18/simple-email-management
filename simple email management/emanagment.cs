using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAGetMail;

namespace simple_email_management
{
    public partial class emanagment : Form
    {
        private string attach;
        Mail EMAIL;
        int index;
        public emanagment()
        {
            InitializeComponent();
        }

        private void emanagment_Load(object sender, EventArgs e)
        {
            txt_username.Text = ClsUser.name;
            txt_email.Text = ClsUser.email;
            if(ClsUser.attach == "y")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            attach = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsUser.delete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_pass.Text != "")
            {
                if(txt_pass.Text != txt_repass.Text)
                {
                    MessageBox.Show("Password and re-password aren't the same.Try again!");
                    return;
                }
                else
                {
                    ClsUser.name = txt_username.Text;
                    ClsUser.pass = txt_pass.Text;
                    if(checkBox1.Checked == true)
                    {
                        ClsUser.attach = "y";
                    }
                    else
                    {
                        ClsUser.attach = "n";
                    }
                    ClsUser.update();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btn_attach_Click(object sender, EventArgs e)
        {
            DialogResult dr = add_attach.ShowDialog();
            if (dr == DialogResult.OK)
            {
                attach += (add_attach.FileName + ",");
                MessageBox.Show(attach);
            }
        }
        private void clean()
        {
            txt_to.Text = txt_bcc.Text = txt_cc.Text = txt_subject.Text = txt_body.Text = String.Empty;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _to = txt_to.Text;
            string _bcc = txt_bcc.Text;
            string _cc=txt_cc.Text;
            string _sub = txt_subject.Text;
            string _body = txt_body.Text;
            
            if(ClsUser.send(_to, _cc, _bcc, _sub,_body, attach)==true)
            {
                MessageBox.Show("Messege sent successfully.");
                clean();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Number");
            dt.Columns.Add("From");
            dt.Columns.Add("Subject");
            dt.Columns.Add("Date");

            if (clsGetmail.connection() == true)
            {
                clsGetmail.SetMailInfo();
                int count = clsGetmail.getcount();
                for ( int i = 0; i < count; i++)
                {
                    EMAIL = clsGetmail.GetMail(i);
                    dt.Rows.Add(i.ToString(),EMAIL.From.ToString(), EMAIL.Subject.ToString(), EMAIL.ReceivedDate.ToString());

                }
                clsGetmail.disconnect(); 
            }
            else
            {
                MessageBox.Show("Connection to server failed.");
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clsGetmail.connection();
            EMAIL = clsGetmail.GetMail(index);
            textBox1.Text = EMAIL.Subject.ToString();
            textBox2.Text = EMAIL.TextBody.ToString();
            DialogResult dr = DialogResult.No;
            if(ClsUser.attach=="n" && EMAIL.Attachments.Length!=0)
            {
                dr = MessageBox.Show("Do You Want to recieve the attached file?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            if(dr == DialogResult.Yes || ClsUser.attach == "y")
            {
                Attachment[] attachs = EMAIL.Attachments;
                foreach(Attachment att in attachs)
                {
                    att.SaveAs(att.Name, true);

                }
            }
            clsGetmail.disconnect();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EMAIL.SaveAs(index.ToString()+".eml",true);
        }
    }
}
