using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public static class SpellRepository
    {
        
      public static  List<Spell> GetSpells()
        {
            
            var spells = new List<Spell>();

            // --- Level 1-5 Spells (Low Mana, Basic Effects) ---

            // Offensive Spells (Damage, Speed = 0, Heal = 0)
            spells.Add(new Spell(0, "Firebolt", "Launches a small fiery projectile.", SpellEnum.Offensive, 5, 15, 0, 0, 50));
            spells.Add(new Spell(1, "Ice Shard", "Hurls a sharp shard of ice.", SpellEnum.Offensive, 6, 17, 0, 0, 55));
            spells.Add(new Spell(2, "Magic Missile", "Fires a weak, homing magical bolt.", SpellEnum.Offensive, 7, 18, 0, 0, 60));
            spells.Add(new Spell(3, "Stone Toss", "Conjures and throws a jagged rock.", SpellEnum.Offensive, 8, 20, 0, 0, 65));
            spells.Add(new Spell(4, "Wind Slash", "A quick cut of concentrated air.", SpellEnum.Offensive, 9, 22, 0, 0, 70));

            // Healing Spells (Damage = 0, Speed = 0, Heal, Mana)
            spells.Add(new Spell(5, "Minor Heal", "Restores a small amount of health.", SpellEnum.Healing, 10, 0, 0, 25, 75));
            spells.Add(new Spell(6, "First Aid", "A quick patch-up for minor wounds.", SpellEnum.Healing, 12, 0, 0, 30, 80));

            // Defensive Spells (Damage = 0, Heal = 0, Speed, Mana)
            spells.Add(new Spell(7, "Evasion Step", "Briefly increases your chance to dodge.", SpellEnum.Defensive, 10, 0, 10, 0, 90)); // Speed as Dodge/Evasion %
            spells.Add(new Spell(8, "Stone Skin", "Hardens your skin, reducing incoming physical damage.", SpellEnum.Defensive, 15, 0, 0, 0, 100)); // Speed as Defense % (if applicable)

            // --- Level 6-10 Spells (Medium Mana, Moderate Effects) ---

            // Offensive
            spells.Add(new Spell(9, "Fireball", "Throws a devastating fireball at the opponent.", SpellEnum.Offensive, 15, 30, 0, 0, 150));
            spells.Add(new Spell(10, "Lightning Bolt", "Strikes an enemy with a bolt of lightning.", SpellEnum.Offensive, 18, 35, 0, 0, 160));
            spells.Add(new Spell(11, "Arcane Orb", "Hurls a slow-moving orb of raw magic.", SpellEnum.Offensive, 20, 40, 0, 0, 170));
            spells.Add(new Spell(12, "Poison Cloud", "Creates a cloud of toxic gas around the enemy.", SpellEnum.Offensive, 22, 10, 0, 0, 180)); // Low initial damage, potential DoT
            spells.Add(new Spell(13, "Earth Spike", "Summons sharp spikes from the ground to impale foes.", SpellEnum.Offensive, 25, 45, 0, 0, 190));

            // Healing
            spells.Add(new Spell(14, "Healing Wave", "A surge of restorative energy heals the caster.", SpellEnum.Healing, 25, 0, 0, 60, 200));
            spells.Add(new Spell(15, "Regeneration", "Heals a moderate amount over time.", SpellEnum.Healing, 30, 0, 0, 15, 220)); // Heal per turn/tick

            // Defensive
            spells.Add(new Spell(16, "Iron Will", "Increases your resistance to magical attacks.", SpellEnum.Defensive, 20, 0, 0, 0, 230)); // Speed as Magic Resist %
            spells.Add(new Spell(17, "Barrier", "Creates a temporary magical shield.", SpellEnum.Defensive, 25, 0, 0, 0, 250)); // Speed as damage absorption amount
            spells.Add(new Spell(18, "Swiftness", "Greatly boosts your agility for a short duration.", SpellEnum.Defensive, 20, 0, 25, 0, 240));

            // --- Level 11-15 Spells (High Mana, Powerful Effects) ---

            // Offensive
            spells.Add(new Spell(19, "Inferno", "Engulfs targets in a massive explosion of flames.", SpellEnum.Offensive, 40, 70, 0, 0, 350));
            spells.Add(new Spell(20, "Chain Lightning", "A bolt of lightning that jumps to multiple targets.", SpellEnum.Offensive, 45, 60, 0, 0, 370));
            spells.Add(new Spell(21, "Void Blast", "Unleashes a concentrated burst of dark energy.", SpellEnum.Offensive, 50, 80, 0, 0, 400));
            spells.Add(new Spell(22, "Blizzard", "Calls forth a chilling storm that damages and slows enemies.", SpellEnum.Offensive, 55, 65, 0, 0, 420)); // Damage + Slow
            spells.Add(new Spell(23, "Meteor Strike", "Calls a fiery meteor from the sky to smash enemies.", SpellEnum.Offensive, 60, 90, 0, 0, 450));

            // Healing
            spells.Add(new Spell(24, "Greater Heal", "Restores a significant amount of health to the caster.", SpellEnum.Healing, 45, 0, 0, 120, 480));
            spells.Add(new Spell(25, "Mass Regeneration", "Heals all allies over time.", SpellEnum.Healing, 60, 0, 0, 40, 520)); // Heal per turn/tick for multiple targets

            // Defensive
            spells.Add(new Spell(26, "Absolute Defense", "Temporarily renders the caster immune to all damage.", SpellEnum.Defensive, 70, 0, 0, 0, 600)); // Short duration immunity
            spells.Add(new Spell(27, "Time Warp", "Greatly increases the caster's action speed.", SpellEnum.Defensive, 50, 0, 50, 0, 550));
            spells.Add(new Spell(28, "Spell Reflection", "Reflects a single incoming spell back at the caster.", SpellEnum.Defensive, 40, 0, 0, 0, 500));

            // --- Level 16-20 Spells (Very High Mana, Ultimate Effects) ---

            // Offensive
            spells.Add(new Spell(29, "Cataclysm", "Unleashes a destructive force that devastates all enemies.", SpellEnum.Offensive, 80, 150, 0, 0, 800));
            spells.Add(new Spell(30, "Death Coil", "Fires a projectile that deals heavy damage and drains health.", SpellEnum.Offensive, 75, 130, 0, 0, 750));
            spells.Add(new Spell(31, "Arcane Singularity", "Creates a localized black hole that pulls in and crushes foes.", SpellEnum.Offensive, 90, 180, 0, 0, 900));

            // Healing
            spells.Add(new Spell(32, "Divine Intervention", "Heals the caster to full health instantly.", SpellEnum.Healing, 80, 0, 0, 9999, 1000)); // Heals to max
            spells.Add(new Spell(33, "Aura of Vitality", "Continuously heals all allies for a prolonged period.", SpellEnum.Healing, 90, 0, 0, 50, 1200)); // Stronger HoT

            // Defensive
            spells.Add(new Spell(34, "Void Shield", "Envelopes the caster in an energy shield that absorbs massive damage.", SpellEnum.Defensive, 70, 0, 0, 0, 950));
            spells.Add(new Spell(35, "Perfect Dodge", "Guarantees dodging all attacks for a very short duration.", SpellEnum.Defensive, 60, 0, 100, 0, 850));


            return spells;
        } 
    }
}
