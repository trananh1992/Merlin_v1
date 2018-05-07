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
    /* Internal type: azp */
    public partial class MobCharacter : FightingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private azp _internal;
        
        #region Properties
        
        public azp MobCharacter_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public MobCharacterDescriptor GetMobDescriptor() => _internal.tl();
        
        #endregion
        
        #region Constructor
        
        public MobCharacter(azp instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MobCharacter()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator azp(MobCharacter instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MobCharacter(azp instance)
        {
            return new MobCharacter(instance);
        }
        
        public static implicit operator bool(MobCharacter instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
