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
    /* Internal type: j2 */
    public partial class ClusterXmlOperator
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private j2 _internal;
        
        #region Properties
        
        public j2 ClusterXmlOperator_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ClusterXmlOperator(j2 instance)
        {
            _internal = instance;
        }
        
        static ClusterXmlOperator()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator j2(ClusterXmlOperator instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ClusterXmlOperator(j2 instance)
        {
            return new ClusterXmlOperator(instance);
        }
        
        public static implicit operator bool(ClusterXmlOperator instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
