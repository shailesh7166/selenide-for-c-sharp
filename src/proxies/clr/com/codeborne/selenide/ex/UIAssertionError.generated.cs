//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide.ex {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    [global::System.SerializableAttribute()]
    public partial class UIAssertionError : global::java.lang.Error {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_wrap0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getScreenshot1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getJsErrors2;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_timeoutMs3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorUIAssertionError4;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)V")]
        public UIAssertionError(global::java.lang.Throwable par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::com.codeborne.selenide.ex.UIAssertionError.staticClass, global::com.codeborne.selenide.ex.UIAssertionError.j4n__ctorUIAssertionError4, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0));
            }
        }
        
        protected UIAssertionError(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected UIAssertionError(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.ex.UIAssertionError.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("J")]
        public virtual long timeoutMs {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((long)(@__env.GetLongField(this, global::com.codeborne.selenide.ex.UIAssertionError.j4n_timeoutMs3)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.ex.UIAssertionError.staticClass = @__class;
            global::com.codeborne.selenide.ex.UIAssertionError.j4n_wrap0 = @__env.GetStaticMethodID(global::com.codeborne.selenide.ex.UIAssertionError.staticClass, "wrap", "(Ljava/lang/Error;J)Ljava/lang/Error;");
            global::com.codeborne.selenide.ex.UIAssertionError.j4n_getScreenshot1 = @__env.GetMethodID(global::com.codeborne.selenide.ex.UIAssertionError.staticClass, "getScreenshot", "()Ljava/lang/String;");
            global::com.codeborne.selenide.ex.UIAssertionError.j4n_getJsErrors2 = @__env.GetMethodID(global::com.codeborne.selenide.ex.UIAssertionError.staticClass, "getJsErrors", "()Ljava/util/List;");
            global::com.codeborne.selenide.ex.UIAssertionError.j4n_timeoutMs3 = @__env.GetFieldID(global::com.codeborne.selenide.ex.UIAssertionError.staticClass, "timeoutMs", "J");
            global::com.codeborne.selenide.ex.UIAssertionError.j4n__ctorUIAssertionError4 = @__env.GetMethodID(global::com.codeborne.selenide.ex.UIAssertionError.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Error;J)Ljava/lang/Error;")]
        public static global::java.lang.Error wrap(global::java.lang.Error par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Error>(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.ex.UIAssertionError.staticClass, global::com.codeborne.selenide.ex.UIAssertionError.j4n_wrap0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getScreenshot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.ex.UIAssertionError.j4n_getScreenshot1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/List;")]
        public virtual global::java.util.List getJsErrors() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.ex.UIAssertionError.j4n_getJsErrors2));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.ex.UIAssertionError(@__env);
            }
        }
    }
    #endregion
}
