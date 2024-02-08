using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioEmailSMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            //Dedo nervoso
            btnEnviarEmail.Enabled = false;

            //email destinatario
            string emailDestinatario = txtEmailDestinatario.Text;

            //assunto
            string emailAssunto = txtEmailAssunto.Text;

            //mensagem
            string emailMensagem = txtEmailMensagem.Text;

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("rafael-fullstack@outlook.com");
            mail.To.Add(emailDestinatario);
            mail.Subject = emailAssunto;
            mail.Body = emailMensagem;

            using (var smtp = new SmtpClient("smtp.office365.com", 587))
            {
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("coloque aqui o seu email", "coloque aqui a senha");
                try
                {
                    smtp.Send(mail);

                    MessageBox.Show("Email enviado!");

                    txtEmailDestinatario.Text = string.Empty;
                    txtEmailAssunto.Text = string.Empty;
                    txtEmailMensagem.Text = string.Empty;
                    btnEnviarEmail.Enabled= true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Falha ao enviar email");
                }
            }
        }
    }
}
