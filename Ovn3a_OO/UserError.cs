using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    internal abstract class UserError
    {
        public abstract string UEMessage();
        
    }
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numerid input in a text only field. This fired an error";
        }
    }
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a textinput in a numeric only field. This fired an error!";
        }
    }
}
