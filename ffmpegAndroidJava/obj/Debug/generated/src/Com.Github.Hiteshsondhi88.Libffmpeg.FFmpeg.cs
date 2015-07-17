using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Hiteshsondhi88.Libffmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']"
	[global::Android.Runtime.Register ("com/github/hiteshsondhi88/libffmpeg/FFmpeg", DoNotGenerateAcw=true)]
	public partial class FFmpeg : global::Java.Lang.Object, global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegInterface {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/hiteshsondhi88/libffmpeg/FFmpeg", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FFmpeg); }
		}

		protected FFmpeg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDeviceFFmpegVersion;
#pragma warning disable 0169
		static Delegate GetGetDeviceFFmpegVersionHandler ()
		{
			if (cb_getDeviceFFmpegVersion == null)
				cb_getDeviceFFmpegVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceFFmpegVersion);
			return cb_getDeviceFFmpegVersion;
		}

		static IntPtr n_GetDeviceFFmpegVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceFFmpegVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceFFmpegVersion;
		public virtual unsafe string DeviceFFmpegVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='getDeviceFFmpegVersion' and count(parameter)=0]"
			[Register ("getDeviceFFmpegVersion", "()Ljava/lang/String;", "GetGetDeviceFFmpegVersionHandler")]
			get {
				if (id_getDeviceFFmpegVersion == IntPtr.Zero)
					id_getDeviceFFmpegVersion = JNIEnv.GetMethodID (class_ref, "getDeviceFFmpegVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceFFmpegVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceFFmpegVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isFFmpegCommandRunning;
#pragma warning disable 0169
		static Delegate GetIsFFmpegCommandRunningHandler ()
		{
			if (cb_isFFmpegCommandRunning == null)
				cb_isFFmpegCommandRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFFmpegCommandRunning);
			return cb_isFFmpegCommandRunning;
		}

		static bool n_IsFFmpegCommandRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFFmpegCommandRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isFFmpegCommandRunning;
		public virtual unsafe bool IsFFmpegCommandRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='isFFmpegCommandRunning' and count(parameter)=0]"
			[Register ("isFFmpegCommandRunning", "()Z", "GetIsFFmpegCommandRunningHandler")]
			get {
				if (id_isFFmpegCommandRunning == IntPtr.Zero)
					id_isFFmpegCommandRunning = JNIEnv.GetMethodID (class_ref, "isFFmpegCommandRunning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFFmpegCommandRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFFmpegCommandRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLibraryFFmpegVersion;
#pragma warning disable 0169
		static Delegate GetGetLibraryFFmpegVersionHandler ()
		{
			if (cb_getLibraryFFmpegVersion == null)
				cb_getLibraryFFmpegVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLibraryFFmpegVersion);
			return cb_getLibraryFFmpegVersion;
		}

		static IntPtr n_GetLibraryFFmpegVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LibraryFFmpegVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getLibraryFFmpegVersion;
		public virtual unsafe string LibraryFFmpegVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='getLibraryFFmpegVersion' and count(parameter)=0]"
			[Register ("getLibraryFFmpegVersion", "()Ljava/lang/String;", "GetGetLibraryFFmpegVersionHandler")]
			get {
				if (id_getLibraryFFmpegVersion == IntPtr.Zero)
					id_getLibraryFFmpegVersion = JNIEnv.GetMethodID (class_ref, "getLibraryFFmpegVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLibraryFFmpegVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLibraryFFmpegVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_Handler ()
		{
			if (cb_execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ == null)
				cb_execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_);
			return cb_execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_;
		}

		static void n_Execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler p1 = (global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler)global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Execute (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.github.hiteshsondhi88.libffmpeg.FFmpegExecuteResponseHandler']]"
		[Register ("execute", "(Ljava/lang/String;Lcom/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler;)V", "GetExecute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_Handler")]
		public virtual unsafe void Execute (string p0, global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler p1)
		{
			if (id_execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ == IntPtr.Zero)
				id_execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ = JNIEnv.GetMethodID (class_ref, "execute", "(Ljava/lang/String;Lcom/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_execute_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Ljava/lang/String;Lcom/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_Handler ()
		{
			if (cb_execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ == null)
				cb_execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_);
			return cb_execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_;
		}

		static void n_Execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler p2 = (global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler)global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Execute (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.github.hiteshsondhi88.libffmpeg.FFmpegExecuteResponseHandler']]"
		[Register ("execute", "(Ljava/util/Map;Ljava/lang/String;Lcom/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler;)V", "GetExecute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_Handler")]
		public virtual unsafe void Execute (global::System.Collections.Generic.IDictionary<string, string> p0, string p1, global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegExecuteResponseHandler p2)
		{
			if (id_execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ == IntPtr.Zero)
				id_execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_ = JNIEnv.GetMethodID (class_ref, "execute", "(Ljava/util/Map;Ljava/lang/String;Lcom/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_execute_Ljava_util_Map_Ljava_lang_String_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegExecuteResponseHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Ljava/util/Map;Ljava/lang/String;Lcom/github/hiteshsondhi88/libffmpeg/FFmpegExecuteResponseHandler;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/github/hiteshsondhi88/libffmpeg/FFmpeg;", "")]
		public static unsafe global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/github/hiteshsondhi88/libffmpeg/FFmpeg;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_killRunningProcesses;
#pragma warning disable 0169
		static Delegate GetKillRunningProcessesHandler ()
		{
			if (cb_killRunningProcesses == null)
				cb_killRunningProcesses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_KillRunningProcesses);
			return cb_killRunningProcesses;
		}

		static bool n_KillRunningProcesses (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KillRunningProcesses ();
		}
#pragma warning restore 0169

		static IntPtr id_killRunningProcesses;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='killRunningProcesses' and count(parameter)=0]"
		[Register ("killRunningProcesses", "()Z", "GetKillRunningProcessesHandler")]
		public virtual unsafe bool KillRunningProcesses ()
		{
			if (id_killRunningProcesses == IntPtr.Zero)
				id_killRunningProcesses = JNIEnv.GetMethodID (class_ref, "killRunningProcesses", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_killRunningProcesses);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "killRunningProcesses", "()Z"));
			} finally {
			}
		}

		static Delegate cb_loadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_;
