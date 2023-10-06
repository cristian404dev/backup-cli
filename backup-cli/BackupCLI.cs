
namespace backup_cli
{
    public class BackupCLI
    {
        public static void Main(string[] args)
        {
            Backup b = new Backup("Meu primeiro backup", "C:\\Tests", "C:\\Backups", "Teste");
            b.compressBackup();
        }
    }
}
