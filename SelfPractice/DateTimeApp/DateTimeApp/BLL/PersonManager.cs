using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeApp.Models;
using DateTimeApp.DAL;


namespace DateTimeApp.BLL
{
    class PersonManager
    {
        private PersonGateway personGateway = new PersonGateway();

        public string SavePerson(Person person)
        {
            int rowEffect = personGateway.SavePerson(person);

            if(rowEffect > 0)
            {
                return "Successfully saved.";
            }

            return "Failed to save.";
        }
    }
}
