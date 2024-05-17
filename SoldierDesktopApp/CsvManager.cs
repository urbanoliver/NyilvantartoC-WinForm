
using CsvHelper;

using System.Globalization;

using CsvHelper.Configuration;


namespace SoldierDesktopApp
{
    public class CsvManager
    {
        private Checker c = new Checker();

        public CsvManager() {
        
        }

        public static void Reader(DataGridView dtgv)
        {
            List<Elements> records;
           

            using (var reader = new StreamReader(@"C:\Users\justf\source\repos\SoldierDesktopApp\SoldierDesktopApp\soldiers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Elements>().ToList();
            }
            dtgv.DataSource = records;   


        }



        public static void Insert(string id, string name, string rank, string age, string beginOfService)
        {

            List<Elements> records;

            records = new List<Elements>() 
            {
                new Elements() { ID = id, Name = name, Rank = rank, Age = age, BeginOfService = beginOfService },
            };

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                
                HasHeaderRecord = false,
            };
            using (var stream = File.Open(@"C:\Users\justf\source\repos\SoldierDesktopApp\SoldierDesktopApp\soldiers.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(records);
            }
            
        }

        public static void Delete(DataGridView dtgv, string deletedID) {

            List<Elements> records;

            using (var reader = new StreamReader(@"C:\Users\justf\source\repos\SoldierDesktopApp\SoldierDesktopApp\soldiers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Elements>().ToList();


                if (IsValidID(deletedID))
                {
                    for (int i = 0; i < records.Count; ++i)
                    {

                        if (records[i].ID == deletedID)
                        {
                            records.RemoveAt(i);
                            string msg = "Data succesfully deleted from the file!";

                            MessageBox.Show(msg);
                        }
                    }
                }
                else
                {
                    MessageBoxButtons btnOK = MessageBoxButtons.OK;
                    DialogResult dialogResult = MessageBox.Show("This ID is not found in the File!", "Error", btnOK, MessageBoxIcon.Error);
                }
                
            }

            using (var writer = new StreamWriter(@"C:\Users\justf\source\repos\SoldierDesktopApp\SoldierDesktopApp\soldiers.csv"))
            using (var csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvwriter.WriteRecords(records);
            }

        }

        public void Modify(DataGridView dataGridView1, string modifiedID,
            TextBox id, TextBox name, TextBox rank, TextBox age, TextBox bos)
        {
            List<Elements> records;
            
            
            using (var reader = new StreamReader(@"C:\Users\justf\source\repos\SoldierDesktopApp\SoldierDesktopApp\soldiers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Elements>().ToList();

                if (IsValidID(modifiedID))
                {
                    for (int i = 0; i < records.Count; ++i)
                    {
                        if (records[i].ID == modifiedID)
                        {
                            if (filled(id))
                            {
                                records[i].ID = c.RTF(id);
                            }
                            if (filled(name))
                            {
                                records[i].Name = c.RTF(name);
                            }
                            if (filled(rank))
                            {
                                records[i].Rank = c.RTF(rank);
                            }
                            if (filled(age))
                            {
                                records[i].Age = c.RTF(age);
                            }
                            if (filled(bos))
                            {
                                records[i].BeginOfService = c.RTF(bos);
                            }

                        }
                    }
                }
                else
                {
                    MessageBoxButtons btnOK = MessageBoxButtons.OK;
                    DialogResult dialogResult = MessageBox.Show("This ID is not found in the File!","Error",btnOK, MessageBoxIcon.Error);
                }
            }

            using (var writer = new StreamWriter(@"C:\Users\justf\source\repos\SoldierDesktopApp\SoldierDesktopApp\soldiers.csv"))
            using (var csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvwriter.WriteRecords(records);
            }


        }

        public bool filled(TextBox textBox)
        {
            string s = c.RTF(textBox);
            return s.Length > 0;
        }

        public static bool IsValidID(string selectedID)
        {
            List<Elements> records;


            using (var reader = new StreamReader(@"C:\Users\justf\source\repos\SoldierDesktopApp\SoldierDesktopApp\soldiers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Elements>().ToList();
            }

            bool b = false;

            for (int i = 0; i < records.Count; ++i)
            {
                if (records[i].ID == selectedID)
                {
                    b = true;
                    break;
                }
                else 
                {
                    b = false;
                }
            }

            return b;
        }
    }
}
