////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.115208-prod
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
    /* Internal type: bfg */
    public partial class GameManager
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private bfg _internal;
        
        #region Properties
        
        public bfg GameManager_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public static GameManager GetInstance() => bfg.t();
        public LandscapeManager GetLandscapeManager() => _internal.aa();
        public LocalPlayerCharacterView GetLocalPlayerCharacterView() => _internal.w();
        public GameState GetState() => _internal.x().ToWrapped();
        public SimulationObjectView GetView(SimulationObject A_0) => _internal.a((axk)A_0);
        public SimulationObjectView GetView(long A_0) => _internal.a((long)A_0);
        
        #endregion
        
        #region Constructor
        
        public GameManager(bfg instance)
        {
            _internal = instance;
        }
        
        static GameManager()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator bfg(GameManager instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GameManager(bfg instance)
        {
            return new GameManager(instance);
        }
        
        public static implicit operator bool(GameManager instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
