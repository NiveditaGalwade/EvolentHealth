using NSubstitute;
using NUnit.Framework;
using OnlineDirectory.BLL;
using OnlineDirectory.Controllers;
using OnlineDirectory.DomainEntites;
using System.Collections.Generic;
using System.Web.Mvc;
namespace OnlineDirectory.UnitTests
{
    [TestFixture]
    public class ControllerTests
    {
        private IContactService<Contact> _contactService;
        private ContactController contactController;
        [SetUp]
        public void Setup()
        {
            _contactService = Substitute.For<IContactService<Contact>>();
            contactController = new ContactController(_contactService);
        }
        [Test]
        public void TestControllerIndex()
        {
            //Arrange
            var contacts = new List<Contact>()
           {
               new Contact(1,"Test first name","Test Last name","abc@gmail.com","9999999999" ),
               new Contact(2,"Test first name1","Test Last name1","xyz@gmail.com","8888888888" )
           };
            _contactService.FindAll().Returns(contacts);

            //Act
            var result = contactController.Index() as ViewResult;

            //Assert
            var model = ((ViewResult)result).Model as List<Contact>;
            Assert.True(model.Count == 2);
            CollectionAssert.AreEqual(model, contacts);
            Assert.That(result.ViewName, Is.EqualTo("Index"));
        }
    }
}
