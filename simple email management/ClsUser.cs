using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace simple_email_management
{

    class ClsUser
    {
        public static string name, email, pass, attach;
        public static int ID;

        public static void delete()
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            string cmd = "delete from emailUsers where id={0}";
            cmd = string.Format(cmd, ID);
            if (clsDla.NONQUERY(cmd) == true)
            {
                MessageBox.Show("Account deleted!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Somethings wrong! Try again");
            }

        }

        public static void update()
        {
            string cmd = "update emailUsers set name='{0}',pass='{1}',attach='{2}' where id={3} ";
            cmd = string.Format(cmd, name, pass, attach, ID);
            if (clsDla.NONQUERY(cmd) == true)
            {
                MessageBox.Show("Updated successfully!");

            }
            else
            {
                MessageBox.Show("Somethings wrong! Try again.");

            }
        }

        public static bool send(string _to, string _cc, string _bcc, string _sub, string _body, string _attach)
        {
            MailAddress from = new MailAddress(ClsUser.email, ClsUser.name, Encoding.UTF8);
            MailMessage msg = new MailMessage();
            msg.From = from;
            string[] str;
            try {
                if (string.IsNullOrEmpty(_to) == false)
                {
                    str = _to.Split(',');
                    foreach (string s in str)
                    {
                        if (string.IsNullOrEmpty(s)==false)
                        {
                            try
                            {
                                msg.To.Add(new MailAddress(s));
                            }
                            catch { }
                        }
                    }
                }
                if (string.IsNullOrEmpty(_cc) == false)
                {
                str = _cc.Split(',');
                for (int i = 0; i < str.Length; i++)
                {
                    if (string.IsNullOrEmpty(str[i]) == false)
                    {
                        try
                        {
                            msg.CC.Add(new MailAddress(str[i]));
                        }
                        catch { }
                    }
                }

            }
            if (string.IsNullOrEmpty(_bcc) == false)
            {
                str = _bcc.Split(',');
                foreach (string s in str)
                {
                    if (string.IsNullOrEmpty(s))
                    {
                        try
                        {
                            msg.Bcc.Add(new MailAddress(s));
                        }
                        catch { }
                    }
                }
            }
            if (string.IsNullOrEmpty(_attach) == false)
            {
                str = _attach.Split(',');

                foreach (string s in str)
                {
                    if (string.IsNullOrEmpty(s) == false)
                    {
                        try
                        {
                            msg.Attachments.Add(new Attachment(s));
                        }
                        catch { }
                    }
                }

            }
           
            if (string.IsNullOrEmpty(_sub) == true)
            {
                DialogResult dr = MessageBox.Show("Do you want to send an untitled subject email?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return false;
                }
                else
                {
                    _sub = "Without title";
                }
            }
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = _sub;

            if (string.IsNullOrEmpty(_body))
            {
                _body = ClsUser.name;
            }
            msg.BodyEncoding = Encoding.UTF8;
            msg.Body = _body;


               

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(ClsUser.email, ClsUser.pass);
                smtp.EnableSsl = true;
                smtp.Send(msg);
                return true;

        }
        catch(Exception ex){
                MessageBox.Show(ex.Message);
            }







            return false;
        }
    }
}
