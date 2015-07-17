using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Hiteshsondhi88.Libffmpeg {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='FFmpegLoadBinaryResponseHandler']"
	[Register ("com/github/hiteshsondhi88/libffmpeg/FFmpegLoadBinaryResponseHandler", "", "Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandlerInvoker")]
	public partial interface IFFmpegLoadBinaryResponseHandler : global::Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandler {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='FFmpegLoadBinaryResponseHandler']/method[@name='onFailure' and count(parameter)=0]"
		[Register ("onFailure", "()V", "GetOnFailureHandler:Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandlerInvoker, ffmpegAndroidJava")]
		void OnFailure ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='FFmpegLoadBinaryResponseHandler']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandlerInvoker, ffmpegAndroidJava")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/github/hiteshsondhi88/libffmpeg/FFmpegLoadBinaryResponseHandler", DoNotGenerateAcw=true)]
	internal class IFFmpegLoadBinaryResponseHandlerInvoker : global::Java.Lang.Object, IFFmpegLoadBinaryResponseHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/github/hiteshsondhi88/libffmpeg/FFmpegLoadBinaryResponseHandler");
		IntPtr class_ref;

		public static IFFmpegLoadBinaryResponseHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFFmpegLoadBinaryResponseHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.hiteshsondhi88.libffmpeg.FFmpegLoadBinaryResponseHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFFmpegLoadBinaryResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFFmpegLoadBinaryResponseHandlerInvoker); }
		}

		static Delegate cb_onFailure;
#pragma warning disable 0169
		static Delegate GetOnFailureHandler ()
		{
			if (cb_onFailure == null)
				cb_onFailure = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFailure);
			return cb_onFailure;
		}

		static void n_OnFailure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure ();
		}
#pragma warning restore 0169

		IntPtr id_onFailure;
		public unsafe void OnFailure ()
		{
			if (id_onFailure == IntPtr.Zero)
				id_onFailure = JNIEnv.GetMethodID (class_ref, "onFailure", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onFailure);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onSuccess);
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
