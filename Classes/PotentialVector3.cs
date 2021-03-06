using System;
using System.Xml.Serialization;
using System.Globalization;

namespace CircuitCalculator.Vector
{
    /// <summary>
    /// A (potential) vector of doubles with three components (Ax,Ay,Az). In real terms, the transverse wave has assigned to 
    /// the formula: E=Ax, H(B)=Ay, A=Az.
    /// </summary>
    [Serializable]
    public struct PotentialVector3 : IComparable, IComparable<PotentialVector3>, IEquatable<PotentialVector3>//, IFormattable
    {
        private Vector3 e, b, a;
        double[] x, y, z;
        double[] empty;
        
        public PotentialVector3(Vector3 e, Vector3 b, Vector3 a)
        {
            // Pre-initialisation initialisation
            // Implemented because a struct's variables always have to be set in the constructor before moving control
            this.e.Array2d = x;
            this.b.Array2d = y;
            this.a.Array2d = z;

            // Initialisation
            E = e;
            B = b;
            A = a;
        }
        public PotentialVector3(PotentialVector3 Av1)
        {
            // Pre-initialisation initialisation
            // Implemented because a struct's variables always have to be set in the constructor before moving control
            this.E.Array2d = x;
            this.B.Array2d = y;
            this.A.Array2d = z;

            // Initialisation
            E = Av1.E;
            B = Av1.B;
            A = Av1.A;
        }

