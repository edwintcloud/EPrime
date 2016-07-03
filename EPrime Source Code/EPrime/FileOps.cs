using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;
using System.IO;

namespace EPrime
{
    class FileOps
    {
        public FileOps ()
        {
            //Not Used
        }
        
        public List<string> CsvRead(string path)
        {
            List<string> list = new List<string>();
            string[] fields;

            try
            {
                TextFieldParser parser = new TextFieldParser(@path);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData)
                {
                    fields = parser.ReadFields();
                    foreach(string s in fields)
                    {
                        list.Add(s);
                    }
                }
                parser.Close();
            }
            catch (Exception e)
            {
                WriteLog("FileOps.CsvRead(" + path + ") failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public string TxtRead(string path)
        {
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(@path))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                WriteLog("FileOps.TxtRead(" + path + ") failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return text;
        }

        public static void WriteLog(string content)
        {

            string text = String.Format("[{0}]: {1}", DateTime.Now.ToString("G"), content);
            try
            {
                using (StreamWriter sw = File.AppendText(@"logs/log.txt"))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to Write Log File! : " + e);
            }
        }

        public static void SaveFileWrite(string incidentid, string file,string content)
        {
            try
            {
                Directory.CreateDirectory(@"Save_Files/" + incidentid + "/");
                File.WriteAllText(@"Save_Files/" + incidentid + "/" + file + ".txt", content);
            }
            catch (Exception e)
            {
                WriteLog("FileOps.SaveFileWrite(" + "Save_Files/" + incidentid + "/" + file + ".txt" +") failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public static List<string> ReadLog()
        {
            List<string> list = new List<string>();
            try
            {
                if (!File.Exists(@"logs/log.txt")) return list;
                using (StreamReader sw = new StreamReader(@"logs/log.txt"))
                {
                    string line;
                    while ((line = sw.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                WriteLog("FileOps.ReadLog() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }
        public static void DeleteLog()
        {
            try
            {
                File.Delete(@"logs/log.txt");
            }
            catch (Exception e)
            {
                WriteLog("FileOps.DeleteLog() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }
        public static void CleanSaves()
        {
            try
            {
                Directory.GetDirectories(@"Save_Files").Select(f => new DirectoryInfo(f)).Where(f => f.CreationTime < DateTime.Now.AddDays(-10)).ToList().ForEach(f => f.Delete(true));
            }
            catch (Exception e)
            {
                WriteLog("FileOps.CleanSaves() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }
        public static void CleanExports()
        {
            try
            {
                Directory.GetDirectories(@"Cherwell_Exports").Select(f => new DirectoryInfo(f)).Where(f => f.CreationTime < DateTime.Now.AddDays(-10)).ToList().ForEach(f => f.Delete(true));
            }
            catch (Exception e)
            {
                WriteLog("FileOps.CleanExports() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }
    }
}
