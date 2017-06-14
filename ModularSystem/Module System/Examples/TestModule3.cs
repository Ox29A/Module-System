using System;
using ModularSystem.Module_System.Enumerations;

namespace ModularSystem.Module_System.Examples
{
    class TestModule3 : IModule
    {
        public string GetName()
        {
            return "Test Module 3 Medium";
        }

        public string GetDescription()
        {
            return "Dummy Description 3";
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
            Console.WriteLine("Module 3 is executing with priority of: " + GetPriority());
        }

        public ModulePriority GetPriority()
        {
            return ModulePriority.Medium;
        }

        public ModuleType GetModuleType()
        {
            return ModuleType.OnUpdate;
        }
    }
}