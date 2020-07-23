using NUnit.Framework;

namespace UserRegistrationTest
{
    public class Tests
    {
        
        
        
        [Test]
        public void TestForChecking_FirstName()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.FirstNameValidation("Mrunal");
            Assert.IsTrue(isValid);
        }

        public void TestForChecking_LastName()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.LastNameValidation("Fulzele");
            Assert.IsTrue(isValid);
        }
        public void TestForChecking_Email()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.EmailValidation("mrn.xyz@bl.co.in");
            Assert.IsTrue(isValid);
        }
        public void TestForChecking_MobileFormat()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.MobileValidation("91 9326265360");
            Assert.IsTrue(isValid);
        }
    }
}