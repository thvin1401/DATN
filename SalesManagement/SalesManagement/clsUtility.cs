using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace SalesManagement
{
    public static class clsUtility
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(clsUtility));

        private const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string numbers = "0123456789";
        private const string symbols = "!@#$%^&*()";

        public static bool sendMail(string email, string subject, string body, string content)
        {
            try
            {
                var smtpClient = new SmtpClient(clsConfig.smtpClient)
                {
                    UseDefaultCredentials = false,
                    Port = 587,
                    Credentials = new NetworkCredential(clsConfig.systemEmail, clsConfig.systemEmailPassword),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(clsConfig.systemEmail),
                    Subject = subject,
                    Body = body + " : " + content,
                    IsBodyHtml = false,
                };
                mailMessage.To.Add(email);

                smtpClient.Send(mailMessage);

                return true;
            }
            catch (Exception ex)
            {
                logger.Error($"Error sending email: {ex.Message}");
                return false;
            }
        }

        public static string GenerateRandomPassword()
        {
            Random random = new Random();

            int length = random.Next(8, 21);

            string password = new string(new[]
            {
            upperCase[random.Next(upperCase.Length)],
            lowerCase[random.Next(lowerCase.Length)],
            numbers[random.Next(numbers.Length)],
            symbols[random.Next(symbols.Length)]
            });

            string allChars = upperCase + lowerCase + numbers + symbols;
            password += new string(Enumerable.Repeat(allChars, length - 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            password = new string(password.ToCharArray().OrderBy(_ => random.Next()).ToArray());

            return password;
        }

        public static bool IsConnectedToInternet()
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("www.google.com", 3000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetIpAddress()
        {
            try
            {
                string hostName = Dns.GetHostName();

                IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);

                foreach (IPAddress ip in ipAddresses)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string getUserTypeString(int type)
        {
            switch (type)
            {
                case 0:
                    {
                        return "[Owner] ";
                    }
                case 1:
                    {
                        return "[Manager] ";
                    }
                case 2:
                    {
                        return "[Customer] ";
                    }
                case 3:
                    {
                        return "[Provider] ";
                    }
                case 4:
                    {
                        return "[Debt owner] ";
                    }
                default:
                    {
                        return string.Empty;
                    }
            }
        }
    }
}
