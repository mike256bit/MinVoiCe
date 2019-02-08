using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class ClientData
    {

        private static List<Client> clientList = new List<Client>();
        public static bool IsLoaded = false;


        //GetAll
        public static List<Client> GetAll()
        {
            return clientList;
        }

        //Add
        public static void Add(Client newClient)
        {
            clientList.Add(newClient);
        }

        //GetbyName
        public static Client GetbyID(int id)
        {
            return clientList.Single(x => x.ClientId == id);
        }

        //Dummy Clients:

        public static void LoadClients()
        {
            Client dummy1 = new Client
            {
                Name = "Bob's Bait Shop",
                PointOfContact = "Bob Bobson",
                Phone = "(333)-123-4567",
                EMail = "bbob@bbs.com",
                AddressStreet = "123 Bait St.",
                AddressCityZip = "Clearwater, FL 33321"
            };

            Client dummy2 = new Client
            {
                Name = "Vally Law",
                PointOfContact = "Nibbo Grant",
                Phone = "(333)-222-4667",
                EMail = "ndgrant@vlpa.com",
                AddressStreet = "123 Law St.",
                AddressCityZip = "Tampa, FL 38121"
            };

            Client dummy3 = new Client
            {
                Name = "Duck Factory",
                PointOfContact = "Howard Q. Duck",
                Phone = "(126)-552-1167",
                EMail = "hd@mallard.com",
                AddressStreet = "123 Bird Ave.",
                AddressCityZip = "New York, NY 21125"
            };

            clientList.Add(dummy1);
            clientList.Add(dummy2);
            clientList.Add(dummy3);

            IsLoaded = true;
        }
    }
}
