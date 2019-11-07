﻿using System;
using System.Net.Mail;
using System.Text;

namespace EMail_versenden
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("koopakiller@live.de"); //Absender
            mail.To.Add("koopakiller@live.de"); //Empfänger
            mail.Subject = "Das ist der Betreff";
            mail.Body = "Der Inhalt";
            //mail.IsBodyHtml = true; //Nur wenn Body HTML Quellcode ist 
           
            /*
            AlternateView html = AlternateView.CreateAlternateViewFromString("HTML Inhalt", Encoding.UTF8, "text/html");
            LinkedResource img = new LinkedResource(@"C:\image.jpg");//Kopieren Sie die Datei aus dem Projektmappenordner
            img.ContentId = "imgID";
            html.LinkedResources.Add(img); //Bild zu den Resourcen des HTML hinzufügen
            mail.AlternateViews.Add(html); //HTML zur E-Mail hinzufügen
            */

            //Anlage hinzufügen
            mail.Attachments.Add(new Attachment(@"C:\attachment.jpg")); //Kopieren Sie die Datei aus dem Projektmappenordner

            SmtpClient client = new SmtpClient("smtp.live.com", 25); //SMTP Server von Hotmail und Outlook.

            try
            {
                System.Net.NetworkCredential nc = new System.Net.NetworkCredential("koopakiller@live.de", "Passwort");//Anmeldedaten für den SMTP Server
                client.Credentials = nc;

                client.EnableSsl = true; //Die meisten Anbieter verlangen eine SSL-Verschlüsselung

                client.Send(mail); //Senden

                Console.WriteLine("E-Mai wurde versendet");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Senden der E-Mail\n\n{0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
