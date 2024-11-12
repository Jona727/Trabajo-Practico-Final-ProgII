using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Trabajo_Practico_Final_ProgII
{

    //CLASE PEON _ EJECUTA EL TRABAJO DURO CON LA CONEXION A LA DB
    internal class DataAccesLayer
    {
        private SqlConnection conn = new SqlConnection(""); //ver conexion llave de ingreso a la DB
        
    }

    public void InsertContact (Contact contact)
    {
        try
        {
            conn.Open();
            string query = @"
                              insert into Contacts (FirstName, LastName, Phone, Adress)
                              values (@FirstName, @LastName, @Phone, @Address)";

            SqlParameter firstName = new SqlParameter();
            firstName.ParameterName = "@FirstName";
            firstName.Value = contact.FirstName;
            firstName.DbType = System.Data.DbType.String;

            SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
            SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
            SqlParameter adress = new SqlParameter("@Address", contact.Address);

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.Add(firstName);
            command.Parameters.Add(lastName);
            command.Parameters.Add(adress);
            command.Parameters.Add(phone);

            command.ExecuteNonQuery();
        }

        catch (Exception ex)
        {

        }
        
    }

    public List <Contact> GetContacts()
    {

    }

}
