using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Hiteshsondhi88.Libffmpeg {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='ResponseHandler']"
	[Register ("com/github/hiteshsondhi88/libffmpeg/ResponseHandler", "", "Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandlerInvoker")]
	public partial interface IResponseHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='ResponseHandler']/method[@name='onFinish' and count(parameter)=0]"
		[Register ("onFinish", "()V", "GetOnFinishHandler:Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandlerInvoker, ffmpegAndroidJava")]
		void OnFinish ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='ResponseHandler']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler:Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandlerInvoker, ffmpegAndroidJava")]
		void OnStart ();

	}

	[global::Android.Runtime.Register ("com/github/hiteshsondhi88/libffmpeg/ResponseHandler", DoNotGenerateAcw=true)]
	internal class IResponseHandlerInvoker : global::Java.Lang.Object, IResponseHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/github/hiteshsondhi88/libffmpeg/ResponseHandler");
		IntPtr class_ref;

		public static IResponseHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponseHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.hiteshsondhi88.libffmpeg.ResponseHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResponseHandlerInvoker); }
		}

		static Delegate cb_onFinish;
#pragma warning disable 0169
		static Delegate GetOnFinishHandler ()
		{
			if (cb_onFinish == null)
				cb_onFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinish);
			return cb_onFinish;
		}

		static void n_OnFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinish ();
		}
#pragma warning restore 0169

		IntPtr id_onFinish;
		public unsafe void OnFinish ()
		{
			if (id_onFinish == IntPtr.Zero)
				id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onFinish);
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		IntPtr id_onStart;
		public unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onStart);
		}

	}

}
