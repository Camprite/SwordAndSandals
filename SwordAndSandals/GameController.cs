using SwordAndSandals.Exceptions;
using SwordAndSandals.FormControllers;
using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class GameController
    {
        //Entities
        public Warrior Player { get; set; }

        //Used forms to show
        public StartGameForm startGameForm = new StartGameForm(); 
        public Menu menuForm = new Menu(); 
        public InventoryForm inventoryForm = new InventoryForm(); 
        public BattleForm battleForm = new BattleForm(); 
        public ShopForm shopForm = new ShopForm();
        public BattleFormController battleFormController = new BattleFormController();
        public ShopFormController shopFormController = new ShopFormController();
        public InventoryFormController inventoryFormController = new InventoryFormController();

        public BattleController BattleController = new BattleController();
        


        public GameController() { }

        public int startGame()
        {
            if(this.Player == null)
            {
                this.Player = this.getPlayer();
                menuForm.player = this.Player;
                menuForm.updateForm();

                BattleController.Player = this.Player;


                battleFormController.BattleForm = this.battleForm;
                battleFormController.menu = this.menuForm;


             
                shopFormController.ShopForm = this.shopForm;
                shopFormController.Player = this.Player;
                shopFormController.menu = this.menuForm;

                inventoryFormController.inventoryForm = this.inventoryForm;
                inventoryFormController.Player = this.Player;



                shopFormController.InitializeDelegates();
                shopFormController.InitilizeShopFormControls();
                inventoryFormController.InitializeDelegates();
                inventoryFormController.InitilizeInventoryFormControls();
                menuForm.updateForm();
            }

            while (true)
            {
                menuForm.updateForm();

                if (BotFactory.CheckIfBossFight(this.Player))
                    menuForm.BeforeBossFightLabel.Text = "Za chwilę masz walkę z bossem, przygotuj się.";

                var menuOption = menuForm.ShowDialog();

                if (menuOption == DialogResult.Cancel) {
                    return 0;
                }

                

                if (menuOption == DialogResult.OK) {
                    FormEnum nextForm = menuForm.nextForm;
                    switch (nextForm) {
                        case (FormEnum.Shop):
                            shopForm.ShowDialog();
                            //shopFormController.InitilizeShopFormControls();
                            break;
                        case (FormEnum.Battle):
                            // Wygenerowanie bota odpowiadającego graczowi
                            BattleController.Bot = BotFactory.GenerateBot(BattleController.Player);

                            // Reset punktow zycia gsracza/odnowy zaklecia
                            battleFormController.BattleController = new BattleController();
                            battleFormController.BattleController.Bot = BattleController.Bot;

                            battleFormController.BattleController.Player = this.Player;

                            battleFormController.InitilizeBattleFormControls();
                            battleFormController.BattleForm.ShowDialog();
                            break;
                        case (FormEnum.Inventory):
                            inventoryFormController.InitilizeInventoryFormControls();
                            inventoryFormController.inventoryForm.ShowDialog();
                            

                            //menuForm.updateForm();
                            break;
                    }
                    
                    
                }


            }

            return 0;
        }

        public Warrior getPlayer()
        {
            var result = startGameForm.ShowDialog();
            // Player created sucessfuly
            if (result == DialogResult.OK)
            {
                return startGameForm.Player; 
            }
            else
            {
                throw new GameException("Game cannot start without warrior");
            }
        }
    }
}
