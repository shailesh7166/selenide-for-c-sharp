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
    public partial class CollectionCondition : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_apply0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_size1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_fail2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_texts3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_exactTexts4;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_empty5;
        
        protected CollectionCondition(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.CollectionCondition.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/CollectionCondition;")]
        public static global::com.codeborne.selenide.CollectionCondition empty {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.CollectionCondition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.CollectionCondition.staticClass, global::com.codeborne.selenide.CollectionCondition.j4n_empty5));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.CollectionCondition.staticClass = @__class;
            global::com.codeborne.selenide.CollectionCondition.j4n_apply0 = @__env.GetMethodID(global::com.codeborne.selenide.CollectionCondition.staticClass, "apply", "(Ljava/lang/Object;)Z");
            global::com.codeborne.selenide.CollectionCondition.j4n_size1 = @__env.GetStaticMethodID(global::com.codeborne.selenide.CollectionCondition.staticClass, "size", "(I)Lcom/codeborne/selenide/CollectionCondition;");
            global::com.codeborne.selenide.CollectionCondition.j4n_fail2 = @__env.GetMethodID(global::com.codeborne.selenide.CollectionCondition.staticClass, "fail", "(Lcom/codeborne/selenide/impl/WebElementsCollection;Ljava/util/List;Ljava/lang/Ex" +
                    "ception;J)V");
            global::com.codeborne.selenide.CollectionCondition.j4n_texts3 = @__env.GetStaticMethodID(global::com.codeborne.selenide.CollectionCondition.staticClass, "texts", "([Ljava/lang/String;)Lcom/codeborne/selenide/CollectionCondition;");
            global::com.codeborne.selenide.CollectionCondition.j4n_exactTexts4 = @__env.GetStaticMethodID(global::com.codeborne.selenide.CollectionCondition.staticClass, "exactTexts", "([Ljava/lang/String;)Lcom/codeborne/selenide/CollectionCondition;");
            global::com.codeborne.selenide.CollectionCondition.j4n_empty5 = @__env.GetStaticFieldID(global::com.codeborne.selenide.CollectionCondition.staticClass, "empty", "Lcom/codeborne/selenide/CollectionCondition;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool apply(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.CollectionCondition.j4n_apply0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lcom/codeborne/selenide/CollectionCondition;")]
        public static global::com.codeborne.selenide.CollectionCondition size(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.CollectionCondition>(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.CollectionCondition.staticClass, global::com.codeborne.selenide.CollectionCondition.j4n_size1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/codeborne/selenide/impl/WebElementsCollection;Ljava/util/List;Ljava/lang/Ex" +
            "ception;J)V")]
        public virtual void fail(global::com.codeborne.selenide.impl.WebElementsCollection par0, global::java.util.List par1, global::java.lang.Exception par2, long par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            @__env.CallVoidMethod(this, global::com.codeborne.selenide.CollectionCondition.j4n_fail2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::com.codeborne.selenide.impl.WebElementsCollection>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.List>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/String;)Lcom/codeborne/selenide/CollectionCondition;")]
        public static global::com.codeborne.selenide.CollectionCondition texts(global::java.lang.String[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.CollectionCondition>(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.CollectionCondition.staticClass, global::com.codeborne.selenide.CollectionCondition.j4n_texts3, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/String;)Lcom/codeborne/selenide/CollectionCondition;")]
        public static global::com.codeborne.selenide.CollectionCondition exactTexts(global::java.lang.String[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.CollectionCondition>(@__env, @__env.CallStaticObjectMethodPtr(global::com.codeborne.selenide.CollectionCondition.staticClass, global::com.codeborne.selenide.CollectionCondition.j4n_exactTexts4, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.CollectionCondition(@__env);
            }
        }
    }
    #endregion
}