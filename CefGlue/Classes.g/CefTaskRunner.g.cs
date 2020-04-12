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
    public sealed unsafe partial class CefTaskRunner : IDisposable
    {
        internal static CefTaskRunner FromNative(cef_task_runner_t* ptr)
        {
            return new CefTaskRunner(ptr);
        }
        
        internal static CefTaskRunner FromNativeOrNull(cef_task_runner_t* ptr)
        {
            if (ptr == null) return null;
            return new CefTaskRunner(ptr);
        }
        
        private cef_task_runner_t* _self;
        
        private CefTaskRunner(cef_task_runner_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            CefObjectTracker.Track(this);
        }
        
        ~CefTaskRunner()
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
            cef_task_runner_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_task_runner_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_task_runner_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_task_runner_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_task_runner_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
