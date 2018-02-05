////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.351.109781-prod
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
    /* Internal type: anp.TerritoryType */
    public enum TerritoryType
    {
        NORMAL = 0,
        CASTLE = 1,
        CITY = 2,
        WATCHTOWER = 3,
        SIEGECAMP = 4
    }
    
    public static class TerritoryTypeExtensions
    {
        public static anp.TerritoryType ToInternal(this TerritoryType instance)
        {
            return (anp.TerritoryType)instance;
        }
        
        public static TerritoryType ToWrapped(this anp.TerritoryType instance)
        {
            return (TerritoryType)instance;
        }
    }
}
