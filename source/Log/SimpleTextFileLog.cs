﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Log
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class SimpleTextFileLog : Loggable
    {
        private string FileName = "";
        public Exception EXCPT = null;

        public SimpleTextFileLog(string filename)
        {
            FileName = filename;
            try
            {
                //File.Delete(FileName);
                // var file = File.Open(FileName, FileMode.Open);
                // file.Close();
                var file = File.Open(FileName, FileMode.Open);
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                EXCPT = e;

                var file = File.Open(FileName, FileMode.Create);
                file.Close();
            }
            catch (IOException e)
            {
                EXCPT = e;
            }
        }

        public void Log<T>(T text)
        {
            var file = File.Open(FileName, FileMode.Append);
            using (var stream = new StreamWriter(file))
            {
                stream.WriteLine("CLIENT [" + DateTime.Now + "]: " + text);
            }
            //Console.WriteLine($"{text}");
            file.Close();
        }

        public void Log<T>(LogErrorLevel errorLevel, T text) { }

        public void Clear()
        {
            //var file = File.Open(FileName, FileMode.Truncate);
            //file.Close();
        }
    }
}
