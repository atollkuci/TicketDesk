﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketDesk.Localization.Domain;

namespace TicketDesk.Domain.Model
{
    public class ApplicationSecuritySetting
    {
        public ApplicationSecuritySetting()
        {
            DefaultNewUserRoles = new List<string>(new[] { "TdPendingUsers" });
        }

        [JsonIgnore]
        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        public string Serialized
        {
            get { return JsonConvert.SerializeObject(this); }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                var jsettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };
                var jData = JsonConvert.DeserializeObject<ApplicationSecuritySetting>(value, jsettings);
                DefaultNewUserRoles = jData.DefaultNewUserRoles;
            }
        }

        private ICollection<string> defaultNewUserRoles;



        [NotMapped]
        [Display(Name = "DefaultNewUserRoles", ResourceType = typeof(Strings_sq))]
        public ICollection<string> DefaultNewUserRoles
        {
            get { return defaultNewUserRoles; }
            set
            {
                if (!value.Contains("TdPendingUsers"))
                {
                    value.Add("TdPendingUsers");
                }
                defaultNewUserRoles = value;
            }
        }
    }
}
