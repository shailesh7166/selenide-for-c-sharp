//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide.impl {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class FileDownloader : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_download0;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_instance1;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_ignoreSelfSignedCerts2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorFileDownloader3;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public FileDownloader() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::com.codeborne.selenide.impl.FileDownloader.staticClass, global::com.codeborne.selenide.impl.FileDownloader.j4n__ctorFileDownloader3, this);
            }
        }
        
        protected FileDownloader(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.FileDownloader.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/impl/FileDownloader;")]
        public static global::com.codeborne.selenide.impl.FileDownloader instance {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.impl.FileDownloader>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.impl.FileDownloader.staticClass, global::com.codeborne.selenide.impl.FileDownloader.j4n_instance1));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Z")]
        public static bool ignoreSelfSignedCerts {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((bool)(@__env.GetStaticBooleanField(global::com.codeborne.selenide.impl.FileDownloader.staticClass, global::com.codeborne.selenide.impl.FileDownloader.j4n_ignoreSelfSignedCerts2)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.FileDownloader.staticClass = @__class;
            global::com.codeborne.selenide.impl.FileDownloader.j4n_download0 = @__env.GetMethodID(global::com.codeborne.selenide.impl.FileDownloader.staticClass, "download", "(Lorg/openqa/selenium/WebElement;)Ljava/io/File;");
            global::com.codeborne.selenide.impl.FileDownloader.j4n_instance1 = @__env.GetStaticFieldID(global::com.codeborne.selenide.impl.FileDownloader.staticClass, "instance", "Lcom/codeborne/selenide/impl/FileDownloader;");
            global::com.codeborne.selenide.impl.FileDownloader.j4n_ignoreSelfSignedCerts2 = @__env.GetStaticFieldID(global::com.codeborne.selenide.impl.FileDownloader.staticClass, "ignoreSelfSignedCerts", "Z");
            global::com.codeborne.selenide.impl.FileDownloader.j4n__ctorFileDownloader3 = @__env.GetMethodID(global::com.codeborne.selenide.impl.FileDownloader.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/openqa/selenium/WebElement;)Ljava/io/File;")]
        public virtual global::java.io.File download(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.FileDownloader.j4n_download0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.FileDownloader(@__env);
            }
        }
    }
    #endregion
}
