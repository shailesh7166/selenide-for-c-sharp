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
    public partial class SelenideElementListProxy : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_invoke0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_wrap1;
        
        protected SelenideElementListProxy(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.SelenideElementListProxy.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.SelenideElementListProxy.staticClass = @__class;
            global::com.codeborne.selenide.impl.SelenideElementListProxy.j4n_invoke0 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListProxy.staticClass, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Objec" +
                    "t;");
            global::com.codeborne.selenide.impl.SelenideElementListProxy.j4n_wrap1 = @__env.GetStaticMethodID(global::com.codeborne.selenide.impl.SelenideElementListProxy.staticClass, "wrap", "(Lorg/openqa/selenium/support/pagefactory/ElementLocator;)Ljava/util/List;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Objec" +
            "t;")]
        public virtual global::java.lang.Object invoke(global::java.lang.Object par0, global::java.lang.reflect.Method par1, global::java.lang.Object[] par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.SelenideElementListProxy.j4n_invoke0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<global::java.lang.Object[], global::java.lang.Object>(@__env, par2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/openqa/selenium/support/pagefactory/ElementLocator;)Ljava/util/List;")]
        public static global::java.util.List wrap(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.List>(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.impl.SelenideElementListProxy.staticClass, global::com.codeborne.selenide.impl.SelenideElementListProxy.j4n_wrap1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.SelenideElementListProxy(@__env);
            }
        }
    }
    #endregion
}
