//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Pocketsphinx {

public class JsgfIterator : global::System.Collections.IEnumerator {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JsgfIterator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JsgfIterator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JsgfIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SphinxBasePINVOKE.delete_JsgfIterator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public object Current 
  {
     get
     {
       return GetCurrent();
     }
  }

  public JsgfIterator(SWIGTYPE_p_void ptr) : this(SphinxBasePINVOKE.new_JsgfIterator(SWIGTYPE_p_void.getCPtr(ptr)), true) {
  }

  public bool MoveNext() {
    bool ret = SphinxBasePINVOKE.JsgfIterator_MoveNext(swigCPtr);
    return ret;
  }

  public void Reset() {
    SphinxBasePINVOKE.JsgfIterator_Reset(swigCPtr);
  }

  public JsgfRule GetCurrent() {
    global::System.IntPtr cPtr = SphinxBasePINVOKE.JsgfIterator_GetCurrent(swigCPtr);
    JsgfRule ret = (cPtr == global::System.IntPtr.Zero) ? null : new JsgfRule(cPtr, false);
    return ret;
  }

}

}
