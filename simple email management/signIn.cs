using System.Data;

namespace simple_email_management
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _name = _username.Text;
            string _password = _pass.Text;
            string e_mail = _email.Text;
            char attach;
            if (checkBox1.Checked == true)
            {
                attach = 'y';
            }
            else
            {
                attach = 'n';
            }
            if (clsDla.validmail(e_mail) == false)
            {
                MessageBox.Show("Email is not valid!");
                return;
            }
            string cmd = "insert into emailUsers (name,pass,email,attach) values ('{0}','{1}','{2}','{3}') ";
            cmd = string.Format(cmd, _name, _password, e_mail, attach);


            if (clsDla.NONQUERY(cmd) == true)
            {
                MessageBox.Show("Signed-in successfully.");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
                //  string cmd1 = "select * from emailUsers where email='{0}'";
                //cmd1 = string.Format(cmd1, e_mail);
                //DataTable dt = clsDla.Select(cmd1);
                //if (dt.Rows[0][3] != null)
                //{
                //  MessageBox.Show("the email already exists!");

                //}

                //else {

            }
               
            
            else
            {
                MessageBox.Show("Somethings wrong.Try again!");
            }

            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _email = txt_email.Text;
            string _pass = txt_pass.Text;

            string cmd = "select * from emailUsers where email='{0}' and pass='{1}'";
            cmd = string.Format(cmd, _email, _pass);

            DataTable dt = clsDla.Select(cmd);
            if (dt.Rows.Count == 1)
            {
                ClsUser.ID = int.Parse(dt.Rows[0][0].ToString());
                ClsUser.name=dt.Rows[0][1].ToString();
                ClsUser.pass = dt.Rows[0][2].ToString();
                ClsUser.email = dt.Rows[0][3].ToString();
                ClsUser.attach = dt.Rows[0][4].ToString();
                emanagment em = new emanagment();
                this.Hide();
                em.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Username or Password is not correct!");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}