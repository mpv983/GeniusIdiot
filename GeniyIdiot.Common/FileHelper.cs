using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace GeniyIdiot.Common
{
    public class FileHelper
    {
        public FileHelper(string path)
        {
            this.path = path;
        }

        public string path {  get; set; }


        public string JsonSerialize<T>(T item)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            var serializedJson = JsonSerializer.Serialize(item, options);
            return serializedJson;
        }
        public T JsonDeserialize<T>(string item)
        {
            T? deserializedJson = JsonSerializer.Deserialize<T>(item);
            return deserializedJson;
        }

        public void CheckFile()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        public List<T> Read<T>()
        {
            CheckFile();
            var value = string.Empty;
            using (var sr = new StreamReader(path))
            {
                value = sr.ReadToEnd();
            }
            var result = JsonDeserialize<List<T>>(value);
            return result;
        }

        public void Write<T>(List<T> value)
        {
            var jsonString = JsonSerialize(value);
            File.WriteAllText(path, "");
            using (var sw = new StreamWriter(path, false))
            {
                sw.Write(jsonString);
            }
        }
    }
}