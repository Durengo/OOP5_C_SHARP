using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Core
{
    using System.Text.Json;
    using System.IO;

    public class Config
    {
        private bool DatabaseGenerated = false;
        private const string FileName = "cfg.json";
        public Exception EXCPT = null;
        public string DBEXCPT = null;
        private JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        public Config()
        {
            try
            {
                var file = File.Open(FileName, FileMode.Open);
                Config? CFG = JsonSerializer.Deserialize<Config>(file);
                bool item = CFG.DatabaseGenerated;
                DatabaseGenerated = item;
                DBEXCPT = item.ToString();
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                EXCPT = e;

                var file = File.Open(FileName, FileMode.Create);
                using (var stream = new StreamWriter(file))
                {
                    stream.Write(JsonSerializer.Serialize(this, JsonOptions));
                }
                file.Close();
            }
            catch (IOException e)
            {
                EXCPT = e;
            }
        }

        public bool DatabaseFound
        {
            get { return DatabaseGenerated; }
            set { DatabaseGenerated = value; }
        }

        public void ChangeDatabase(bool value)
        {
            DatabaseGenerated = value;

            var file = File.Open(FileName, FileMode.Create);
            using (var stream = new StreamWriter(file))
            {
                stream.Write(JsonSerializer.Serialize(this, JsonOptions));
            }
            file.Close();
        }
    }
}
