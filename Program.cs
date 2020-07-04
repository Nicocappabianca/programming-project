using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public static class Program
    {
        private static OrdersRepository App;

        public static OrdersRepository getApp()
        {
            return App;
        }
        public static void LoadData()
        {
            try
            {
                Stream fileStream = File.OpenRead("Sistema.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                App = (OrdersRepository)deserializer.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("cargarInformacion: " + ex.Message);
                App = new OrdersRepository();
            }
        }
        public static void SaveData(object sender, EventArgs e)
        {
            Stream fileStream = File.Create("Sistema.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fileStream, App);
            fileStream.Close();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadData(); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new System.EventHandler(SaveData);
            Application.Run(new FormMain());
        }
    }
}
