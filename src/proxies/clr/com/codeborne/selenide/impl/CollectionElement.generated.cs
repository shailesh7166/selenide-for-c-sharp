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
    public partial class CollectionElement : global::com.codeborne.selenide.impl.WebElementSource {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_wrap0;
        
        protected CollectionElement(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.CollectionElement.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.CollectionElement.staticClass = @__class;
            global::com.codeborne.selenide.impl.CollectionElement.j4n_wrap0 = @__env.GetStaticMethodID(global::com.codeborne.selenide.impl.CollectionElement.staticClass, "wrap", "(Lcom/codeborne/selenide/impl/WebElementsCollection;I)Lcom/codeborne/selenide/Sel" +
                    "enideElement;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/codeborne/selenide/impl/WebElementsCollection;I)Lcom/codeborne/selenide/Sel" +
            "enideElement;")]
        public static global::com.codeborne.selenide.SelenideElement wrap(global::com.codeborne.selenide.impl.WebElementsCollection par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::com.codeborne.selenide.SelenideElement>(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.impl.CollectionElement.staticClass, global::com.codeborne.selenide.impl.CollectionElement.j4n_wrap0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::com.codeborne.selenide.impl.WebElementsCollection>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.CollectionElement(@__env);
            }
        }
    }
    #endregion
}
