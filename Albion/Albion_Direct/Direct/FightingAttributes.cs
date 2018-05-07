////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.362.117031-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: ahf */
    public partial class FightingAttributes
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ahf _internal;
        
        #region Properties
        
        public ahf FightingAttributes_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetEnergyRegen() => _internal.be();
        public float GetHealthRegen() => _internal.bc();
        public float GetMaxCraftingFocus() => _internal.cw();
        public float GetMaxCraftingRegeneration() => _internal.cx();
        public float GetMaxEnergy() => _internal.bd();
        public float GetMaxHealth() => _internal.bb();
        public float GetMaxLoad() => _internal.bg();
        public float GetMoveSpeed() => _internal.bf();
        
        #endregion
        
        #region Constructor
        
        public FightingAttributes(ahf instance)
        {
            _internal = instance;
        }
        
        static FightingAttributes()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ahf(FightingAttributes instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FightingAttributes(ahf instance)
        {
            return new FightingAttributes(instance);
        }
        
        public static implicit operator bool(FightingAttributes instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
