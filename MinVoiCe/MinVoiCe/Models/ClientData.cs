using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class ClientData
    {

        private static List<Client> clientList = new List<Client>();

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
    }
}
