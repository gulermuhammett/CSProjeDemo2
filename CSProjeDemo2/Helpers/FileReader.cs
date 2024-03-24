using CSProjeDemo2.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Helpers
{
    public static class FileReader
    {
        public static List<Manager> ReadManagerList(string filePath)
        {
            List<Manager> managers = new List<Manager>();
            List<Manager> managers2 = new List<Manager>();

            string json = File.ReadAllText(filePath);
            managers = JsonConvert.DeserializeObject<List<Manager>>(json);

            foreach (var item in managers)
            {
                if (item.Title == "Manager")
                {
                    managers2.Add(item);
                }
            }
            return managers2;
        }

        public static List<Clerk> ReadClerkList(string filePath)
        {
            List<Clerk> clerks = new List<Clerk>();
            List<Clerk> clerks2 = new List<Clerk>();

            string json = File.ReadAllText(filePath);
            clerks = JsonConvert.DeserializeObject<List<Clerk>>(json);

            foreach (var item in clerks)
            {
                if (item.Title == "Clerk")
                {
                    clerks2.Add(item);
                }
            }

            return clerks2;
        }
    }
}
