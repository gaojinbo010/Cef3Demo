//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Cef3.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefFrame : IDisposable
    {
        internal static CefFrame FromNative(cef_frame_t* ptr)
        {
            return new CefFrame(ptr);
        }
        
        internal static CefFrame FromNativeOrNull(cef_frame_t* ptr)
        {
            if (ptr == null) return null;
            return new CefFrame(ptr);
        }
        
        private cef_frame_t* _self;
        
        private CefFrame(cef_frame_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefFrame()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal int AddRef()
        {
            return cef_frame_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_frame_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_frame_t.get_refct(_self); }
        }
        
        internal cef_frame_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}