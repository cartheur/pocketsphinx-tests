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

public class JsgfRule : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JsgfRule(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JsgfRule obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JsgfRule() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SphinxBasePINVOKE.delete_JsgfRule(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public JsgfRule() : this(SphinxBasePINVOKE.new_JsgfRule(), true) {
  }

  public static JsgfRule FromIter(SWIGTYPE_p_void itor) {
    global::System.IntPtr cPtr = SphinxBasePINVOKE.JsgfRule_FromIter(SWIGTYPE_p_void.getCPtr(itor));
    JsgfRule ret = (cPtr == global::System.IntPtr.Zero) ? null : new JsgfRule(cPtr, false);
    return ret;
  }

  public string GetName() {
    string ret = SphinxBasePINVOKE.JsgfRule_GetName(swigCPtr);
    return ret;
  }

  public bool IsPublic() {
    bool ret = SphinxBasePINVOKE.JsgfRule_IsPublic(swigCPtr);
    return ret;
  }

}

}
