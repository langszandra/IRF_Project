﻿using beadando.Controller;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualREsult = accountController.ValidateEmail(email);
            Assert.AreEqual(expectedResult, actualREsult);
               



        }

        [
            Test,
            TestCase("abcdABCD", false),
            TestCase("ABCD1234", false),
            TestCase("ab1234", false),
            TestCase("Abcd123", false),
            TestCase("Abcd1234", true)
           
         ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualREsult = accountController.ValidatePassword(password);
            Assert.AreEqual(expectedResult, actualREsult);



        }
    }
}