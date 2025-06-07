using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class ShopFormController
    {
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
            ShopForm.cartValue.Text = this.CartValue.ToString();


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

            ShopForm.exitButton.Click += (o, s) => {
                this.menu.nextForm = FormEnum.None;
                this.ShopForm.Close();
            };
        }
        public void onWeaponSelect(object o, EventArgs s)
        {
            var weaponSelectType = (WeaponSearchEnum)ShopForm.comboBoxWeapon.SelectedValue;

            switch (weaponSelectType)
            {
                case WeaponSearchEnum.AllWeapons:
                    {
                        ShopForm.SearchResultListBox.Items.Clear(); 
                        var result = WeaponController.GetWeapons();
                        foreach (var weapon in result)
                        {
                           ShopForm.SearchResultListBox.Items.Add(weapon.ToString());


                        }
                        break;
                    }
            }
            //this.ShopForm.currentMoney.Text = weaponSelectType;
;

       
        }
        



    }

   
}
