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
    /* Internal type: ai6 */
    public partial struct ActionPoint
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ai6 _internal;
        
        #region Properties
        
        public ai6 ActionPoint_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ActionPoint(ai6 instance)
        {
            _internal = instance;
        }
        
        static ActionPoint()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ai6(ActionPoint instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ActionPoint(ai6 instance)
        {
            return new ActionPoint(instance);
        }
        #endregion
    }
}
