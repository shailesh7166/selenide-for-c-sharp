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
    public partial class Describe : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_flush0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_shortly1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_serialize2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_selector3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_describe4;
        
        protected Describe(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.Describe.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.Describe.staticClass = @__class;
            global::com.codeborne.selenide.impl.Describe.j4n_flush0 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Describe.staticClass, "flush", "()Ljava/lang/String;");
            global::com.codeborne.selenide.impl.Describe.j4n_shortly1 = @__env.GetStaticMethodID(global::com.codeborne.selenide.impl.Describe.staticClass, "shortly", "(Lorg/openqa/selenium/WebElement;)Ljava/lang/String;");
            global::com.codeborne.selenide.impl.Describe.j4n_serialize2 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Describe.staticClass, "serialize", "()Ljava/lang/String;");
            global::com.codeborne.selenide.impl.Describe.j4n_selector3 = @__env.GetStaticMethodID(global::com.codeborne.selenide.impl.Describe.staticClass, "selector", "(Lorg/openqa/selenium/By;)Ljava/lang/String;");
            global::com.codeborne.selenide.impl.Describe.j4n_describe4 = @__env.GetStaticMethodID(global::com.codeborne.selenide.impl.Describe.staticClass, "describe", "(Lorg/openqa/selenium/WebElement;)Ljava/lang/String;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String flush() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.Describe.j4n_flush0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/openqa/selenium/WebElement;)Ljava/lang/String;")]
        public static global::java.lang.String shortly(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.impl.Describe.staticClass, global::com.codeborne.selenide.impl.Describe.j4n_shortly1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String serialize() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.Describe.j4n_serialize2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/openqa/selenium/By;)Ljava/lang/String;")]
        public static global::java.lang.String selector(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.impl.Describe.staticClass, global::com.codeborne.selenide.impl.Describe.j4n_selector3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/openqa/selenium/WebElement;)Ljava/lang/String;")]
        public static global::java.lang.String describe(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.impl.Describe.staticClass, global::com.codeborne.selenide.impl.Describe.j4n_describe4, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.Describe(@__env);
            }
        }
    }
    #endregion
}
