using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class JsonStorageService
{
    private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "animals.json");

    public JsonStorageService()
    {
        // Ensure the directory exists
        string directory = Path.GetDirectoryName(_filePath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);  // Create the Data folder if it doesn't exist
        }

        // Ensure the file exists
        if (!File.Exists(_filePath))
        {
            SaveAnimals(new List<Animal>());
        }
    }

    // Load animals from the JSON file
    public List<Animal> LoadAnimals()
    {
        try
        {
            string jsonData = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Animal>>(jsonData, new AnimalConverter()) ?? new List<Animal>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading animals: {ex.Message}");
            return new List<Animal>();
        }
    }

    // Save the list of animals to the JSON file
    public void SaveAnimals(List<Animal> animals)
    {
        try
        {
            string jsonData = JsonConvert.SerializeObject(animals, Formatting.Indented);
            File.WriteAllText(_filePath, jsonData);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving animals: {ex.Message}");
        }
    }
}

// Custom JSON converter to handle polymorphism
public class AnimalConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return (objectType == typeof(Animal));
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jsonObject = JObject.Load(reader);
        var type = jsonObject["Type"].ToString();

        Animal animal;
        switch (type)
        {
            case "Cow":
                animal = new Cow();
                break;
            case "Sheep":
                animal = new Sheep();
                break;
            case "Goat":
                animal = new Goat();
                break;
            default:
                throw new Exception($"Unknown animal type: {type}");
        }

        serializer.Populate(jsonObject.CreateReader(), animal);
        return animal;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, value);
    }
}
