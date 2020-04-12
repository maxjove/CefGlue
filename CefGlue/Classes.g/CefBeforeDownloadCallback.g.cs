//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefBeforeDownloadCallback : IDisposable
    {
        internal static CefBeforeDownloadCallback FromNative(cef_before_download_callback_t* ptr)
        {
            return new CefBeforeDownloadCallback(ptr);
        }
        
        internal static CefBeforeDownloadCallback FromNativeOrNull(cef_before_download_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefBeforeDownloadCallback(ptr);
        }
        
        private cef_before_download_callback_t* _self;
        
        private CefBeforeDownloadCallback(cef_before_download_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            CefObjectTracker.Track(this);
        }
        
        ~CefBeforeDownloadCallback()
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
            CefObjectTracker.Untrack(this);
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_before_download_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_before_download_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_before_download_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_before_download_callback_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_before_download_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
