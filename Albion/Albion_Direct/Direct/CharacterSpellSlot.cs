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
    /* Internal type: Albion.Common.GameData.CharacterSpellSlot */
    public enum CharacterSpellSlot
    {
        Invalid = -1,
        MainHand1 = 0,
        MainHand2 = 1,
        OffHandOrMainHand3 = 2,
        Armor = 3,
        Head = 4,
        Shoes = 5,
        Potion = 6,
        Food = 7,
        ItemEntries = 8,
        Mount = 8,
        EscapeDungeon = 9,
        VisibleEntries = 9,
        ChangePvpStance = 10,
        CoupDeGrace = 11,
        TotalEntries = 12
    }
    
    public static class CharacterSpellSlotExtensions
    {
        public static Albion.Common.GameData.CharacterSpellSlot ToInternal(this CharacterSpellSlot instance)
        {
            return (Albion.Common.GameData.CharacterSpellSlot)instance;
        }
        
        public static CharacterSpellSlot ToWrapped(this Albion.Common.GameData.CharacterSpellSlot instance)
        {
            return (CharacterSpellSlot)instance;
        }
    }
}
