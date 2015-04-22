// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="tsdn">
//   Copyrigth 2015
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MongoDBTestApp
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Main class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