#pragma warning disable 0169
		static Delegate GetLoadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_Handler ()
		{
			if (cb_loadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_ == null)
				cb_loadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_);
			return cb_loadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_;
		}

		static void n_LoadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler p0 = (global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler)global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadBinary (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='loadBinary' and count(parameter)=1 and parameter[1][@type='com.github.hiteshsondhi88.libffmpeg.FFmpegLoadBinaryResponseHandler']]"
		[Register ("loadBinary", "(Lcom/github/hiteshsondhi88/libffmpeg/FFmpegLoadBinaryResponseHandler;)V", "GetLoadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_Handler")]
		public virtual unsafe void LoadBinary (global::Com.Github.Hiteshsondhi88.Libffmpeg.IFFmpegLoadBinaryResponseHandler p0)
		{
			if (id_loadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_ == IntPtr.Zero)
				id_loadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_ = JNIEnv.GetMethodID (class_ref, "loadBinary", "(Lcom/github/hiteshsondhi88/libffmpeg/FFmpegLoadBinaryResponseHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadBinary_Lcom_github_hiteshsondhi88_libffmpeg_FFmpegLoadBinaryResponseHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadBinary", "(Lcom/github/hiteshsondhi88/libffmpeg/FFmpegLoadBinaryResponseHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTimeout_J;
#pragma warning disable 0169
		static Delegate GetSetTimeout_JHandler ()
		{
			if (cb_setTimeout_J == null)
				cb_setTimeout_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimeout_J);
			return cb_setTimeout_J;
		}

		static void n_SetTimeout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg __this = global::Java.Lang.Object.GetObject<global::Com.Github.Hiteshsondhi88.Libffmpeg.FFmpeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg']/class[@name='FFmpeg']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimeout", "(J)V", "GetSetTimeout_JHandler")]
		public virtual unsafe void SetTimeout (long p0)
		{
			if (id_setTimeout_J == IntPtr.Zero)
				id_setTimeout_J = JNIEnv.GetMethodID (class_ref, "setTimeout", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimeout_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(J)V"), __args);
			} finally {
			}
		}

	}
}
