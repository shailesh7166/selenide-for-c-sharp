//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class SelenideTargetLocator : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_frame0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_frame1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_frame2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_parentFrame3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_activeElement4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_window5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_defaultContent6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_alert7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_innerFrame8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_window9;
        
        protected SelenideTargetLocator(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.SelenideTargetLocator.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.SelenideTargetLocator.staticClass = @__class;
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_frame0 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "frame", "(Lorg/openqa/selenium/WebElement;)Lorg/openqa/selenium/WebDriver;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_frame1 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "frame", "(Ljava/lang/String;)Lorg/openqa/selenium/WebDriver;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_frame2 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "frame", "(I)Lorg/openqa/selenium/WebDriver;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_parentFrame3 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "parentFrame", "()Lorg/openqa/selenium/WebDriver;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_activeElement4 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "activeElement", "()Lorg/openqa/selenium/WebElement;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_window5 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "window", "(Ljava/lang/String;)Lorg/openqa/selenium/WebDriver;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_defaultContent6 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "defaultContent", "()Lorg/openqa/selenium/WebDriver;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_alert7 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "alert", "()Lorg/openqa/selenium/Alert;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_innerFrame8 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "innerFrame", "([Ljava/lang/String;)Lorg/openqa/selenium/WebDriver;");
            global::com.codeborne.selenide.SelenideTargetLocator.j4n_window9 = @__env.GetMethodID(global::com.codeborne.selenide.SelenideTargetLocator.staticClass, "window", "(I)Lorg/openqa/selenium/WebDriver;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/openqa/selenium/WebElement;)Lorg/openqa/selenium/WebDriver;")]
        public virtual global::java.lang.Object frame(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_frame0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Lorg/openqa/selenium/WebDriver;")]
        public virtual global::java.lang.Object frame(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_frame1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lorg/openqa/selenium/WebDriver;")]
        public virtual global::java.lang.Object frame(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_frame2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/openqa/selenium/WebDriver;")]
        public virtual global::java.lang.Object parentFrame() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_parentFrame3));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/openqa/selenium/WebElement;")]
        public virtual global::java.lang.Object activeElement() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_activeElement4));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Lorg/openqa/selenium/WebDriver;")]
        public virtual global::java.lang.Object window(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_window5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/openqa/selenium/WebDriver;")]
        public virtual global::java.lang.Object defaultContent() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_defaultContent6));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/openqa/selenium/Alert;")]
        public virtual global::java.lang.Object alert() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_alert7));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/String;)Lorg/openqa/selenium/WebDriver;")]
        public virtual global::java.lang.Object innerFrame(global::java.lang.String[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_innerFrame8, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lorg/openqa/selenium/WebDriver;")]
        public virtual global::java.lang.Object window(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.SelenideTargetLocator.j4n_window9, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.SelenideTargetLocator(@__env);
            }
        }
    }
    #endregion
}
