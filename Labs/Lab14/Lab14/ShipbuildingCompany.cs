using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    /// <summary>
    /// Судостроительная компания.
    /// </summary>
    public class ShipbuildingCompany: Organization
    {
        /// <summary>
        /// Может ли компания стрить новые суда.
        /// </summary>
        public bool Manufacturing { get; set; }

        /// <summary>
        /// Оказывает ли компания услуги по ремонту судов.
        /// </summary>
        public bool Repair { get; set; }
    }
}
