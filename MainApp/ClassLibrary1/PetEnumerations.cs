using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessAndConstraints
{
    class PetEnumerations
    {   //Enum for colors, that way we don't allow too complex of a description
        private enum Colors
        {
            Black,
            Brown,
            White,
            Gold,
            Red
        }
        //enum for patterns, again keeping descriptions less complex
        private enum Pattern
        {
            Spots,
            Stripes,
            Solid
        }
        //TODO: add lengths descriptions so users have solid base to agree on
        private enum Lengths
        {
            Small,
            Medium,
            Large
        }
        //TODO enums probably should be public, unless we grab them in this class to fill boxes
    }
}
