using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerCommLib.Tests
{
    public class CustomerCommTests
    {
        [Test]
        public void SendMailToCustomer_ReturnsTrue()
        {
            
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                          .Returns(true);

            var customerComm = new CustomerComm(mockMailSender.Object);

            
            bool result = customerComm.SendMailToCustomer();

            
            Assert.IsTrue(result);
        }
    }
}
