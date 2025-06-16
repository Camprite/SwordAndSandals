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
        public void InitializeDelegates()
        {
            inventoryForm.exitButton.Click += (s, e) =>
            {
                inventoryForm.Close();
            };
            inventoryForm.saveEquipment.Click += (s, e) => saveEquipment(s, e);
        }
        public void InitilizeInventoryFormControls()
        {
            if (inventoryForm == null || Player == null)
            {
                return;
            }
            //inventoryForm = new InventoryForm();



            // Set player items to comboboxes
            inventoryForm.comboBoxWeapon.DataSource = null;
            inventoryForm.comboBoxChestplate.DataSource = null;
            inventoryForm.comboBoxHelmet.DataSource = null;
            inventoryForm.comboBoxSandals.DataSource = null;
            inventoryForm.comboBoxShield.DataSource = null;



            inventoryForm.comboBoxWeapon.DataSource = Player.Weapons;
            inventoryForm.comboBoxChestplate.DataSource = Player.getArmourByType(ArmourEnum.Chestplate);
            inventoryForm.comboBoxHelmet.DataSource = Player.getArmourByType(ArmourEnum.Helmet);
            inventoryForm.comboBoxSandals.DataSource = Player.getArmourByType(ArmourEnum.Boots);
            inventoryForm.comboBoxShield.DataSource = Player.getArmourByType(ArmourEnum.Shield);

            //Check if already have any armour

            if (Player.Weapon != null) {
                inventoryForm.waeponLabel.Text = Player.Weapon.Name;
                inventoryForm.comboBoxWeapon.SelectedValue = Player.Weapon.Id;
            }
            if (Player.Helmet != null) {
                inventoryForm.helmetLabel.Text = Player.Helmet.Name;
                inventoryForm.comboBoxHelmet.SelectedValue = Player.Helmet.Id;
            }
            if (Player.Chestplate != null) {
                inventoryForm.chestplateLabel.Text = Player.Chestplate.Name;
                inventoryForm.comboBoxChestplate.SelectedValue = Player.Chestplate.Id;
            }
            if (Player.Shield != null) {
                inventoryForm.shieldLabel.Text = Player.Shield.Name;
                inventoryForm.comboBoxShield.SelectedValue = Player.Shield.Id;
            }
            if (Player.Boots != null) {
                inventoryForm.sandalsLabel.Text = Player.Boots.Name;
                inventoryForm.comboBoxSandals.SelectedValue = Player.Boots.Id;
            }


            // Set view properties
            inventoryForm.comboBoxWeapon.DisplayMember = "InventoryText";
            inventoryForm.comboBoxWeapon.ValueMember = "Id";
            inventoryForm.comboBoxWeapon.Update();
            
            inventoryForm.comboBoxChestplate.DisplayMember = "InventoryText";
            inventoryForm.comboBoxChestplate.ValueMember = "Id";
            inventoryForm.comboBoxChestplate.Update();

            inventoryForm.comboBoxHelmet.DisplayMember = "InventoryText";
            inventoryForm.comboBoxHelmet.ValueMember = "Id";
            inventoryForm.comboBoxHelmet.Update();

            inventoryForm.comboBoxSandals.DisplayMember = "InventoryText";
            inventoryForm.comboBoxSandals.ValueMember = "Id";
            inventoryForm.comboBoxSandals.Update();
            
            inventoryForm.comboBoxShield.DisplayMember = "InventoryText";
            inventoryForm.comboBoxShield.ValueMember = "Id";
            inventoryForm.comboBoxShield.Update();


       


            //Console.WriteLine(Player.Weapons.ToString());
            //inventoryForm.comboBoxWeapon.DisplayMember = "Name";
            //inventoryForm.comboBoxWeapon.ValueMember = "Id";

            //ShopForm.comboBoxWeaponEnum.DataSource = weaponItems;
            //ShopForm.comboBoxWeaponEnum.DisplayMember = "Name";  // co użytkownik widzi
            //ShopForm.comboBoxWeaponEnum.ValueMember = "Value";

            //this.inventoryForm.Update();
            //this.inventoryForm.Refresh();
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

            MessageBox.Show(Player.Weapons.Count.ToString());
            this.InitilizeInventoryFormControls();
            //MessageBox.Show(Player.Weapons.ToString());
        }
    }
}
