using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            NUnit.Framework.Assert.That(result, Is.TypeOf<NotFound>());
            //NUnit.Framework.Assert.That(result, Is.InstanceOf<NotFound>());
            //InstanceOf can be a not found object or one of its derivatives
            //TypeOf ensures that the result is exactly the not found object
        }
        
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);

            NUnit.Framework.Assert.That(result, Is.InstanceOf<Ok>());
        }


    }
}
