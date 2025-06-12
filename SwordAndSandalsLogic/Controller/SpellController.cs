using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic.Controller
{
    public class SpellController
    {
        public List<Spell> spells;


        public SpellController()
        {
            this.spells = SpellRepository.GetSpells();
        }

        public List<Spell> GetSpells() { return this.spells; }
        public List<Spell> GetByType(SpellEnum spellEnum) { return this.spells.Where(e=>e.Type == spellEnum).ToList(); }
        public Spell GetSpellById(int id) { return this.spells.FirstOrDefault(e=>e.Id == id); }
        public List<Spell> GetByLevel (Warrior warrior) { return this.spells.Where(e=>e.Level<=warrior.Level).ToList(); }
        public List<Spell> GetByPrice(Warrior warrior) { return this.spells.Where(e=> e.Price<=warrior.Money).ToList(); }
        public List<Spell> GetByPriceAndLevel(Warrior warrior) { return this.spells.Where(e => e.Level <= warrior.Level && e.Price <= warrior.Money).ToList(); ; }
        public List<Spell> GetByLevelAndType(Warrior warrior, SpellEnum spellEnum) { return this.spells.Where(e => e.Level <= warrior.Level && e.Type == spellEnum).ToList(); }




    }
}
