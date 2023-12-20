using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HappyHour
{
    internal class DrinksWrapper
    {
        [JsonPropertyName("drinks")]
        public List<Drink> Drinks { get; set; }
    }

    internal class Drink
    {
        [JsonPropertyName("strDrink")]
        public string StrDrink { get; set; }
        [JsonPropertyName("strInstructions")]
        public string StrInstructions { get; set; }

        [JsonPropertyName("strIngredient1")]
        public string StrIngredient1 { get; set; }
        [JsonPropertyName("strIngredient2")]
        public string StrIngredient2 { get; set; }
        [JsonPropertyName("strIngredient3")]
        public string StrIngredient3 { get; set; }
        [JsonPropertyName("strIngredient4")]
        public string StrIngredient4 { get; set; }
        [JsonPropertyName("strIngredient5")]
        public string StrIngredient5 { get; set; }
        [JsonPropertyName("strIngredient6")]
        public string StrIngredient6 { get; set; }
        [JsonPropertyName("strIngredient7")]
        public string StrIngredient7 { get; set; }
        [JsonPropertyName("strIngredient8")]
        public string StrIngredient8 { get; set; }
        [JsonPropertyName("strIngredient9")]
        public string StrIngredient9 { get; set; }
        [JsonPropertyName("strIngredient10")]
        public string StrIngredient10 { get; set; }
        [JsonPropertyName("strIngredient11")]
        public string StrIngredient11 { get; set; }
        [JsonPropertyName("strIngredient12")]
        public string StrIngredient12 { get; set; }
        [JsonPropertyName("strIngredient13")]
        public string StrIngredient13 { get; set; }
        [JsonPropertyName("strIngredient14")]
        public string StrIngredient14 { get; set; }
        [JsonPropertyName("strIngredient15")]
        public string StrIngredient15 { get; set; }

        // Create a list to store ingredients
        public List<string> Ingredients
        {
            get
            {
                return new List<string>
            {
                StrIngredient1,
                StrIngredient2,
                StrIngredient3,
                StrIngredient4,
                StrIngredient5,
                StrIngredient6,
                StrIngredient7,
                StrIngredient8,
                StrIngredient9,
                StrIngredient10,
                StrIngredient11,
                StrIngredient12,
                StrIngredient13,
                StrIngredient14,
                StrIngredient15
            };
            }
        }
    }
}
