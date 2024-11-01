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

public class Segment : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Segment(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Segment obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Segment() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PocketSphinxPINVOKE.delete_Segment(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

    public override string ToString() {
	return Word + " " + StartFrame + " " + EndFrame + " " + Prob;
    }

  public string Word {
    set {
      PocketSphinxPINVOKE.Segment_Word_set(swigCPtr, value);
    } 
    get {
      string ret = PocketSphinxPINVOKE.Segment_Word_get(swigCPtr);
      return ret;
    } 
  }

  public int Ascore {
    set {
      PocketSphinxPINVOKE.Segment_Ascore_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.Segment_Ascore_get(swigCPtr);
      return ret;
    } 
  }

  public int Lscore {
    set {
      PocketSphinxPINVOKE.Segment_Lscore_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.Segment_Lscore_get(swigCPtr);
      return ret;
    } 
  }

  public int Lback {
    set {
      PocketSphinxPINVOKE.Segment_Lback_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.Segment_Lback_get(swigCPtr);
      return ret;
    } 
  }

  public int Prob {
    set {
      PocketSphinxPINVOKE.Segment_Prob_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.Segment_Prob_get(swigCPtr);
      return ret;
    } 
  }

  public int StartFrame {
    set {
      PocketSphinxPINVOKE.Segment_StartFrame_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.Segment_StartFrame_get(swigCPtr);
      return ret;
    } 
  }

  public int EndFrame {
    set {
      PocketSphinxPINVOKE.Segment_EndFrame_set(swigCPtr, value);
    } 
    get {
      int ret = PocketSphinxPINVOKE.Segment_EndFrame_get(swigCPtr);
      return ret;
    } 
  }

  public static Segment FromIter(SWIGTYPE_p_void itor) {
    global::System.IntPtr cPtr = PocketSphinxPINVOKE.Segment_FromIter(SWIGTYPE_p_void.getCPtr(itor));
    Segment ret = (cPtr == global::System.IntPtr.Zero) ? null : new Segment(cPtr, false);
    return ret;
  }

  public Segment() : this(PocketSphinxPINVOKE.new_Segment(), true) {
  }

}

}
