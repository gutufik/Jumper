using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumper.Data
{
    public partial class JumperMishaEntities
    {
        private static JumperMishaEntities _context;
        public static JumperMishaEntities GetContext()
        {
            if (_context == null)
                _context = new JumperMishaEntities();
            return _context;
        }
    }
}
