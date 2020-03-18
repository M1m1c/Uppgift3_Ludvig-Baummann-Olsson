using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Ludvig_Baummann_Olsson
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This is an error!";
        }
    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This is an error!";
        }
    }

    class CharInputError : UserError
    {
        public override string UEMessage()
        {
            return "Error! Invalid input. This field only accepts a single character.";
        }
    }

    class DoubleInputError : UserError
    {
        public override string UEMessage()
        {
            return "Error! Invalid input. This field only accepts numeric values with decimals.";
        }
    }

    class PersonInputError : UserError
    {
        public override string UEMessage()
        {
            return "Error! Invalid input. This field only accepts an object of type Person";
        }
    }
}
