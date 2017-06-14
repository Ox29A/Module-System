using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModularSystem.Module_System.Enumerations;

namespace ModularSystem.Module_System.Examples.Spell_Casting
{
    internal class CastSpell : IModule
    {
        public string GetName()
        {
            return "Spell Casting";
        }

        public string GetDescription()
        {
            return "Spell Casting Module";
        }

        public void OnLoad()
        {
            Console.WriteLine("Spell Casting Module Loaded");

            //after attack example
            //TODO: Orbwalking.AfterAttack += OnAfterAttack; use this for after attack fam
        }

        public bool CanExecute()
        {
            //TODO: return Q.isReady() && menu.IsEnabled("Q") && Orbwalker.ActiveMode == Combo
            return true;
        }

        public void Execute()
        {
            //Only use this if you're not using after attack
            //Get target within range??
            //TODO if (Q.IsReady() && target.IsValidTarget(range)) - declare prediction and set hitchance blah blah, then cast??
            Console.WriteLine("Spell Casting Module Executing with a priority of: " + GetPriority());
        }

        public ModulePriority GetPriority()
        {
            return ModulePriority.VeryLow;
        }

        public ModuleType GetModuleType()
        {
            return ModuleType.OnUpdate;
        }
    }
}