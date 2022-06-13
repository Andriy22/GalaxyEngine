using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FrontComponent
    {
        public FrontComponent()
        {
            PropValues = new List<FrontPropValue>();
        }
        public string Id { get; set; }
        public string BaseComponentId { get; set; }
        public FrontBaseComponent BaseComponent { get; set; }
        public string PageId { get; set; }
        public FrontPage Page { get; set; }
        public int DisplayIndex { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsHidden { get; set; }

        public List<FrontPropValue> PropValues { get; set; }

    }
}
