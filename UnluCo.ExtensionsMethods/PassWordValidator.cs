﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.ExtensionsMethods.Interface;
using UnluCo.ExtensionsMethods.Rules;

namespace UnluCo.ExtensionsMethods
{
    public static class PassWordValidator
    {

        public static bool IsValid(string password)
        {
            var _rules = new List<IPasswordValidationRule>();
            _rules.Add(new PasswordIsDigitValidationRule(password));
            _rules.Add(new PasswordIsUpperCaseValidationRule(password));
            _rules.IsValidPassword(password);

            return _rules.IsValidPassword(password);
        }
    }
}
