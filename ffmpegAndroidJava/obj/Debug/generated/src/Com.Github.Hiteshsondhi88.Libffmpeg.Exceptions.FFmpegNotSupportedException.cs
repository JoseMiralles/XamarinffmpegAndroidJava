using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Hiteshsondhi88.Libffmpeg.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg.exceptions']/class[@name='FFmpegNotSupportedException']"
	[global::Android.Runtime.Register ("com/github/hiteshsondhi88/libffmpeg/exceptions/FFmpegNotSupportedException", DoNotGenerateAcw=true)]
	public partial class FFmpegNotSupportedException : global::Java.Lang.Exception {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/hiteshsondhi88/libffmpeg/exceptions/FFmpegNotSupportedException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FFmpegNotSupportedException); }
		}

		protected FFmpegNotSupportedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.hiteshsondhi88.libffmpeg.exceptions']/class[@name='FFmpegNotSupportedException']/constructor[@name='FFmpegNotSupportedException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe FFmpegNotSupportedException (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (FFmpegNotSupportedException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
