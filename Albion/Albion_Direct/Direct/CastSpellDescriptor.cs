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
    /* Internal type: b7 */
    public partial class CastSpellDescriptor : ActiveSpellDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private b7 _internal;
        
        #region Properties
        
        public b7 CastSpellDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public CastSpellDescriptor(b7 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static CastSpellDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator b7(CastSpellDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator CastSpellDescriptor(b7 instance)
        {
            return new CastSpellDescriptor(instance);
        }
        
        public static implicit operator bool(CastSpellDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
