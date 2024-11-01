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

public class NGramModel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NGramModel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NGramModel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NGramModel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SphinxBasePINVOKE.delete_NGramModel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static NGramModel FromIter(SWIGTYPE_p_void itor) {
    global::System.IntPtr cPtr = SphinxBasePINVOKE.NGramModel_FromIter(SWIGTYPE_p_void.getCPtr(itor));
    NGramModel ret = (cPtr == global::System.IntPtr.Zero) ? null : new NGramModel(cPtr, false);
    return ret;
  }

  public NGramModel(string path) : this(SphinxBasePINVOKE.new_NGramModel__SWIG_0(path), true) {
  }

  public NGramModel(Config config, LogMath logmath, string path) : this(SphinxBasePINVOKE.new_NGramModel__SWIG_1(Config.getCPtr(config), LogMath.getCPtr(logmath), path), true) {
  }

  public void Write(string path, int ftype) {
    SphinxBasePINVOKE.NGramModel_Write(swigCPtr, path, ftype);
  }

  public int StrToType(string str) {
    int ret = SphinxBasePINVOKE.NGramModel_StrToType(swigCPtr, str);
    return ret;
  }

  public string TypeToStr(int type) {
    string ret = SphinxBasePINVOKE.NGramModel_TypeToStr(swigCPtr, type);
    return ret;
  }

  public void Casefold(int kase) {
    SphinxBasePINVOKE.NGramModel_Casefold(swigCPtr, kase);
  }

  public int Size() {
    int ret = SphinxBasePINVOKE.NGramModel_Size(swigCPtr);
    return ret;
  }

  public int AddWord(string word, float weight) {
    int ret = SphinxBasePINVOKE.NGramModel_AddWord(swigCPtr, word, weight);
    return ret;
  }

  public int Prob(uint n, SWIGTYPE_p_p_char ptr) {
    int ret = SphinxBasePINVOKE.NGramModel_Prob(swigCPtr, n, SWIGTYPE_p_p_char.getCPtr(ptr));
    return ret;
  }

}

}
