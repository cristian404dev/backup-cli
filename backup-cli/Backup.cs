using System;
using System.IO;
using Ionic.Zip;

namespace backup_cli
{
    public class Backup
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Password { get; set; }

        public Backup(string name, string source, string destination, string password)
        {
            DateTime dt = DateTime.Now;
            string formattedDate = dt.ToString("HH-mm-ss_dd-M-yyyy");
            Name = name+" - "+formattedDate;
            Source = source;
            Destination = destination;
            Password = password;
        }


        public void compressBackup()
        {
            try
            {
                using(ZipFile zip = new ZipFile())
                {
                    zip.AddDirectory(Source);

                    zip.Password = Password;

                    zip.Save(Path.Combine(Destination, Name+".zip"));
                }
                Console.WriteLine("Compressed With Succesfully!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error:" + ex.Message);
            }

        }

    }
}
