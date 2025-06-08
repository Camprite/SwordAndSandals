using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class WeaponController
    {
        private List<Weapon> weapons;
        public WeaponController() {
            this.weapons = WeaponRepository.GetWeapons();
        }

        public Weapon getWeaponById(int id)
        {
            return this.weapons.FirstOrDefault(w => w.Id == id);
        }
        public List<Weapon> GetWeapons()
        {
            return this.weapons;
        }

        public List<Weapon> GetWeaponsAvaialbeByLevel(Warrior entity)
        {

            return weapons.Where(e => e.Lvl <= entity.Level & !entity.Weapons.Contains(e)).ToList();
        }

        public List<Weapon> GetWeaponsAvaialbeByPrice(Warrior entity)
        {

            return weapons.Where(e => e.Price <= entity.Money & !entity.Weapons.Contains(e)).ToList();
        }

        public List<Weapon> GetWeaponsAvaialbeByPriceAndLevel(Warrior entity)
        {

            return weapons.Where(e => e.Lvl <= entity.Level & e.Price<= entity.Money & !entity.Weapons.Contains(e)).ToList();
        }

        public List<Weapon> GetWeaponsAvaialbeByPriceAndLevelDamageDesc(Warrior entity)
        {

            return weapons.Where(e => e.Lvl <= entity.Level & e.Price <= entity.Money & !entity.Weapons.Contains(e)).OrderByDescending(e => e.Price).ToList();
        }

        public List<Weapon> GetWeaponsAvaialbeByType(WeaponEnum weaponEnum, Warrior entity)
        {

            return weapons.Where(e => e.WeaponEnum == weaponEnum & !entity.Weapons.Contains(e)).ToList();
        }

    }
}
