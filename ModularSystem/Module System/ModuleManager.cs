using System;
using System.Collections.Generic;
using System.Linq;
using ModularSystem.Module_System.Enumerations;
using ModularSystem.Module_System.Examples;
using ModularSystem.Module_System.Examples.Spell_Casting;

namespace ModularSystem.Module_System
{
    internal class ModuleManager
    {
        private readonly IOrderedEnumerable<IModule> _moduleList =
            new List<IModule> {new CastSpell(), new TestModule(), new TestModule2(), new TestModule3()}
                .OrderByDescending(x => x.GetPriority());

        public void OnLoad()
        {
            foreach (var module in _moduleList)
                module.OnLoad();

            OnUpdate(); // Game.OnUpdate += OnUpdate
        }

        private void OnUpdate()
        {
            foreach (var module in _moduleList.Where(x => x.CanExecute() && x.GetModuleType().HasFlag(ModuleType.OnUpdate)))
            {
                module.Execute();
            }
        }

        public static void Main(string[] args)
        {
            var manager = new ModuleManager();

            manager.OnLoad();

            Console.ReadLine();
        }
    }
}