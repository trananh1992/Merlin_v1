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
    /* Internal type: agw */
    public partial class GameDataFile : DataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private agw _internal;
        
        #region Properties
        
        public agw GameDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GameDataFile(agw instance) : base(instance)
        {
            _internal = instance;
        }
        
        static GameDataFile()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator agw(GameDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GameDataFile(agw instance)
        {
            return new GameDataFile(instance);
        }
        
        public static implicit operator bool(GameDataFile instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
