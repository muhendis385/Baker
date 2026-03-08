using Newtonsoft.Json;

namespace Baker.WebUI.Dtos.Chef
{
    public class ResultChefDto
    {

        [JsonProperty("chefId")]
        public int ChefId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }   
        
        [JsonProperty("imageurl")]
        public string Imageurl { get; set; }

    }
}
