using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Hiteshsondhi88.Libffmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='LoadBinaryResponseHandler']"
	[global::Android.Runtime.Register ("com/github/hiteshsondhi88/libffmpeg/LoadBinaryResponseHandler", DoNotGenerateAcw=true)]
	public partial class LoadBinaryResponseHandler : global::Java.Lang.Object, global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/hiteshsondhi88/libffmpeg/LoadBinaryResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoadBinaryResponseHandler); }
		}

		protected LoadBinaryResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='LoadBinaryResponseHandler']/constructor[@name='LoadBinaryResponseHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoadBinaryResponseHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LoadBinaryResponseHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.LoadBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.LoadBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure ();
		}
#pragma warning restore 0169

		static IntPtr id_onFailure;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='LoadBinaryResponseHandler']/method[@name='onFailure' and count(parameter)=0]"
		[Register ("onFailure", "()V", "GetOnFailureHandler")]
		public virtual unsafe void OnFailure ()
		{
			if (id_onFailure == IntPtr.Zero)
				id_onFailure = JNIEnv.GetMethodID (class_ref, "onFailure", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFailure);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "()V"));
			} finally {
			}
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.LoadBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.LoadBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinish ();
		}
#pragma warning restore 0169

		static IntPtr id_onFinish;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='LoadBinaryResponseHandler']/method[@name='onFinish' and count(parameter)=0]"
		[Register ("onFinish", "()V", "GetOnFinishHandler")]
		public virtual unsafe void OnFinish ()
		{
			if (id_onFinish == IntPtr.Zero)
				id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFinish);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFinish", "()V"));
			} finally {
			}
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.LoadBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.LoadBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='LoadBinaryResponseHandler']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStart);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
			} finally {
			}
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.LoadBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.LoadBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='LoadBinaryResponseHandler']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler")]
		public virtual unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSuccess);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "()V"));
			} finally {
			}
		}

	}
}
