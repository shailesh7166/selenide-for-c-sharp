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
    public partial class TextsMismatch : global::com.codeborne.selenide.ex.UIAssertionError {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_timeoutMs0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorTextsMismatch1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/codeborne/selenide/impl/WebElementsCollection;[Ljava/lang/String;[Ljava/lan" +
            "g/String;J)V")]
        public TextsMismatch(global::com.codeborne.selenide.impl.WebElementsCollection par0, global::java.lang.String[] par1, global::java.lang.String[] par2, long par3) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            @__env.NewObject(global::com.codeborne.selenide.ex.TextsMismatch.staticClass, global::com.codeborne.selenide.ex.TextsMismatch.j4n__ctorTextsMismatch1, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::com.codeborne.selenide.impl.WebElementsCollection>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3));
            }
        }
        
        protected TextsMismatch(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected TextsMismatch(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.ex.TextsMismatch.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("J")]
        public virtual long timeoutMs {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((long)(@__env.GetLongField(this, global::com.codeborne.selenide.ex.TextsMismatch.j4n_timeoutMs0)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.ex.TextsMismatch.staticClass = @__class;
            global::com.codeborne.selenide.ex.TextsMismatch.j4n_timeoutMs0 = @__env.GetFieldID(global::com.codeborne.selenide.ex.TextsMismatch.staticClass, "timeoutMs", "J");
            global::com.codeborne.selenide.ex.TextsMismatch.j4n__ctorTextsMismatch1 = @__env.GetMethodID(global::com.codeborne.selenide.ex.TextsMismatch.staticClass, "<init>", "(Lcom/codeborne/selenide/impl/WebElementsCollection;[Ljava/lang/String;[Ljava/lan" +
                    "g/String;J)V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.ex.TextsMismatch(@__env);
            }
        }
    }
    #endregion
}