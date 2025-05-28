using static SwordAndSandals.StartGameForm;
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
            GameController game = new GameController();

            int exit = game.startGame();

            if (exit == 0) {
                 System.Environment.Exit(0);
            }  


            //StartGame startGame = new StartGame();
            //if (startGame.ShowDialog() == DialogResult.OK)
            //{
            //    //Warrior Player = new Warrior();
            //    //Warrior Bot = new Warrior();

            //    Battle BattleForm = new Battle();

            //    BattleController battleController = new BattleController(startGame.player);
            //    FormController formController = new FormController(battleController, BattleForm);

            //    formController.StartGame = startGame;
            //    formController.BattleForm = BattleForm;
            //    formController.BattleController = battleController;

            //    formController.InitializeHeroesAndArmours(startGame);

            //    //formController.BattleController = new BattleController(formController.Player, formController.Bot);

            //    formController.InitilizeBattleFormControls();


                //Application.Run(game.startGame());
            //}
        }
    }
}