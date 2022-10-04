using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAGetMail;
namespace simple_email_management
{
     class clsGetmail
    {
        static MailServer server;
        static MailClient client;
        static MailInfo[] objinfo;
        public static bool connection()
        {

            try
            {
                server = new MailServer("imap.gmail.com", ClsUser.email, ClsUser.pass, ServerProtocol.Imap4);
                server.Port = 993;
                server.SSLConnection = true;
                client = new MailClient("tryit");
                client.Connect(server);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            return false;
        }
        public static void SetMailInfo()
        {
            try
            {
                objinfo = client.GetMailInfos();

            }catch(Exception ext)
            {
                objinfo = null;
                MessageBox.Show(ext.Message);
            }
        }

        public static int getcount()
        {
            if (objinfo != null)
                return (objinfo.Length);
            return 0;
        }

        public static Mail GetMail(int i)
        {
            try
            {
                return client.GetMail(objinfo[i]);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void disconnect()
        {
            client.Quit();
        }
    }
}
