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
    public partial class SelenideFieldDecorator : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorSelenideFieldDecorator0;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/openqa/selenium/SearchContext;)V")]
        public SelenideFieldDecorator(global::java.lang.Object par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::com.codeborne.selenide.impl.SelenideFieldDecorator.staticClass, global::com.codeborne.selenide.impl.SelenideFieldDecorator.j4n__ctorSelenideFieldDecorator0, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        protected SelenideFieldDecorator(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.SelenideFieldDecorator.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.SelenideFieldDecorator.staticClass = @__class;
            global::com.codeborne.selenide.impl.SelenideFieldDecorator.j4n__ctorSelenideFieldDecorator0 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideFieldDecorator.staticClass, "<init>", "(Lorg/openqa/selenium/SearchContext;)V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.SelenideFieldDecorator(@__env);
            }
        }
    }
    #endregion
}
