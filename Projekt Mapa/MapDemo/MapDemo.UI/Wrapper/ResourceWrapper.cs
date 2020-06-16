using MapDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDemo.UI.Wrapper
{
    public class ResourceWrapper : ModelWrapper<Resource>
    {
        public ResourceWrapper(Resource model) : base(model)
        {
        }

        public int ResourceId { get { return Model.ResourceId; } }

        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int Price
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
    }
}
