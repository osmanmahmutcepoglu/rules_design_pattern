using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.ExtensionsMethods.Interface;

namespace UnluCo.ExtensionsMethods.Rules
{
    public class PasswordIsUpperCaseValidationRule : IPasswordValidationRule
    {
        private readonly string _password;

        public PasswordIsUpperCaseValidationRule(string password) => _password = password;

        public bool IsValid(string password)
        {
            return _password.Any(x => char.IsUpper(x));
        }
    }
}
