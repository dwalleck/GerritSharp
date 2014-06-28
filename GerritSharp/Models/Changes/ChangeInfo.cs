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

        public string id { get; set; }
        public string project { get; set; }
        public string branch { get; set; }
        public string change_id { get; set; }
        public string subject { get; set; }
        public string status { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public bool mergeable { get; set; }
        public Owner owner { get; set; }
        public Labels labels { get; set; }
    }


    public class Owner
    {
        public string name { get; set; }
    }

    public class Labels
    {
        public Verified Verified { get; set; }
        public CodeReview CodeReview { get; set; }
        public Workflow Workflow { get; set; }
    }

    public class Verified
    {
        public Disliked disliked { get; set; }
        public int value { get; set; }
    }

    public class Disliked
    {
        public string name { get; set; }
    }

    public class CodeReview
    {
    }

    public class Workflow
    {
    }

}
