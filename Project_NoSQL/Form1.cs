using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NoSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void TestConnection()
        {
            String test = String.Empty;
            /*var connection = MongoClientSettings.FromConnectionString(ConfigurationManager.ConnectionStrings["Mongo"].ConnectionString);
            MongoClient mongoClient = new MongoClient(connection);
            var dblist = mongoClient.ListDatabases().ToList();

            Console.WriteLine("the list of databases on this server is: ");
            foreach (var db in dblist)
            {
                Console.WriteLine(db);
            }
            */
        }

    }
}
