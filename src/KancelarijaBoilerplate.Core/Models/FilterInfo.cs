using System.Collections.Generic;

namespace KancelarijaBoilerplate.Models
{
    public class FilterInfo
    {
        public string Condition { get; set; }
        public List<RuleInfo> Rules { get; set; } = new List<RuleInfo>();
    }
}