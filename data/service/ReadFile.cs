using System;

namespace data.service
{
    public class FileReader
    {
      public List<string> schoolZone = new List<string>();
        public void read()
        {
          int counter = 0;  
          string line;  

          // Read the file and display it line by line.  
          System.IO.StreamReader file =   new System.IO.StreamReader(@"c:\grs08.cvs");  
          while((line = file.ReadLine()) != null)  
          {  
            this.schoolZone.Add(line);
            //System.Console.WriteLine (line);  
            counter++;  
          }  

          file.Close();  
          System.Console.WriteLine("There were {0} lines.", counter);  
          // Suspend the screen.  
          System.Console.ReadLine();  
        }
    }
}
