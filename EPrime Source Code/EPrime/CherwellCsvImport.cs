using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;

namespace EPrime
{
    class CherwellCsvImport
    {
        private List<string> Service = new List<string>();
        private List<string> Category = new List<string>();
        private List<string> Subcategory = new List<string>();

        public  CherwellCsvImport()
        {
            string[] fields;

            try
            {
                TextFieldParser parser = new TextFieldParser(@"Resources/CherwellExport.csv");
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                string line = parser.ReadLine();
                while (!parser.EndOfData)
                {
                    fields = parser.ReadFields();
                    Service.Add(fields[0]);
                    Category.Add(fields[1]);
                    Subcategory.Add(fields[2]);
                }
                parser.Close();
            }
            catch (Exception e)
            {
                FileOps.WriteLog("CherwellCsvImport() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public List<string> getService()
        {
            return removeDuplicates(Service);
        }

        public List<string> getCategory()
        {
            return removeDuplicates(Category);
        }

        public List<string> getSubcategory()
        {
            return removeDuplicates(Subcategory);
        }

        public List<string> returnCategories(string service)
        {
            List<string> list = new List<string>();
            for(int i=0;i<Service.Count;i++)
            {
                if(Service[i] == service)
                {
                    list.Add(Category[i]);
                }
            }
            return removeDuplicates(list);
        }
        private List<string> removeDuplicates(List<string> input)
        {
            return (new HashSet<string>(input)).ToList();
        }
        public List<string> returnSubcategories(string service, string category)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < Service.Count; i++)
            {
                if (Service[i] == service && Category[i] == category)
                {
                    list.Add(Subcategory[i]);
                }
            }
            return removeDuplicates(list);
        }
    }
}
