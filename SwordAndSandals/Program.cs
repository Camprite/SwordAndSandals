using static SwordAndSandals.StartGame;
using SwordAndSandalsLogic;

namespace SwordAndSandals
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            StartGame stargGame = new StartGame();
            if (stargGame.ShowDialog() == DialogResult.OK)
            {
                Form1 form = new Form1(stargGame.PlayerName,stargGame.Strenght,stargGame.Agility,stargGame.Vitality,stargGame.Int);
                Application.Run(form);
            }
            
            
        }
    }
}