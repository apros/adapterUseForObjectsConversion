using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterUseForObjectConversion
{

    public class Character
    {
        [Newtonsoft.Json.JsonProperty("first_name")]
        public string FirstName { get; set; }
        [Newtonsoft.Json.JsonProperty("last_name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        [Newtonsoft.Json.JsonProperty("hair_color")]
        public string Hair { get; set; }
        [Newtonsoft.Json.JsonProperty("skin_color")]
        public string Skin { get; set; }
        [Newtonsoft.Json.JsonProperty("eye_color")]
        public string Eye { get; set; }
    }

}
