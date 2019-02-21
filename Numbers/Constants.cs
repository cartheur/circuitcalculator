using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircuitCalculator.Numbers
{
    /// <summary>
    /// Constants used in the calculations.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The relative permeability, mu, in Henries per meter.
        /// </summary>
        public const double RelativePermeability = 4 * Math.PI * 10E-7;
        /// <summary>
        /// The relative permittivity, epsilon_sub_0, of paper used as a dialectric in the terrestrial capacitor.
        /// </summary>
        public const double RelativePermittivityPaper = 3.85;
        /// <summary>
        /// The vacuum permittivity, epsilon_sub_r, in Farads per meter.
        /// </summary>
        public const double VacuumPermittivity = 8.854187817 * 10E-12;
        /// <summary>
        /// The electrical conductivity copper, sigma, in Siemens per meter.
        /// </summary>
        /// <remarks>Create a table when more materials need added.</remarks>
        public const double ElectricalConductivityCopper = 5.96 * 10E7;
        /// <summary>
        /// The electrical conductivity air, sigma, at 20C, in Siemens per meter.
        /// </summary>
        public const double ElectricalConductivityAir = 5.0 * 10E-15;
    }
}
