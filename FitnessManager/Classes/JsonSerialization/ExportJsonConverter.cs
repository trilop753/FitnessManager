using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace FitnessManager.Classes.JsonSerialization
{
    public class ExportJsonConverter : JsonConverter<ExportClass>
    {
        public override ExportClass? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, ExportClass value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Username", value.Username);
            writer.WriteNumber("Age", value.Age);
            writer.WriteNumber("Height", value.Height);
            writer.WriteNumber("Weight", value.Weight);
            writer.WriteString("Gender", value.Gender ? "Male" : "Female");
            writer.WriteString("Lifestyle", value.Lifestyle.ToString().ToLower());
            writer.WriteString("Goal", value.GainMuscles ? "Gain muscles" : "Lose fat");
            writer.WriteString("BMI", value.BMI);
            writer.WriteString("Calories", value.Macros.Calories + " / " + value.Metrics.DailyCalories);
            writer.WriteString("Carbs", value.Macros.Carbs + " / " + value.Metrics.DailyCarbs);
            writer.WriteString("Fats", value.Macros.Fats + " / " + value.Metrics.DailyFats);
            writer.WriteString("Proteins", value.Macros.Proteins + " / " + value.Metrics.DailyProteins);
            writer.WriteEndObject();
        }
    }
}
