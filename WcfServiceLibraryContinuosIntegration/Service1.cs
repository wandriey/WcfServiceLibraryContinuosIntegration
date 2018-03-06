using ClassLibraryContinuosIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryContinuosIntegration
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        Person person = new Person();
        /// <summary>
        /// Get person name
        /// </summary>
        /// <returns></returns>
        public string GetNameSoap()
        {
            return person.GetName();
        }
    }
}
