using System.Diagnostics;

namespace backup_cli
{
    public class MyProcess
    {
        public string Name { get; set; }

        public MyProcess(string name) => Name = name;

        private void KillProcess()
        {
            Process[] processes = Process.GetProcessesByName(Name);
            foreach (Process process in processes)
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();  
                    process.Dispose();

                } catch  (Exception ex) 
                { 
                    Console.WriteLine(ex.Message);  
                        
                }
            }
        }
    }
}
