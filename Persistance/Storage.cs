using System.Text.Encodings.Web;
using System.Text.Json;
using WestcoastEducation.Models;

namespace WestcoastEducation.Persistance;

public class Storage<T>
{
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };
    public static List<T> Read(string path)
    {
        try
        {
            string data = File.ReadAllText(path);
            if (!string.IsNullOrEmpty(data) || !string.IsNullOrWhiteSpace(data))
            {
                return JsonSerializer.Deserialize<List<T>>(data,_options)!;
            }
            else
            {
                return[];
            }
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }
    public static void Write(List<T> data, string path)
    {
        try
        {
            string json = JsonSerializer.Serialize(data, _options);
            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }
    
}

