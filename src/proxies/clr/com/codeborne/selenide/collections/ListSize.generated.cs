//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide.collections {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ListSize : global::com.codeborne.selenide.CollectionCondition {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_apply0;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_empty1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorListSize2;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public ListSize(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::com.codeborne.selenide.collections.ListSize.staticClass, global::com.codeborne.selenide.collections.ListSize.j4n__ctorListSize2, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        protected ListSize(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.collections.ListSize.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/CollectionCondition;")]
        public static global::com.codeborne.selenide.CollectionCondition empty {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.CollectionCondition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.collections.ListSize.staticClass, global::com.codeborne.selenide.collections.ListSize.j4n_empty1));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.collections.ListSize.staticClass = @__class;
            global::com.codeborne.selenide.collections.ListSize.j4n_apply0 = @__env.GetMethodID(global::com.codeborne.selenide.collections.ListSize.staticClass, "apply", "(Ljava/util/List;)Z");
            global::com.codeborne.selenide.collections.ListSize.j4n_empty1 = @__env.GetStaticFieldID(global::com.codeborne.selenide.collections.ListSize.staticClass, "empty", "Lcom/codeborne/selenide/CollectionCondition;");
            global::com.codeborne.selenide.collections.ListSize.j4n__ctorListSize2 = @__env.GetMethodID(global::com.codeborne.selenide.collections.ListSize.staticClass, "<init>", "(I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/List;)Z")]
        public virtual bool apply(global::java.util.List par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.collections.ListSize.j4n_apply0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.List>(@__env, par0))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.collections.ListSize(@__env);
            }
        }
    }
    #endregion
}
