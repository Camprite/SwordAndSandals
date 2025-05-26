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
                Warrior Player = new Warrior();
                Warrior Bot = new Warrior();

                Battle BattleForm = new Battle();

                BattleController battleController = new BattleController(Player, Bot);
                FormController formController = new FormController(Player, Bot, battleController, BattleForm);

                formController.StartGame = stargGame;
                formController.BattleForm = BattleForm;
                formController.BattleController = battleController;

                formController.InitializeHeroesAndArmours(stargGame);

                formController.BattleController = new BattleController(formController.Player, formController.Bot);

                formController.InitilizeBattleFormControls();


                Application.Run(BattleForm);
            }
        }
    }
}