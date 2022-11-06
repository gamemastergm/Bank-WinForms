using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Bank
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            --Console.ReadKey();

        }
        private static void TestConnection()
        {
            using(NpgsqlConnection con = GetConnection()) 
            { 
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Debug.WriteLine("Connected");
                }
            }
        }
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;port=5432;user Id=postgres;Password=postgres;Database=Bank");
        }
    }
}
