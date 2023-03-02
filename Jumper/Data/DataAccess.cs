using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumper.Data
{
    public class DataAccess
    {
        public delegate void RefreshListDelegate();
        public static event RefreshListDelegate RefreshList;
        internal static IEnumerable<Agent> GetAgents()
        {
            throw new NotImplementedException();
        }
    }
}
