using Newtonsoft.Json;

namespace Baker.WebUI.Dtos.Chef
{
    public class UpdateChefDto
    {

        public int chefId { get; set; }

        public string name { get; set; }

        public string title { get; set; }

        public string imageurl { get; set; }
    }
}
