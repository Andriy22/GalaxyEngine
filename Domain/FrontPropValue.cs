using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FrontPropValue
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public Guid BaseComponentId { get; set; }
        public FrontBaseComponent BaseComponent { get; set; }
        public Guid PropId { get; set; }
        public FrontComponentProp Prop { get; set; }
    }
}
