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
    public partial class Cleanup : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_wrap0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isInvalidSelectorError1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_webdriverExceptionMessage2;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_of3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorCleanup4;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Cleanup() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::com.codeborne.selenide.impl.Cleanup.staticClass, global::com.codeborne.selenide.impl.Cleanup.j4n__ctorCleanup4, this);
            }
        }
        
        protected Cleanup(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.Cleanup.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/impl/Cleanup;")]
        public static global::com.codeborne.selenide.impl.Cleanup of {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.impl.Cleanup>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.impl.Cleanup.staticClass, global::com.codeborne.selenide.impl.Cleanup.j4n_of3));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.Cleanup.staticClass = @__class;
            global::com.codeborne.selenide.impl.Cleanup.j4n_wrap0 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Cleanup.staticClass, "wrap", "(Ljava/lang/Throwable;)Lorg/openqa/selenium/InvalidSelectorException;");
            global::com.codeborne.selenide.impl.Cleanup.j4n_isInvalidSelectorError1 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Cleanup.staticClass, "isInvalidSelectorError", "(Ljava/lang/Throwable;)Z");
            global::com.codeborne.selenide.impl.Cleanup.j4n_webdriverExceptionMessage2 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Cleanup.staticClass, "webdriverExceptionMessage", "(Ljava/lang/Throwable;)Ljava/lang/String;");
            global::com.codeborne.selenide.impl.Cleanup.j4n_of3 = @__env.GetStaticFieldID(global::com.codeborne.selenide.impl.Cleanup.staticClass, "of", "Lcom/codeborne/selenide/impl/Cleanup;");
            global::com.codeborne.selenide.impl.Cleanup.j4n__ctorCleanup4 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Cleanup.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)Lorg/openqa/selenium/InvalidSelectorException;")]
        public virtual global::java.lang.RuntimeException wrap(global::java.lang.Throwable par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.RuntimeException>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.Cleanup.j4n_wrap0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)Z")]
        public virtual bool isInvalidSelectorError(global::java.lang.Throwable par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.impl.Cleanup.j4n_isInvalidSelectorError1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)Ljava/lang/String;")]
        public virtual global::java.lang.String webdriverExceptionMessage(global::java.lang.Throwable par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.Cleanup.j4n_webdriverExceptionMessage2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.Cleanup(@__env);
            }
        }
    }
    #endregion
}
