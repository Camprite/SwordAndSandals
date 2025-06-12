using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class ArmourController
    {
         private List<Armour> helmets;
         private List<Armour> shields;
         private List<Armour> boots;
         private List<Armour> chestplates;
    public ArmourController()
    {
        this.helmets = ArmourRepository.GetHelmets();
        this.shields = ArmourRepository.GetShields();
        this.boots = ArmourRepository.GetBoots();
        this.chestplates = ArmourRepository.GetChestplates();
    }
        public Armour getArmourById(int id)
        {
                Armour armour = helmets.Find(helmets => helmets.Id == id);
                if (armour != null)
                {
                return armour;
                }
                 armour = shields.Find(helmets => helmets.Id == id);
                if (armour != null)
                {
                return armour;
                }
                 armour = boots.Find(helmets => helmets.Id == id);
                if (armour != null)
                {
                return armour;
                }
                 armour = chestplates.Find(helmets => helmets.Id == id);
                if (armour != null)
                {
                return armour;
                }
            return null;
        }

        public List<Armour> getAll(ArmourEnum armourEnum)
        {
            var list = getListByEnum(armourEnum);

            return list;

        }
              //return weapons.Where(e => e.Lvl <= entity.Level & !entity.Weapons.Contains(e)).ToList();
        public List<Armour> getByLvl(ArmourEnum armourEnum,Warrior player)
        {
            var list = getListByEnum(armourEnum);

            return list.Where(e => e.Level <= player.Level).ToList();

        }
        public List<Armour> getByPrice(ArmourEnum armourEnum,Warrior player)
        {
            var list = getListByEnum(armourEnum);

            return list.Where(e => e.Price <= player.Money).ToList();

        }
        public List<Armour> getByPriceAndLvl(ArmourEnum armourEnum,Warrior player)
        {
            var list = getListByEnum(armourEnum);

            return list.Where(e => e.Price <= player.Money && e.Level <= player.Level).ToList();

        }
        public List<Armour> getByNotAvaiable(ArmourEnum armourEnum,Warrior player)
        {
            var list = getListByEnum(armourEnum);

            return list.Where(e => e.Price >= player.Money && e.Level >= player.Level).ToList();

        }
        public List<Armour> getByDefence(ArmourEnum armourEnum,Warrior player)
        {
            var list = getListByEnum(armourEnum);

            return list.OrderByDescending(e => e.Defence).ToList();

        }
        public List<Armour> getListByEnum(ArmourEnum armourEnum) {
            switch (armourEnum) { 
                case ArmourEnum.Helmet:
                        return helmets;
                    
                case ArmourEnum.Shield:
                        return shields;
            
                case ArmourEnum.Chestplate:
                    return chestplates;
            
                case ArmourEnum.Boots:
                    return boots;
            }
            return new List<Armour>(); 
        }
    
    }
}
