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
    /* Internal type: avk */
    public partial class JournalItemProxy : DurableItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private avk _internal;
        
        #region Properties
        
        public avk JournalItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public JournalItemProxy(avk instance) : base(instance)
        {
            _internal = instance;
        }
        
        static JournalItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator avk(JournalItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator JournalItemProxy(avk instance)
        {
            return new JournalItemProxy(instance);
        }
        
        public static implicit operator bool(JournalItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
