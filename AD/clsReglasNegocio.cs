using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net;

namespace DMS.AD
{
    public class clsReglasNegocio
    {

        public void EnviarCorreo(string  mDestinatarios, string strAsunto, string strTexto)
        {

            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("sebastianbustamanteprueba@gmail.com");
                msg.To.Add(mDestinatarios);
                msg.Subject = strAsunto;
                msg.Body = strTexto;
                MailAddress ms = new MailAddress("sebastian1239@hotmail.com");
                msg.CC.Add(ms);
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                sc.Port = 25;
                sc.Credentials = new NetworkCredential("sebastianbustamanteprueba@gmail.com", "Sebas1239.");
                sc.EnableSsl = true;
                sc.Send(msg);

            }catch(Exception ex)
            {
                //Responsibe.write(ex.Message);
            }
          
        }

    }
}