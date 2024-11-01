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

public class FrontEnd : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FrontEnd(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FrontEnd obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FrontEnd() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SphinxBasePINVOKE.delete_FrontEnd(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FrontEnd() : this(SphinxBasePINVOKE.new_FrontEnd(), true) {
  }

  public int OutputSize() {
    int ret = SphinxBasePINVOKE.FrontEnd_OutputSize(swigCPtr);
    return ret;
  }

  public int ProcessUtt(string spch, uint nsamps, SWIGTYPE_p_p_p_mfcc_t cep_block) {
    int ret = SphinxBasePINVOKE.FrontEnd_ProcessUtt(swigCPtr, spch, nsamps, SWIGTYPE_p_p_p_mfcc_t.getCPtr(cep_block));
    return ret;
  }

}

}
