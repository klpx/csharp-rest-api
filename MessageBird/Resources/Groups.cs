﻿using Newtonsoft.Json;

namespace MessageBird.Resources
{
    class Groups : Resource
    {
        public Groups(Objects.Group group)
            : base("groups", group)
        {
            //
        }

        public Groups()
            : this(new Objects.Group())
        {
            //
        }

        public override string Serialize()
        {
            var requestObject = ((Objects.Group)Object).ToRequestObject();

            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            return JsonConvert.SerializeObject(requestObject, settings);
        }
    }
}
