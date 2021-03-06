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
    /* Internal type: aq4 */
    public partial class ObjectManager
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aq4 _internal;
        
        #region Properties
        
        public aq4 ObjectManager_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ItemProxy CreateItemProxy(ItemObject A_0) => _internal.a((ax0)A_0);
        public CollisionManager GetCollisionManager() => _internal.y();
        public ClusterDescriptor GetCurrentCluster() => _internal.w();
        public static ObjectManager GetInstance() => aq4.a();
        public ItemProxy GetItemProxy(long A_0) => _internal.v((long)A_0);
        public LocalPlayerCharacter GetLocalPlayerCharacter() => _internal.ac();
        public SimulationObject GetObject(long A_0) => _internal.a((long)A_0);
        public Dictionary<long,axz> GetObjectMap() => (Dictionary<long,axz>)_methodReflectionPool[0].Invoke(_internal,new object[]{});
        public IEnumerable GetObjects() => _internal.ab();
        public ICollection<SimulationObject> GetObjects<a>() where a:axz => (ICollection<SimulationObject>)_internal.ao<a>();
        public PlayerCharacter GetPlayerCharacter(Guid A_0) => _internal.a((Guid)A_0);
        
        #endregion
        
        #region Constructor
        
        public ObjectManager(aq4 instance)
        {
            _internal = instance;
        }
        
        static ObjectManager()
        {
            _methodReflectionPool.Add(typeof(aq4).GetMethod("am", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, new Type[]{}, null));
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aq4(ObjectManager instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ObjectManager(aq4 instance)
        {
            return new ObjectManager(instance);
        }
        
        public static implicit operator bool(ObjectManager instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
