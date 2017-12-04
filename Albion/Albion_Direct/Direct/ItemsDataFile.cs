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
    /* Internal type: aem */
    public partial class ItemsDataFile : DataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aem _internal;
        
        #region Properties
        
        public aem ItemsDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ItemsDataFile(aem instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ItemsDataFile()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aem(ItemsDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ItemsDataFile(aem instance)
        {
            return new ItemsDataFile(instance);
        }
        
        public static implicit operator bool(ItemsDataFile instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}