using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MP_5_2_HRCompanion
{
    public class FileHelper<T> where T : new()
    {
        private string _dataPath;
        public FileHelper(string dataPath)
        {
            _dataPath = dataPath;
        }

        public void SerializeToFile(List<Worker> workers)
        {
            var jsonString = JsonConvert.SerializeObject(workers, (Formatting)1);
            File.WriteAllText(_dataPath, jsonString);
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_dataPath))
                return new T();

            var workers = JsonConvert.DeserializeObject
                        <T>(File.ReadAllText(_dataPath));

            return workers;
        }
    }
}
