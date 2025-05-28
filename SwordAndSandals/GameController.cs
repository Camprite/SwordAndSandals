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
        public Warrior Player {  get; set; } = new Warrior();

        //Used forms to show
        public StartGameForm startGameForm = new StartGameForm(); 
        public Menu menuForm = new Menu(); 
        public InventoryForm inventoryForm = new InventoryForm(); 
        public BattleForm battleForm = new BattleForm(); 
        public ShopForm shopForm = new ShopForm(); 




        public GameController() { }

        public int startGame()
        {
            if(this.Player == null)
            {
                Player = this.getPlayer();
                menuForm.player = Player;
            }

            while (true)
            {
                var menuOption = menuForm.ShowDialog();


                if (menuOption == DialogResult.Cancel) {
                    return 0;
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
            }else
            {
                throw new GameException("Game cannot start without warrior");
            }
        }
    }
}
