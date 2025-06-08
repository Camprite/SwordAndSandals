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
        public ArmourController ArmourController= new ArmourController();

        public ShopFormController()
        {
        }
    

        public void InitilizeShopFormControls()
        {
            ShopForm.currentMoney.Text = Player.Money.ToString();
            //ShopForm.cartValue.Text = this.CartValue.ToString();


            //Define which property 'll be show in listBox
            ShopForm.WeaponSearchResultListBox.DisplayMember = "DisplayText";
            ShopForm.WeaponSearchResultListBox.ValueMember = "Id"; 
            
            ShopForm.ArmourSearchResultListBox.DisplayMember = "DisplayText";
            ShopForm.ArmourSearchResultListBox.ValueMember = "Id";



            var weaponItems = Enum.GetValues(typeof(WeaponEnum))
                .Cast<WeaponEnum>()
                .Select(w => new
                {
                    Name = w.ToString(),     // co będzie widoczne
                    Value = (int)w           // wartość wewnętrzna
                })
                .ToList();

            var armourTypes = Enum.GetValues(typeof(ArmourEnum))
                .Cast<ArmourEnum>()
                .Select(w => new
                {
                    Name = w.ToString(),     // co będzie widoczne
                    Value = (int)w           // wartość wewnętrzna
                })
                .ToList();

            var weaponSearchTypes = Enum.GetValues(typeof(WeaponSearchEnum))
              .Cast<WeaponSearchEnum>()
              .Select(w => new
              {
                  Display = w.GetType().GetField(w.ToString()).GetCustomAttribute<DescriptionAttribute>()?.Description ?? w.ToString(),
                  Name = w.ToString(),     // co będzie widoczne
                  Value = (int)w           // wartość wewnętrzna
              })
              .ToList();

            var armourSearchTypes = Enum.GetValues(typeof(ArmourSearchEnum))
              .Cast<ArmourSearchEnum>()
              .Select(w => new
              {
                  Display = w.GetType().GetField(w.ToString()).GetCustomAttribute<DescriptionAttribute>()?.Description ?? w.ToString(),
                  Name = w.ToString(),     // co będzie widoczne
                  Value = (int)w           // wartość wewnętrzna
              })
              .ToList();

            // Armour types enum combo box
            ShopForm.comboBoxArmourTypeEnum.DataSource = armourTypes;
            ShopForm.comboBoxArmourTypeEnum.DisplayMember = "Name";  
            ShopForm.comboBoxArmourTypeEnum.ValueMember = "Value";


            // Weapon types enum combo box
            ShopForm.comboBoxWeaponEnum.DataSource = weaponItems;
            ShopForm.comboBoxWeaponEnum.DisplayMember = "Name";  
            ShopForm.comboBoxWeaponEnum.ValueMember = "Value";

            // Weapon search options combo box
            ShopForm.comboBoxWeapon.DataSource = weaponSearchTypes;
            ShopForm.comboBoxWeapon.DisplayMember = "Display";  
            ShopForm.comboBoxWeapon.ValueMember = "Value";

            // Armour search options combo box
            ShopForm.comboBoxArmour.DataSource = armourSearchTypes;
            ShopForm.comboBoxArmour.DisplayMember = "Display";
            ShopForm.comboBoxArmour.ValueMember = "Value";


            // Set combo box not empty
            ShopForm.comboBoxWeapon.SelectedIndex = 0;
            ShopForm.comboBoxWeaponEnum.SelectedIndex = 0;

            ShopForm.comboBoxArmour.SelectedIndex = 0;
            ShopForm.comboBoxArmourTypeEnum.SelectedIndex = 0;


            // Set callback for weapon
            ShopForm.SearchButtonWeapon.Click += (o, s) => { onWeaponSelect(o, s); };

            //Set callback for armour
            ShopForm.SearchButtonArmour.Click += (o, s) => { onArmourSelect(o, s); };
           

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
            var result = new List<Weapon>();
            switch (weaponSelectType)
            {
                case WeaponSearchEnum.AllWeapons:
                    {
                        result = WeaponController.GetWeapons();
                        break;
                    }
                case WeaponSearchEnum.WeaponsAvaiableByLevel:
                    {
                        result = WeaponController.GetWeaponsAvaialbeByLevel(Player);
                        break;
                    }
                case WeaponSearchEnum.WeaponsAvaiableByPrice:
                    {
                        result = WeaponController.GetWeaponsAvaialbeByPrice(Player);
                        break;
                    }
                case WeaponSearchEnum.WeaponsAvaiableByPriceAndLevel:
                    {
                        result = WeaponController.GetWeaponsAvaialbeByPriceAndLevel(Player);
                        break;
                    }
                case WeaponSearchEnum.WeaponsByType:
                    {
                        WeaponEnum weaponEnum = (WeaponEnum)ShopForm.comboBoxWeaponEnum.SelectedValue;
                        result = WeaponController.GetWeaponsAvaialbeByType(weaponEnum, Player);
                        break;
                    }

            }
            ShopForm.WeaponSearchResultListBox.DataSource = result;



        }

        public void onArmourSelect(object sender, EventArgs e)
        {
            var armourSelectType = (ArmourSearchEnum)ShopForm.comboBoxArmour.SelectedValue;
            ArmourEnum armourEnum = (ArmourEnum)ShopForm.comboBoxArmourTypeEnum.SelectedValue;

            ShopForm.WeaponSearchResultListBox.Visible = false;
            ShopForm.ArmourSearchResultListBox.Visible = true;
            ShopForm.SpellSearchResultListBox.Visible = false;
            ShopForm.ArmourSearchResultListBox.DataSource = null;
            var result = new List<Armour>();
            ShopForm.ArmourSearchResultListBox.DisplayMember = "DisplayText";
            ShopForm.ArmourSearchResultListBox.ValueMember = "Id";
            switch (armourSelectType)
            {
                case ArmourSearchEnum.All:
                    {
                        result = ArmourController.getAll(armourEnum);
                        break;
                    }
                case ArmourSearchEnum.AvaiableByLevel:
                    {
                        result = ArmourController.getByLvl(armourEnum,Player);
                        break;
                    }
                case ArmourSearchEnum.AvaiableByPrice:
                    {
                        result = ArmourController.getByPrice(armourEnum,Player);
                        break;
                    }
                case ArmourSearchEnum.AvaiableByPriceAndLevel:
                    {
                        result = ArmourController.getByPriceAndLvl(armourEnum,Player);
                        break;
                    }
                case ArmourSearchEnum.NotAvaiable:
                    {
                        result = ArmourController.getByNotAvaiable(armourEnum,Player);
                        break;
                    }
                case ArmourSearchEnum.ByDefence:
                    {
                        result = ArmourController.getByDefence(armourEnum,Player);
                        break;
                    }

            }
            ShopForm.ArmourSearchResultListBox.DataSource = result;
        }


        public void onBuyClick(object sender, EventArgs e)
        {
            
            if (ShopForm.WeaponSearchResultListBox.Visible)
            {
                int itemId = (int)ShopForm.WeaponSearchResultListBox.SelectedValue;
                var weapon = WeaponController.getWeaponById(itemId);
                if (weapon.Price > Player.Money)
                {
                    MessageBox.Show("Not enought money");
                }
                else if (weapon.Lvl > Player.Level)
                {
                    MessageBox.Show("Not enought level");
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
                int itemId = (int)ShopForm.ArmourSearchResultListBox.SelectedValue;
                var armour = ArmourController.getArmourById(itemId);
                if (armour.Price > Player.Money)
                {
                    MessageBox.Show("Not enought money");
                }
                else if (armour.Level > Player.Level)
                {
                    MessageBox.Show("Not enought level");
                }
                else
                {
                    Player.Money -= armour.Price;
                    Player.Armours.Add(armour);
                    MessageBox.Show($"Congratulations you just buyed:{armour.ToString()} ");
                }

            }
            else if (ShopForm.SpellSearchResultListBox.Visible)
            {

            }

            ShopForm.currentMoney.Text = Player.Money.ToString();

        }


    }

   
}
