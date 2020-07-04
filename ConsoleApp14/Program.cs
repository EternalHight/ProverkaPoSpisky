using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace proverka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите email = ");
            string mail = string.Format(Console.ReadLine());
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);
            if (match.Success)
                Console.Write(mail + " верный емаил     ");
            else
                Console.Write(mail + " неверный емеил   ");

            string result = mail.Substring(mail.IndexOf("@", 0));
            string[] domen = new string[45];
            domen[0] = "@yopmail.fr";
            domen[1] = "@yopmail.net";
            domen[2] = "@cool.fr.nf";
            domen[3] = "@jetable.fr.nf";
            domen[4] = "@nospam.ze.tc";
            domen[5] = "@monemail.fr.nf";
            domen[6] = "@monmail.fr.nf";
            domen[7] = "@yopmail.com";
            domen[8] = "@sharklasers.com";
            domen[9] = "@grr.la";
            domen[10] = "@guerrillamail.biz";
            domen[11] = "@guerrillamail.com";
            domen[12] = "@guerrillamail.de";
            domen[13] = "@guerrillamail.net";
            domen[14] = "@guerrillamail.org";
            domen[15] = "@guerrillamailblock.com";
            domen[16] = "@spam4.me";
            domen[17] = "@TempEMail.net";
            domen[18] = "@spamfree24.org";
            domen[19] = "@spamgourmet.com";
            domen[20] = "@unmail.ru";
            domen[21] = "@mailexpire.com";
            domen[22] = "@yopmail.com";
            domen[23] = "@nomail.xl.cx";
            domen[24] = "@mega.zik.dj";
            domen[25] = "@speed.1s.fr";
            domen[26] = "@courriel.fr.nf";
            domen[27] = "@moncourrier.fr.nf";
            domen[28] = "@msgos.com";
            domen[29] = "@vmani.com";
            domen[30] = "@trbvm.com";
            domen[31] = "@spam.la";
            domen[32] = "@msgos.com";
            domen[33] = "@trbvm.com";
            domen[34] = "@grandmamail.com";
            domen[35] = "@zetmail.com";
            domen[36] = "@6paq.com";
            domen[37] = "@landmail.co";
            domen[38] = "@lastmail.co";
            domen[39] = "@divermail.com";
            domen[40] = "@flurred.com";
            domen[41] = "@yomail.info";
            domen[42] = "@10mail.org";
            domen[43] = "@tryalert.com";
            domen[44] = "@dropmail.me";

            bool found = false;

            for (int i = 0; i < domen.Length; i++)
            {
                if (result == domen[i])
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("Временный емаил");
            else Console.WriteLine("Невременный емаил");

            Console.ReadKey();
        }
    }
}
