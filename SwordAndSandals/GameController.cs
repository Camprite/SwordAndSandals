using SwordAndSandals.Exceptions;
using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

        public BattleController BattleController;


        public GameController() { }

        public int startGame()
        {
            if(this.Player == null)
            {
                this.Player = this.getPlayer();
                menuForm.player = this.Player;


                battleFormController.BattleForm = this.battleForm;

                battleFormController.Player = this.Player;
                
                
                menuForm.updateForm();
            }

            while (true)
            {
                //menuForm.updateForm();
                var menuOption = menuForm.ShowDialog();
                

                if (menuOption == DialogResult.Cancel) {
                    return 0;
                }
                if (menuOption == DialogResult.OK) {
                    FormEnum nextForm = menuForm.nextForm;
                    switch (nextForm) {
                        case (FormEnum.Shop):
                            shopForm.ShowDialog();
                            break;
                        case (FormEnum.Battle):
                            // Wygenerowanie bota odpowiadającego graczowi

                            // Reset punktow zycia gracza/odnowy zaklecia
                            
                            battleFormController.InitilizeBattleFormControls();
                            battleFormController.BattleForm.ShowDialog();
                            break;
                        case (FormEnum.Inventory):
                            inventoryForm.ShowDialog();
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
