using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{

    public enum CartType
    {
        Weapon = 0,
        Armour = 1,
        Spell = 2,

    }
    public class ShopFormController
    {
        public CartType currentCart = 0;
        public ShopForm ShopForm { get; set; }
        public Menu menu;
        public Warrior Player { get; set; }
        public int CartValue = 0;
        public List<IWarriorItem> ItemsInCart {  get; set; }

        public WeaponController WeaponController = new WeaponController();

        public ShopFormController()
        {
        }

        public void InitilizeShopFormControls()
        {
            ShopForm.currentMoney.Text = Player.Money.ToString();
            //ShopForm.cartValue.Text = this.CartValue.ToString();


            //Ustawienie żeby przy zaznaczeniu było zaznaczone id przedmiotu a nie nazwa
            ShopForm.WeaponSearchResultListBox.DisplayMember = "DisplayText";
            ShopForm.WeaponSearchResultListBox.ValueMember = "Id";

            var weaponItems = Enum.GetValues(typeof(WeaponEnum))
                .Cast<WeaponEnum>()
                .Select(w => new
                {
                    Name = w.ToString(),     // co będzie widoczne
                    Value = (int)w           // wartość wewnętrzna
                })
                .ToList();
            ShopForm.comboBoxWeaponEnum.DataSource = weaponItems;
            ShopForm.comboBoxWeaponEnum.DisplayMember = "Name";  // co użytkownik widzi
            ShopForm.comboBoxWeaponEnum.ValueMember = "Value";
            //foreach ( var weaponItem in weaponItems)
            //{
            //    ShopForm.comboBoxWeaponEnum.Items.Add(weaponItem);
            //}

            //this.ShopForm.currentMoney.Text = weaponNames.ToString();


            var weaponSearchTypes = Enum.GetValues(typeof(WeaponSearchEnum))
               .Cast<WeaponSearchEnum>()
               .Select(w => new
               {
                   Display = w.GetType().GetField(w.ToString()).GetCustomAttribute<DescriptionAttribute>()?.Description ?? w.ToString(),
                   Name = w.ToString(),     // co będzie widoczne
                   Value = (int)w           // wartość wewnętrzna
               })
               .ToList();
            ShopForm.comboBoxWeapon.DataSource = weaponSearchTypes;
            ShopForm.comboBoxWeapon.DisplayMember = "Display";  // co użytkownik widzi
            ShopForm.comboBoxWeapon.ValueMember = "Value";
            


            ShopForm.comboBoxWeapon.SelectedIndex = 0;
            ShopForm.comboBoxWeaponEnum.SelectedIndex = 0;
            ShopForm.SearchButtonWeapon.Click += (o, s) => { onWeaponSelect(o, s); };

            ShopForm.comboBoxWeapon.SelectedIndexChanged += (o, s) => {
                var weaponSelectType = (WeaponSearchEnum) ShopForm.comboBoxWeapon.SelectedValue;
                if (weaponSelectType == WeaponSearchEnum.WeaponsByType){
                    ShopForm.comboBoxWeaponEnum.Visible = true;
                }
                else
                {
                    ShopForm.comboBoxWeaponEnum.Visible = false;
                }
            
            };

            ShopForm.buyButton.Click += (o,s) => onBuyClick(o,s);

            ShopForm.exitButton.Click += (o, s) => {
                this.menu.nextForm = FormEnum.None;
                this.ShopForm.Close();
            };
        }

       

        public void onWeaponSelect(object o, EventArgs s)
        {
            var weaponSelectType = (WeaponSearchEnum)ShopForm.comboBoxWeapon.SelectedValue;

            ShopForm.WeaponSearchResultListBox.Visible = true;
            ShopForm.ArmourSearchResultListBox.Visible = false;
            ShopForm.SpellSearchResultListBox.Visible = false;
            ShopForm.WeaponSearchResultListBox.DataSource = null;
            switch (weaponSelectType)
            {
                case WeaponSearchEnum.AllWeapons:
                    {
                        
                        var result = WeaponController.GetWeapons();
                        ShopForm.WeaponSearchResultListBox.DataSource = result;
                     
                        break;
                    }
                case WeaponSearchEnum.WeaponsAvaiableByLevel:
                    {
                        var result = WeaponController.GetWeaponsAvaialbeByLevel(Player);
                        ShopForm.WeaponSearchResultListBox.DataSource = result;
                        break;
                    }
                case WeaponSearchEnum.WeaponsAvaiableByPrice:
                    {
                        var result = WeaponController.GetWeaponsAvaialbeByPrice(Player);
                        ShopForm.WeaponSearchResultListBox.DataSource = result;
                        break;
                    }
                case WeaponSearchEnum.WeaponsAvaiableByPriceAndLevel:
                    {
                        var result = WeaponController.GetWeaponsAvaialbeByPriceAndLevel(Player);
                        ShopForm.WeaponSearchResultListBox.DataSource = result;
                        break;
                    }
                case WeaponSearchEnum.WeaponsByType:
                    {
                        WeaponEnum weaponEnum = (WeaponEnum)ShopForm.comboBoxWeaponEnum.SelectedValue;
                        var result = WeaponController.GetWeaponsAvaialbeByType(weaponEnum, Player);
                        ShopForm.WeaponSearchResultListBox.DataSource = result;
                        break;
                    }
            }


       
        }
        
        public void onBuyClick(object sender, EventArgs e)
        {
            
            if (ShopForm.WeaponSearchResultListBox.Visible)
            {
                int itemId = (int)ShopForm.WeaponSearchResultListBox.SelectedValue;
                var weapon = WeaponController.getWeaponById(itemId);
                if (weapon.Price > Player.Money)
                {
                    MessageBox.Show("Not enough money");
                }
                else if (weapon.Lvl > Player.Level)
                {
                    MessageBox.Show("Not enough level");
                }
                else
                {
                    Player.Money -= weapon.Price;
                    Player.Weapons.Add(weapon);
                    MessageBox.Show($"Congratulations you just buyed:{weapon.ToString()} ");
                }

                //MessageBox.Show(ShopForm.WeaponSearchResultListBox.SelectedValue.ToString());

            }
            else if (ShopForm.ArmourSearchResultListBox.Visible)
            {

            }
            else if (ShopForm.SpellSearchResultListBox.Visible)
            {

            }

            ShopForm.currentMoney.Text = Player.Money.ToString();

        }


    }

   
}
