using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.ExtensionsMethods.Interface;

namespace UnluCo.ExtensionsMethods.Rules
{
    public class PasswordIsDigitValidationRule : IPasswordValidationRule
    {
        private readonly string _password;

        public PasswordIsDigitValidationRule(string password) => _password = password;

        public bool IsValid(string password)
        {
            return _password.Any(x => char.IsDigit(x));
        }
    }
}
