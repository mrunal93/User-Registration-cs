using NUnit.Framework;

namespace UserRegistrationTest
{
    public class Tests
    {
        
        
        
        [Test]
        public void GivenFirstName_WhenValidate_ReturnTrue()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.ValidationFirstName("Mrunal");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void GivenLastName_WhenValidate_ReturnTrue()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.ValidationLastName("Fulzele");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void GivenEmailPattern_WhenValidate_ReturnTrue()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.EmailValidation("mrn.xyz@bl.co.in");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void GivenMobleNumber_WhenValidate_ReturnTrue()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.MobileValidation("91 9326265360");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void GivenMobleNumber_WhenPassingAgainMobileNUmber_ReturnTrue()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.MobileValidation("91 9326265360");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void GivenPassword_WhenTestingValidation_ReturnTure()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.Password_Validation_Rule("mrunal@nas");
            Assert.IsTrue(isValid);
        }
        
        [Test]
        public void GivenPasswordSampleOne_WhenTestingValidation_ReturnTure()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.Password_Validation_Rule("Mrunal@26nas");
            Assert.IsTrue(isValid);
        }
        
        [Test]
        public void GivenEmailSampleOne_WhenTestingValidation_ReturnTure()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.EmailValidation_ForAllEmail("abc-100@yahoo.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void GivenEmailSampleTwo_WhenTestingValidation_ReturnTure()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.EmailValidation_ForAllEmail("abc.100@yahoo.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void GivenEmailSampleThird_WhenTestingValidation_ReturnTure()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.EmailValidation_ForAllEmail("abc+100@gmail.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void GivenEmailSampleFourth_WhenTestingValidation_ReturnTure()
        {
            UserRegistration.UserRegistrationUtility validation = new UserRegistration.UserRegistrationUtility();
            bool isValid = validation.EmailValidation_ForAllEmail("abc.100@abc.com.au");
            Assert.IsTrue(isValid);
        }
    }
}