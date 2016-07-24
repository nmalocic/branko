using System.Net.Mail;
using System.Text;

namespace G2g.Business.Util
{
    public class EmailHelper
    {
        public void SendEmail(string message, string file)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential("coderns@gmail.com", "Okapi021");

            MailMessage mm = new MailMessage("coderns@gmail.com", "bdjuragin@gmail.com", "g2g notification", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            if (!string.IsNullOrEmpty(file))
            {
                mm.Attachments.Add(new Attachment(file));
            }

            client.Send(mm);
        }
    }
}
