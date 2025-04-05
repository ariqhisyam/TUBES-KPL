using System;
using System.Threading.Tasks;
using TUBES1;

class Program
{
    static async Task Main(string[] args)
    {
        var dataMahasiswa = new DataMahasiswa103022300034();
        var filePath = "D:/Figma Hamda/Campursari/tp7_1_103022300034.json";
        await dataMahasiswa.ReadJsonAsync(filePath);
    }
}
