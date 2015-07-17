using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Hiteshsondhi88.Libffmpeg {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='FFmpegExecuteResponseHandler']"
	[Register ("com/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler", "", "Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandlerInvoker")]
	public partial interface IFFmpegExecuteResponseHandler : global::Com.Github.Hiteshsondhi88.Libffmpeg.IResponseHandler {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='FFmpegExecuteResponseHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Handler:Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandlerInvoker, ffmpegAndroidJava")]
		void OnFailure (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='FFmpegExecuteResponseHandler']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProgress", "(Ljava/lang/String;)V", "GetOnProgress_Ljava_lang_String_Handler:Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandlerInvoker, ffmpegAndroidJava")]
		void OnProgress (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/interface[@name='FFmpegExecuteResponseHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandlerInvoker, ffmpegAndroidJava")]
		void OnSuccess (string p0);

	}

	[global::Android.Runtime.Register ("com/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler", DoNotGenerateAcw=true)]
	internal class IFFmpegExecuteResponseHandlerInvoker : global::Java.Lang.Object, IFFmpegExecuteResponseHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler");
		IntPtr class_ref;

		public static IFFmpegExecuteResponseHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFFmpegExecuteResponseHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.hiteshsondhi88.libffmpeg.FFmpegExecuteResponseHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFFmpegExecuteResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFFmpegExecuteResponseHandlerInvoker); }
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_String_;
		public unsafe void OnFailure (string p0)
		{
			if (id_onFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onFailure_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_Ljava_lang_String_;
		public unsafe void OnProgress (string p0)
		{
			if (id_onProgress_Ljava_lang_String_ == IntPtr.Zero)
				id_onProgress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProgress", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onProgress_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_;
		public unsafe void OnSuccess (string p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