        #region Accessors & Mutators
        /// <summary>
        /// Property for the Ax component of the PotentialVector3.
        /// </summary>
        public Vector3 E { get { return e; } set { e = value; } }
        /// <summary>
        /// Property for the Ay component of the PotentialVector3.
        /// </summary>
        public Vector3 B { get { return b; } set { b = value; } }
        /// <summary>
        /// Property for the Az component of the PotentialVector3.
        /// </summary>
        public Vector3 A { get { return a; } set { a = value; } }
        /// <summary>
        /// Property for the magnitude (aka. length or absolute value) of the PotentialVector3.
        /// </summary>
        public double Magnitude
        {
            get
            {
                return
                Math.Sqrt(SumComponentSqrs());
            }
            set
            {
                if (value < 0)
                { throw new ArgumentOutOfRangeException("value", value, NEGATIVE_MAGNITUDE); }

                if (this == new PotentialVector3(0, 0, 0))
                { throw new ArgumentException(ORAGIN_VECTOR_MAGNITUDE, "this"); }

                this = this * (value / Magnitude);
            }
        }
        /// <summary>
        /// An index accessor: Mapping index [0] -> X, [1] -> Y and [2] -> Z.
        /// </summary>
        /// <param name="index">The array index referring to a component within the vector (i.e. x, y, z).</param>
        /// <exception cref="System.ArgumentException">
        /// Thrown if the array argument does not contain three components.
        /// </exception>
        public Vector3 this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: { return E; }
                    case 1: { return B; }
                    case 2: { return A; }
                    default: throw new ArgumentException(THREE_COMPONENTS, "index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: { E = value; break; }
                    case 1: { B = value; break; }
                    case 2: { A = value; break; }
                    default: throw new ArgumentException(THREE_COMPONENTS, "index");
                }
            }
        }

        #endregion


        #region Standard Functions

        /// <summary>
        /// Textual description of the Vector3
        /// </summary>
        /// <Implementation>
        /// Uses ToString(string, IFormatProvider) to avoid code duplication
        /// </Implementation>
        /// <returns>Text (String) representing the vector</returns>
        public override string ToString()
        {
            return ToString(null, null);
        }
        /// <summary>
        /// Get the hashcode
        /// </summary>
        /// <returns>Hashcode for the object instance</returns>
        /// <implementation>
        /// Required in order to implement comparator operations (i.e. ==, !=)
        /// </implementation>
        /// <Acknowledgement>This code is adapted from CSOpenGL - Lucas Viñas Livschitz </Acknowledgement>
        public override int GetHashCode()
        {
            return
            (
                (int)((E + B + A) % Int32.MaxValue)
            );
        }

        /// <summary>
        /// Comparator
        /// </summary>
        /// <param name="other">The other object (which should be a vector) to compare to</param>
        /// <returns>Truth if two vectors are equal within a tolerence</returns>
        /// <implementation>
        /// Checks if the object argument is a Vector3 object 
        /// Uses the equality operator function to avoid code duplication
        /// Required in order to implement comparator operations (i.e. ==, !=)
        /// </implementation>
        public override bool Equals(object other)
        {
            // Check object other is a Vector3 object
            if (other is PotentialVector3)
            {
                // Convert object to Vector3
                PotentialVector3 otherVector = (PotentialVector3)other;

                // Check for equality
                return otherVector == this;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Comparator
        /// </summary>
        /// <param name="other">The other Vector3 to compare to</param>
        /// <returns>Truth if two vectors are equal within a tolerence</returns>
        /// <implementation>
        /// Uses the equality operator function to avoid code duplication
        /// </implementation>
        public bool Equals(PotentialVector3 other)
        {
            return other == this;
        }

        /// <summary>
        /// compares the magnitude of this instance against the magnitude of the supplied vector
        /// </summary>
        /// <param name="other">The vector to compare this instance with</param>
        /// <returns>
        /// -1: The magnitude of this instance is less than the others magnitude
        /// 0: The magnitude of this instance equals the magnitude of the other
        /// 1: The magnitude of this instance is greater than the magnitude of the other
        /// </returns>
        /// <implementation>
        /// Implemented to fulfil the IComparable interface
        /// </implementation>
        /// <Acknowledgement>This code is adapted from Exocortex - Ben Houston </Acknowledgement>
        public int CompareTo(PotentialVector3 other)
        {
            if (this < other)
            {
                return -1;
            }
            else if (this > other)
            {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// compares the magnitude of this instance against the magnitude of the supplied vector
        /// </summary>
        /// <param name="other">The vector to compare this instance with</param>
        /// <returns>
        /// -1: The magnitude of this instance is less than the others magnitude
        /// 0: The magnitude of this instance equals the magnitude of the other
        /// 1: The magnitude of this instance is greater than the magnitude of the other
        /// </returns>
        /// <implementation>
        /// Implemented to fulfil the IComparable interface
        /// </implementation>
        /// <exception cref="ArgumentException">
        /// Throws an exception if the type of object to be compared is not known to this class
        /// </exception>
        /// <Acknowledgement>This code is adapted from Exocortex - Ben Houston </Acknowledgement>
        public int CompareTo(object other)
        {
            if (other is PotentialVector3)
            {
                return CompareTo((PotentialVector3)other);
            }
            else
            {
                // Error condition: other is not a PotentialVector3 object
                throw new ArgumentException
                (
                    // Error message includes information about the actual type of the argument
                    NON_VECTOR_COMPARISON + "\n" + ARGUMENT_TYPE + other.GetType().ToString(),
                    "other"
                );
            }
        }

        #endregion


        #region Messages

        /// <summary>
        /// Exception message descriptive text 
        /// Used for a failure for an array argument to have three components when three are needed 
        /// </summary>
        private const string THREE_COMPONENTS = "Array must contain exactly three components , (x,y,z)";
        /// <summary>
        /// Exception message descriptive text 
        /// Used for a failure for an array argument to have three components when two are needed. 
        /// </summary>
        private const string TWO_COMPONENTS = "Array must contain exactly two position components , (x,y)";
        /// <summary>
        /// Exception message descriptive text 
        /// Used for a divide by zero event caused by the normalization of a vector with magnitude 0 
        /// </summary>
        private const string NORMALIZE_0 = "Can not normalize a vector when it's magnitude is zero";

        /// <summary>
        /// Exception message descriptive text 
        /// Used when interpolation is attempted with a control parameter not between 0 and 1 
        /// </summary>
        private const string INTERPOLATION_RANGE = "Control parameter must be a value between 0 & 1";

        /// <summary>
        /// Exception message descriptive text 
        /// Used when attempting to compare a Vector3 to an object which is not a type of Vector3 
        /// </summary>
        private const string NON_VECTOR_COMPARISON = "Cannot compare a Vector3 to a non-Vector3";

        /// <summary>
        /// Exception message additional information text 
        /// Used when adding type information of the given argument into an error message 
        /// </summary>
        private const string ARGUMENT_TYPE = "The argument provided is a type of ";

        /// <summary>
        /// Exception message additional information text 
        /// Used when adding value information of the given argument into an error message 
        /// </summary>
        private const string ARGUMENT_VALUE = "The argument provided has a value of ";

        /// <summary>
        /// Exception message additional information text 
        /// Used when adding length (number of components in an array) information of the given argument into an error message 
        /// </summary>
        private const string ARGUMENT_LENGTH = "The argument provided has a length of ";

        /// <summary>
        /// Exception message descriptive text 
        /// Used when attempting to set a Vectors magnitude to a negative value 
        /// </summary>
        private const string NEGATIVE_MAGNITUDE = "The magnitude of a Vector3 must be a positive value, (i.e. greater than 0)";

        /// <summary>
        /// Exception message descriptive text 
        /// Used when attempting to set a Vectors magnitude where the Vector3 represents the origin
        /// </summary>
        private const string ORAGIN_VECTOR_MAGNITUDE = "Cannot change the magnitude of Vector3(0,0,0)";

        ///////////////////////////////////////////////////////////////////////////////

        private const string UNIT_VECTOR = "Unit vector composing of ";

        private const string POSITIONAL_VECTOR = "Positional vector composing of  ";

        private const string MAGNITUDE = " of magnitude ";

        ///////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Constants

        /// <summary>
        /// The tolerence used when determining the equality of two vectors 
        /// </summary>
        public const double EqualityTolerence = Double.Epsilon;

        /// <summary>
        /// The smallest vector possible (based on the double precision floating point structure)
        /// </summary>
        public static readonly Vector3 MinValue = new Vector3(Double.MinValue, Double.MinValue, Double.MinValue);

        /// <summary>
        /// The largest vector possible (based on the double precision floating point structure)
        /// </summary>
        public static readonly Vector3 MaxValue = new Vector3(Double.MaxValue, Double.MaxValue, Double.MaxValue);

        /// <summary>
        /// The smallest positive (non-zero) vector possible (based on the double precision floating point structure)
        /// </summary>
        public static readonly Vector3 Epsilon = new Vector3(Double.Epsilon, Double.Epsilon, Double.Epsilon);

        #endregion
    }
}
