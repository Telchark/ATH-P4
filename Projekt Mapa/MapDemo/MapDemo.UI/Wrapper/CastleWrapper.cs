using MapDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDemo.UI.Wrapper
{
    public class CastleWrapper : ModelWrapper<Castle>
    {
        public CastleWrapper(Castle model) : base(model)
        {

        }

        public int CastleId { get { return Model.CastleId; } }
        public string Name
        {
            get { return GetValue<string>(); }
            set{ SetValue(value); }
        }
    }
}
