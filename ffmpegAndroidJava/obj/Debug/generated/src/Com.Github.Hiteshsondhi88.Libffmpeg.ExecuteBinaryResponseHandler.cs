using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Hiteshsondhi88.Libffmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='ExecuteBinaryResponseHandler']"
	[global::Android.Runtime.Register ("com/github/hiteshsondhi88/libffmpeg/ExecuteBinaryResponseHandler", DoNotGenerateAcw=true)]
	public partial class ExecuteBinaryResponseHandler : global::Java.Lang.Object, global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/hiteshsondhi88/libffmpeg/ExecuteBinaryResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExecuteBinaryResponseHandler); }
		}

		protected ExecuteBinaryResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='ExecuteBinaryResponseHandler']/constructor[@name='ExecuteBinaryResponseHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExecuteBinaryResponseHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ExecuteBinaryResponseHandler)) {
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

		static Delegate cb_onFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onFailure_Ljava_lang_String_ == null)
				cb_onFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_String_);
			return cb_onFailure_Ljava_lang_String_;
		}

		static void n_OnFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onFailure_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='ExecuteBinaryResponseHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Handler")]
		public virtual unsafe void OnFailure (string p0)
		{
			if (id_onFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFailure_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinish ();
		}
#pragma warning restore 0169

		static IntPtr id_onFinish;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='ExecuteBinaryResponseHandler']/method[@name='onFinish' and count(parameter)=0]"
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

		static Delegate cb_onProgress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProgress_Ljava_lang_String_Handler ()
		{
			if (cb_onProgress_Ljava_lang_String_ == null)
				cb_onProgress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProgress_Ljava_lang_String_);
			return cb_onProgress_Ljava_lang_String_;
		}

		static void n_OnProgress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProgress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='ExecuteBinaryResponseHandler']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProgress", "(Ljava/lang/String;)V", "GetOnProgress_Ljava_lang_String_Handler")]
		public virtual unsafe void OnProgress (string p0)
		{
			if (id_onProgress_Ljava_lang_String_ == IntPtr.Zero)
				id_onProgress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProgress", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onProgress_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProgress", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='ExecuteBinaryResponseHandler']/method[@name='onStart' and count(parameter)=0]"
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

		static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.ExecuteBinaryResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='ExecuteBinaryResponseHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
		public virtual unsafe void OnSuccess (string p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSuccess_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
