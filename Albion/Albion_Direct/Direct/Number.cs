////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.362.118917-prod
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
    /* Internal type: sm */
    public partial struct Number
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private sm _internal;
        
        #region Properties
        
        public sm Number_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public static Number FromDouble(System.Double A_0) => sm.e((System.Double)A_0);
        public static Number FromInt64(long A_0) => sm.f((long)A_0);
        public static Number FromRaw(long A_0) => sm.e((long)A_0);
        public long GetFractionalPart() => _internal.i();
        public System.Double GetFractions() => _internal.j();
        public long GetIntegerPart() => _internal.h();
        public System.Double ToDouble() => _internal.k();
        //public static bool TryParse(string A_0, out Number A_1) => sm.f((string)A_0, out A_1);
        //public static bool TryParseRaw(string A_0, out Number A_1) => sm.e((string)A_0, out A_1);
        
        #endregion
        
        #region Constructor
        
        public Number(sm instance)
        {
            _internal = instance;
        }
        
        static Number()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator sm(Number instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Number(sm instance)
        {
            return new Number(instance);
        }
        #endregion
    }
}
