using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public enum Direction
    {
        /// <summary>
        /// Передвинуть каретку на лево.
        /// </summary>
        Left,

        /// <summary>
        /// Передвинуть каретку на право.
        /// </summary>
        Right,

        /// <summary>
        /// Остаться на месте.
        /// </summary>
        Stay
    }
}
