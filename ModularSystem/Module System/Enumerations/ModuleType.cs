using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularSystem.Module_System.Enumerations
{
    /// <summary>
    ///     An Enumeration representing the different ModuleTypes
    /// </summary>
    
    [Flags]
    internal enum ModuleType
    {
        OnUpdate = 1,
        OnPostAttack = 2,
        OnPreAttack = 4
    }
}