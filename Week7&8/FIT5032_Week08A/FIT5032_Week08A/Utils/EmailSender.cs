using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FIT5032_Week08A.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "This is being hidden";

        public void Send(String toEmail, String subject, String contents, HttpPostedFileBase postedFile)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("zwq19980115@gmail.com", "FIT5032 Example Email User");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            

            if (postedFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    // 1. convert input file into inputStream
                    postedFile.InputStream.CopyTo(memoryStream);
                    // 2. convert inputStream to byte array
                    byte[] bytes = memoryStream.ToArray();
                    Attachment attachment = new Attachment();

                    // 3. convert to base64 type(String)
                    attachment.Content = Convert.ToBase64String(bytes);
                    attachment.Filename = postedFile.FileName;

                    // 4. Add this attachment to email message
                    msg.AddAttachment(attachment.Filename,attachment.Content);

                }
            }

            var response = client.SendEmailAsync(msg);
        }

    }
}