//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide.junit {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ScreenShooter : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_to0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_failedTests1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_succeededTests2;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_captureSuccessfulTests3;
        
        protected ScreenShooter(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.junit.ScreenShooter.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Z")]
        public virtual bool captureSuccessfulTests {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((bool)(@__env.GetBooleanField(this, global::com.codeborne.selenide.junit.ScreenShooter.j4n_captureSuccessfulTests3)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.junit.ScreenShooter.staticClass = @__class;
            global::com.codeborne.selenide.junit.ScreenShooter.j4n_to0 = @__env.GetMethodID(global::com.codeborne.selenide.junit.ScreenShooter.staticClass, "to", "(Ljava/lang/String;)Lcom/codeborne/selenide/junit/ScreenShooter;");
            global::com.codeborne.selenide.junit.ScreenShooter.j4n_failedTests1 = @__env.GetStaticMethodID(global::com.codeborne.selenide.junit.ScreenShooter.staticClass, "failedTests", "()Lcom/codeborne/selenide/junit/ScreenShooter;");
            global::com.codeborne.selenide.junit.ScreenShooter.j4n_succeededTests2 = @__env.GetMethodID(global::com.codeborne.selenide.junit.ScreenShooter.staticClass, "succeededTests", "()Lcom/codeborne/selenide/junit/ScreenShooter;");
            global::com.codeborne.selenide.junit.ScreenShooter.j4n_captureSuccessfulTests3 = @__env.GetFieldID(global::com.codeborne.selenide.junit.ScreenShooter.staticClass, "captureSuccessfulTests", "Z");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Lcom/codeborne/selenide/junit/ScreenShooter;")]
        public virtual global::com.codeborne.selenide.junit.ScreenShooter to(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.junit.ScreenShooter>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.junit.ScreenShooter.j4n_to0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lcom/codeborne/selenide/junit/ScreenShooter;")]
        public static global::com.codeborne.selenide.junit.ScreenShooter failedTests() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.junit.ScreenShooter>(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.junit.ScreenShooter.staticClass, global::com.codeborne.selenide.junit.ScreenShooter.j4n_failedTests1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lcom/codeborne/selenide/junit/ScreenShooter;")]
        public virtual global::com.codeborne.selenide.junit.ScreenShooter succeededTests() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.junit.ScreenShooter>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.junit.ScreenShooter.j4n_succeededTests2));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.junit.ScreenShooter(@__env);
            }
        }
    }
    #endregion
}