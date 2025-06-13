using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals.FormControllers
{
    public class InventoryFormController
    {
        public InventoryForm inventoryForm { get; set; }
        public Warrior Player { get; set; }

        public InventoryFormController()
        {

        }
        public void InitilizeInventoryFormControls()
        {
            if (inventoryForm == null || Player == null)
            {
                return;
            }

            inventoryForm.exitButton.Click += (s, e) =>
            {
                inventoryForm.Close();
            };
            // Set player items to comboboxes
            inventoryForm.comboBoxWeapon.DataSource = Player.Weapons;
            inventoryForm.comboBoxChestplate.DataSource = Player.getArmourByType(ArmourEnum.Chestplate);
            inventoryForm.comboBoxHelmet.DataSource = Player.getArmourByType(ArmourEnum.Helmet);
            inventoryForm.comboBoxSandals.DataSource = Player.getArmourByType(ArmourEnum.Boots);
            inventoryForm.comboBoxShield.DataSource = Player.getArmourByType(ArmourEnum.Shield);
           
            // Set view properties
            inventoryForm.comboBoxWeapon.DisplayMember = "InventoryText";
            inventoryForm.comboBoxWeapon.ValueMember = "Id";
            
            inventoryForm.comboBoxChestplate.DisplayMember = "InventoryText";
            inventoryForm.comboBoxChestplate.ValueMember = "Id";
            
            inventoryForm.comboBoxHelmet.DisplayMember = "InventoryText";
            inventoryForm.comboBoxHelmet.ValueMember = "Id";
            
            inventoryForm.comboBoxSandals.DisplayMember = "InventoryText";
            inventoryForm.comboBoxSandals.ValueMember = "Id";
            
            inventoryForm.comboBoxShield.DisplayMember = "InventoryText";
            inventoryForm.comboBoxShield.ValueMember = "Id";


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
            var selectedWeapon = Player.Weapons.First(e => e.Id == (int) inventoryForm.comboBoxWeapon.SelectedValue);
            var selectedHelmet = Player.Armours.First(e => e.Id == (int) inventoryForm.comboBoxHelmet.SelectedValue);
            var selectedChestplate = Player.Armours.First(e => e.Id == (int) inventoryForm.comboBoxChestplate.SelectedValue);
            var selectedShield = Player.Armours.First(e => e.Id == (int) inventoryForm.comboBoxShield.SelectedValue);
            var selectedBoots = Player.Armours.First(e => e.Id == (int)inventoryForm.comboBoxSandals.SelectedValue);
            
            Player.Weapon = selectedWeapon;
            Player.Helmet = selectedHelmet;
            Player.Chestplate = selectedChestplate;
            Player.Shield = selectedShield; 
            Player.Boots = selectedBoots;

            MessageBox.Show("Saved");
            //MessageBox.Show(Player.Weapons.ToString());
        }
    }
}
