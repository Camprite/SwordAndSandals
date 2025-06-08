using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class InventoryFormController
    {
       public InventoryForm inventoryForm {  get; set; }
       public Warrior Player { get; set; }

        public InventoryFormController()
        {

        }
        public void InitilizeInventoryFormControls()
        {
            if(inventoryForm == null || Player == null)
            {
                return;
            }

            inventoryForm.exitButton.Click += (s, e) =>
            {
                inventoryForm.Close();
            };

            inventoryForm.comboBoxWeapon.DataSource = Player.Weapons;
            inventoryForm.comboBoxWeapon.DisplayMember = "InventoryText";     
            inventoryForm.comboBoxWeapon.ValueMember = "Id";

            inventoryForm.saveEquipment.Click += (s, e) => saveEquipment(s, e);

        
            //Console.WriteLine(Player.Weapons.ToString());
            //inventoryForm.comboBoxWeapon.DisplayMember = "Name";
            //inventoryForm.comboBoxWeapon.ValueMember = "Id";

            //ShopForm.comboBoxWeaponEnum.DataSource = weaponItems;
            //ShopForm.comboBoxWeaponEnum.DisplayMember = "Name";  // co użytkownik widzi
            //ShopForm.comboBoxWeaponEnum.ValueMember = "Value";

        }

        private void saveEquipment(object s, EventArgs e)
        {
            MessageBox.Show(Player.Weapons.ToString());
        }
    }
}
