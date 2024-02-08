# Email SMTP com C#

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
    
         mail.From = new MailAddress("coloque aqui o seu email");
         mail.To.Add(emailDestinatario);
         mail.Subject = emailAssunto;
         mail.Body = emailMensagem;
    
         using (var smtp = new SmtpClient("coloque aqui o endereço SMTP do seu email", 587))
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

![image](https://github.com/365rafael/EnvioEmailSMTP/assets/97065934/df3a12c6-b753-4810-af16-56056e20adfb)
