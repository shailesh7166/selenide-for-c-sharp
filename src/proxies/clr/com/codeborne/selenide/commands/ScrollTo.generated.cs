//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide.commands {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ScrollTo : global::java.lang.Object, global::com.codeborne.selenide.Command {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_execute0;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_NO_ARGS1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorScrollTo2;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public ScrollTo() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::com.codeborne.selenide.commands.ScrollTo.staticClass, global::com.codeborne.selenide.commands.ScrollTo.j4n__ctorScrollTo2, this);
            }
        }
        
        protected ScrollTo(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.commands.ScrollTo.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("[Ljava/lang/Object;")]
        public static global::java.lang.Object[] NO_ARGS {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.Object[], global::java.lang.Object>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.commands.ScrollTo.staticClass, global::com.codeborne.selenide.commands.ScrollTo.j4n_NO_ARGS1));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.commands.ScrollTo.staticClass = @__class;
            global::com.codeborne.selenide.commands.ScrollTo.j4n_execute0 = @__env.GetMethodID(global::com.codeborne.selenide.commands.ScrollTo.staticClass, "execute", "(Lcom/codeborne/selenide/SelenideElement;Lcom/codeborne/selenide/impl/WebElementS" +
                    "ource;[Ljava/lang/Object;)Ljava/lang/Object;");
            global::com.codeborne.selenide.commands.ScrollTo.j4n_NO_ARGS1 = @__env.GetStaticFieldID(global::com.codeborne.selenide.commands.ScrollTo.staticClass, "NO_ARGS", "[Ljava/lang/Object;");
            global::com.codeborne.selenide.commands.ScrollTo.j4n__ctorScrollTo2 = @__env.GetMethodID(global::com.codeborne.selenide.commands.ScrollTo.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/codeborne/selenide/SelenideElement;Lcom/codeborne/selenide/impl/WebElementS" +
            "ource;[Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object execute(global::com.codeborne.selenide.SelenideElement par0, global::com.codeborne.selenide.impl.WebElementSource par1, global::java.lang.Object[] par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.commands.ScrollTo.j4n_execute0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::com.codeborne.selenide.SelenideElement>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<global::java.lang.Object[], global::java.lang.Object>(@__env, par2)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.commands.ScrollTo(@__env);
            }
        }
    }
    #endregion
}
