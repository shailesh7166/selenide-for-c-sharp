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
    public partial class ElementsContainer : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getSelf0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setSelf1;
        
        protected ElementsContainer(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.ElementsContainer.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.ElementsContainer.staticClass = @__class;
            global::com.codeborne.selenide.ElementsContainer.j4n_getSelf0 = @__env.GetMethodID(global::com.codeborne.selenide.ElementsContainer.staticClass, "getSelf", "()Lcom/codeborne/selenide/SelenideElement;");
            global::com.codeborne.selenide.ElementsContainer.j4n_setSelf1 = @__env.GetMethodID(global::com.codeborne.selenide.ElementsContainer.staticClass, "setSelf", "(Lcom/codeborne/selenide/SelenideElement;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lcom/codeborne/selenide/SelenideElement;")]
        public virtual global::com.codeborne.selenide.SelenideElement getSelf() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::com.codeborne.selenide.SelenideElement>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.ElementsContainer.j4n_getSelf0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/codeborne/selenide/SelenideElement;)V")]
        public virtual void setSelf(global::com.codeborne.selenide.SelenideElement par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::com.codeborne.selenide.ElementsContainer.j4n_setSelf1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::com.codeborne.selenide.SelenideElement>(@__env, par0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.ElementsContainer(@__env);
            }
        }
    }
    #endregion
}
