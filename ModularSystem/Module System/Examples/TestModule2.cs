using System;
using ModularSystem.Module_System.Enumerations;

namespace ModularSystem.Module_System.Examples
{
    class TestModule2 : IModule
    {
        public string GetName()
        {
            return "Test Module 2 Low";
        }

        public string GetDescription()
        {
            return "Dummy Description 2";
        }

        public void OnLoad()
        {
            
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute()
        {
            Console.WriteLine("Module 2 is executing with priority of: " + GetPriority());
        }

        public ModulePriority GetPriority()
        {
            return ModulePriority.Low;
        }

        public ModuleType GetModuleType()
        {
            return ModuleType.OnUpdate;
        }

    }
}
