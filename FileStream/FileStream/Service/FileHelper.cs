using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileStream.Service;

public class FileHelper
{
    List<string> list = [];
    string str;
    public string Path { get; set; }
    public FileHelper(string path)
    {
        Path = path;
    }

    public void Add(string name)
    {
        if (name.Length > 2)
        {
            list.Add(name);
            str = JsonConvert.SerializeObject(list);
            using StreamWriter sw = new StreamWriter(Path, false);
            sw.Write(str);
        }
        else
            Console.WriteLine("Adinizi duzgun daxil edin!");
    }
    public bool Exist(string name)
    {
        return list.Contains(name);
    }
    public void Update(int index, string name)
    {
        if (index < list.Count)
        {
            list[index] = name;
            str = JsonConvert.SerializeObject(list);
            using StreamWriter sw = new StreamWriter(Path, false);
            sw.Write(str);
        }
        else Console.WriteLine("Indexi duzgun daxil edin!");
    }
    public void Delete(int index)
    {
        if (index < list.Count)
        {
            list.RemoveAt(index);
            str = JsonConvert.SerializeObject(list);
            using StreamWriter sw = new StreamWriter(Path, false);
            sw.Write(str);
        }
        else Console.WriteLine("Indexi duzgun daxil edin!");
    }
    //public async Task<string> ReadAsync()
    //{
    //    using StreamReader sr = new StreamReader(Path);
    //    return await sr.ReadToEndAsync();
    //}
}
