////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
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

namespace Albion_Direct
{
    /* Internal type: amz */
    public partial class ObjectManager
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private amz _internal;
        
        #region Properties
        
        public amz ObjectManager_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ItemProxy CreateItemProxy(ItemObject A_0) => _internal.a((atj)A_0);
        public CollisionManager GetCollisionManager() => _internal.x();
        public ClusterDescriptor GetCurrentCluster() => _internal.v();
        public static ObjectManager GetInstance() => amz.a();
        public ItemProxy GetItemProxy(long A_0) => _internal.u((long)A_0);
        public LocalPlayerCharacter GetLocalPlayerCharacter() => _internal.ab();
        public SimulationObject GetObject(long A_0) => _internal.a((long)A_0);
        public Dictionary<long, ati> GetObjectMap() => (Dictionary<long, ati>)_methodReflectionPool[0].Invoke(_internal,new object[]{});
        public IEnumerable GetObjects() => _internal.aa();
        public ICollection<SimulationObject> GetObjects<a>() where a: ati => (ICollection<SimulationObject>)_internal.am<a>();
        public PlayerCharacter GetPlayerCharacter(Guid A_0) => _internal.a((Guid)A_0);
        
        #endregion
        
        #region Constructor
        
        public ObjectManager(amz instance)
        {
            _internal = instance;
        }
        
        static ObjectManager()
        {
            _methodReflectionPool.Add(typeof(amz).GetMethod("ak", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, new Type[]{}, null));
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator amz(ObjectManager instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ObjectManager(amz instance)
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