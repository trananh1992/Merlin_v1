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
    /* Internal type: a5q */
    public partial class LootObject : StaticObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a5q _internal;
        
        #region Properties
        
        public a5q LootObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public LootObject(a5q instance) : base(instance)
        {
            _internal = instance;
        }
        
        static LootObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a5q(LootObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator LootObject(a5q instance)
        {
            return new LootObject(instance);
        }
        
        public static implicit operator bool(LootObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
