using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using RestPanda.Requests.Attributes;
using RestPanda.Requests;
using WebServer.Entity;
using System.Net;

namespace WebServer.Requests
{
    [RequestHandler]
    public class HandlerEmail
    {
        private static string FillTable()
        {
            var s = new StringBuilder("<table style=\"border-collapse: collapse\">" + Environment.NewLine);
            s.Append("<tr><th>id</th><th>ФИО</th><th>Возраст</th><th>Почта</th></tr>" + Environment.NewLine);
            foreach (var student in Student.Students)
            {
                s.Append("<tr>").Append($"<td>{student.id}</td>").Append($"<td>{student.fio}</td>")
                    .Append($"<td>{student.age}</td>").Append($"<td>{student.email}</td>").Append("</tr>" + Environment.NewLine);
            }

            s.Append("</table>");
            return s.ToString();
        }

        [Get]
        public static void CommitMessange(PandaRequest request, PandaResponse response)
        {
            var from = new MailAddress("cinema-vyatsu@mail.ru", "Кинотеатр ВятГУ");
            var to = new MailAddress("strooge2105@gmail.com", "Пользователь");
            var msg = new MailMessage(from, to);
            msg.Subject = "PDF file";
            msg.Attachments.Add(
                new Attachment("C://Users/stroo/Downloads/testlab9.pdf"));
            msg.Body = "Тестовое сообщение";
            using (var smtp = new SmtpClient("smtp.mail.ru", 587))
            {
                smtp.Credentials = new NetworkCredential("cinema-vyatsu@mail.ru", "zRqvkv9A579XiSNgNsKF");
                smtp.EnableSsl = true;
                smtp.Send(msg);
            }

            var msg2 = new MailMessage(from, to);
            msg2.Subject = "Html документ";
            msg2.Body = "<img src=\"https://dezhur.com/images/thumbs/normal/ca5x10y947zg6ef82b3d1422478119.jpg\" alt=\"Кинотеатр\"/>" + Environment.NewLine;
            msg2.Body += FillTable();
            msg2.IsBodyHtml = true;
            using (var smtp = new SmtpClient("smtp.mail.ru", 587))
            {
                smtp.Credentials = new NetworkCredential("cinema-vyatsu@mail.ru", "zRqvkv9A579XiSNgNsKF");
                smtp.EnableSsl = true;
                smtp.Send(msg2);
            }

            response.Send("");
        }
    }
}

