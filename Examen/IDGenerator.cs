using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class IDGenerator
    {
        private static IDGenerator instance;

        private int _nextID;

        private IDGenerator() { _nextID = 1; }

        [MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public static IDGenerator getGenerator()
        {
            if (instance == null)
            {
                instance = new IDGenerator();
            }
            return instance;
        }

        public int nextID()
        {
            return _nextID++;
        }

    }
}
