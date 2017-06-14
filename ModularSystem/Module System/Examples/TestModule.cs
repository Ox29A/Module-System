using System;
using ModularSystem.Module_System.Enumerations;

namespace ModularSystem.Module_System.Examples
{
    class TestModule : IModule
    {
        public string GetName()
        {
            return "Test Module 1";
        }

        public string GetDescription()
        {
            return "Dummy Description 1";
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
            Console.WriteLine("Module 1 is executing with priority of: "+GetPriority());
        }

        public ModulePriority GetPriority()
        {
            return ModulePriority.VeryHigh;
        }

        public ModuleType GetModuleType()
        {
            return ModuleType.OnUpdate;
        }
    }
}
