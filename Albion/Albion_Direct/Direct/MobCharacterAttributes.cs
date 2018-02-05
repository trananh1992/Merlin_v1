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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: afd */
    public partial class MobCharacterAttributes : FightingAttributes
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private afd _internal;
        
        #region Properties
        
        public afd MobCharacterAttributes_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public MobCharacterAttributes(afd instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MobCharacterAttributes()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator afd(MobCharacterAttributes instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MobCharacterAttributes(afd instance)
        {
            return new MobCharacterAttributes(instance);
        }
        
        public static implicit operator bool(MobCharacterAttributes instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
