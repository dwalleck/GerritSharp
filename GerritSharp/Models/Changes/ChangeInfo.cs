using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GerritSharp.Models.Changes
{
    public class ChangeInfo
    {
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "project")]
        public string Project { get; set; }

        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        [JsonProperty(PropertyName = "change_id")]
        public string ChangeId { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        [JsonProperty(PropertyName = "mergeable")]
        public bool IsMergeable { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public User Owner { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public Labels Labels { get; set; }

        [JsonProperty(PropertyName = "_number")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "_sortkey")]
        public string SortKey { get; set; }
    }

    public class User
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "_account_id")]
        public string AccountId { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
    }

    public class UserReview : User
    {
        [JsonProperty(PropertyName = "value")]
        public string Value{ get; set; }
    }


    public class Labels
    {
        public Verified Verified { get; set; }

        [JsonProperty(PropertyName = "Code-Review")]
        public CodeReview CodeReview { get; set; }
        
        public Workflow Workflow { get; set; }
    }

    public class Verified
    {
        public Recommended recommended { get; set; }
        public Disliked disliked { get; set; }
        public Approved approved { get; set; }
        public int value { get; set; }
    }

    public class Recommended : UserReview
    {

    }

    public class Disliked : UserReview
    {
        
    }

    public class Approved : UserReview
    {

    }

    public class CodeReview
    {
        public Recommended recommended { get; set; }
        public Disliked disliked { get; set; }
        public Approved approved { get; set; }
        public int value { get; set; }
    }

    public class Workflow
    {
        public Recommended recommended { get; set; }
        public Disliked disliked { get; set; }
        public Approved approved { get; set; }
        public int value { get; set; }
    }

}
