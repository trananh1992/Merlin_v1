////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.115208-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Albion_Direct
{
    /* Internal type: ka.PvpRules */
    public enum PvpRules
    {
        PvpDisabled = 0,
        PvpAllowed = 1,
        PvpForced = 2
    }
    
    public static class PvpRulesExtensions
    {
        public static ka.PvpRules ToInternal(this PvpRules instance)
        {
            return (ka.PvpRules)instance;
        }
        
        public static PvpRules ToWrapped(this ka.PvpRules instance)
        {
            return (PvpRules)instance;
        }
    }
}
