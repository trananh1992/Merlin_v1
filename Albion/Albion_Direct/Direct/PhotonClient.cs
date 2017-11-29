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
    /* Internal type: as7 */
    public partial class PhotonClient
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private as7 _internal;
        
        #region Properties
        
        public as7 PhotonClient_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public GameData GetGameData() => _internal.an();
        public ap8 GetGamePeer() => _internal.ap();
        public ap7 GetChatPeer() => _internal.ar();
        public static PhotonClient GetInstance() => as7.aj();
        public ap9 GetLoginPeer() => _internal.aq();
        
        #endregion
        
        #region Constructor
        
        public PhotonClient(as7 instance)
        {
            _internal = instance;
        }
        
        static PhotonClient()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator as7(PhotonClient instance)
        {
            return instance._internal;
        }
        
        public static implicit operator PhotonClient(as7 instance)
        {
            return new PhotonClient(instance);
        }
        
        public static implicit operator bool(PhotonClient instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
