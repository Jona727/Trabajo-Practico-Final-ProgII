using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Final_ProgII
{
    //CLASE INTERMEDIA _ TRAJE Y CORBATA DA LAS ORDENES
    public class BusinessLogicLayer
    {
        private DataAccesLayer _dataAccesLayer;
    }

    public BusinessLogicLayer()
    {

    }

    public Contact SaveContact(Contact contact)
    {
        if (contact.Id == 0)
        {
            _dataAccessLayer.InsertContact(contact);

        }
        else
        {
            _dataAccessLayer.UpdateContact;
        }
        return contact;
    }

    public List<Contact> GetAllContacts()
    {

    }
}
