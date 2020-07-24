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
        [Test]
        public void TestForChecking_LastName()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.LastNameValidation("Fulzele");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void TestForChecking_Email()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.EmailValidation("mrn.xyz@bl.co.in");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void TestForChecking_MobileFormat()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.MobileValidation("91 9326265360");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void TestForChecking_MobileFormat_ForPlus()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.MobileValidation("91 9326265360");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void TestForChecking_PasswordFormat_LeasOneLoweCase()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.Password_Validation_Rule("mrunalnas");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void TestForChecking_PasswordFormat_LestOneUpperCase()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.Password_Validation_Rule("Mrunalnas");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void TestForChecking_PasswordFormat_OneNumeric()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.Password_Validation_Rule("Mrunal26nas");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void TestForChecking_PasswordFormat_OneSpecialCharacter()
        {
            UserRegistration.UserDetails validation = new UserRegistration.UserDetails();
            bool isValid = validation.Password_Validation_Rule("Mrunal@nas");
            Assert.IsTrue(isValid);
        }
    }
}