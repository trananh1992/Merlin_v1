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

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: atk */
    public partial class SimpleItemObject : ItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private atk _internal;
        
        #region Properties
        
        public atk SimpleItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public SimpleItemObject(atk instance) : base(instance)
        {
            _internal = instance;
        }
        
        static SimpleItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator atk(SimpleItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimpleItemObject(atk instance)
        {
            return new SimpleItemObject(instance);
        }
        
        public static implicit operator bool(SimpleItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
