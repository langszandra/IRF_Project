using beadando.Controller;
using NUnit.Framework;
using System;
using System.Activities;
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

        [
          Test,
          TestCase("irf@uni-corvinus.hu", "Abcd1234", true),
          TestCase("irf@uni-corvinus.hu", "Abcd1234567", true)
        ]
        public void TestRegisterHappyPath(string email, string password)
        {

            var accountController = new AccountController();


            var actualResult = accountController.Register(email, password);


            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
        }


        [
            Test,
            TestCase("irf@uni-corvinus", "Abcd1234", false),
            TestCase("irf.uni-corvinus.hu", "Abcd1234",false),
            TestCase("irf@uni-corvinus.hu", "abcd1234",false),
            TestCase("irf@uni-corvinus.hu", "ABCD1234",false),
            TestCase("irf@uni-corvinus.hu", "abcdABCD",false),
            TestCase("irf@uni-corvinus.hu", "Ab1234",false)
        ]
        public void TestRegisterValidateException(string email, string password)
        {
            
            var accountController = new AccountController();

            
            try
            {
                var actualResult = accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }

            
        }
    }
}
