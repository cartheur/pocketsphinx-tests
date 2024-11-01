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

public class Hypothesis : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Hypothesis(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Hypothesis obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Hypothesis() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PocketSphinxPINVOKE.delete_Hypothesis(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string Hypstr {
    set {
      PocketSphinxPINVOKE.Hypothesis_Hypstr_set(swigCPtr, value);
    } 
    get {
      string ret = PocketSphinxPINVOKE.Hypothesis_Hypstr_get(swigCPtr);
      return ret;
    } 
  }

  public int BestScore {
    set {
      PocketSphinxPINVOKE.Hypothesis_BestScore_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.Hypothesis_BestScore_get(swigCPtr);
      return ret;
    } 
  }

  public int Prob {
    set {
      PocketSphinxPINVOKE.Hypothesis_Prob_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.Hypothesis_Prob_get(swigCPtr);
      return ret;
    } 
  }

  public Hypothesis(string hypstr, int best_score, int prob) : this(PocketSphinxPINVOKE.new_Hypothesis(hypstr, best_score, prob), true) {
  }

}

}
