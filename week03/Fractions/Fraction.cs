using System;

namespace Fractions
{
    public class Fraction
    {
        // Private attributes (Encapsulation)
        private int _top;
        private int _bottom;

        // --- CONSTRUCTORS ---

        // 1. Constructor with no parameters (Defaults to 1/1)
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // 2. Constructor with one parameter for the top (Defaults bottom to 1)
        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        // 3. Constructor with two parameters for top and bottom
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        // --- GETTERS AND SETTERS ---
        // Using standard C# properties to encapsulate the private fields

        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public int Bottom
        {
            get { return _bottom; }
            set { _bottom = value; }
        }

        // --- METHODS ---

        // Returns the fraction as a string (e.g., "3/4")
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        // Returns the decimal value. 
        // Note: We cast _top to (double) to avoid integer division truncation!
        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }
    }
}