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
    public partial class Html : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_equals0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_contains1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_matches2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_equalsCaseSensitive3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_containsCaseSensitive4;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_text5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorHtml6;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Html() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::com.codeborne.selenide.impl.Html.staticClass, global::com.codeborne.selenide.impl.Html.j4n__ctorHtml6, this);
            }
        }
        
        protected Html(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.Html.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/impl/Html;")]
        public static global::com.codeborne.selenide.impl.Html text {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.impl.Html>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.impl.Html.staticClass, global::com.codeborne.selenide.impl.Html.j4n_text5));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.Html.staticClass = @__class;
            global::com.codeborne.selenide.impl.Html.j4n_equals0 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Html.staticClass, "equals", "(Ljava/lang/String;Ljava/lang/String;)Z");
            global::com.codeborne.selenide.impl.Html.j4n_contains1 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Html.staticClass, "contains", "(Ljava/lang/String;Ljava/lang/String;)Z");
            global::com.codeborne.selenide.impl.Html.j4n_matches2 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Html.staticClass, "matches", "(Ljava/lang/String;Ljava/lang/String;)Z");
            global::com.codeborne.selenide.impl.Html.j4n_equalsCaseSensitive3 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Html.staticClass, "equalsCaseSensitive", "(Ljava/lang/String;Ljava/lang/String;)Z");
            global::com.codeborne.selenide.impl.Html.j4n_containsCaseSensitive4 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Html.staticClass, "containsCaseSensitive", "(Ljava/lang/String;Ljava/lang/String;)Z");
            global::com.codeborne.selenide.impl.Html.j4n_text5 = @__env.GetStaticFieldID(global::com.codeborne.selenide.impl.Html.staticClass, "text", "Lcom/codeborne/selenide/impl/Html;");
            global::com.codeborne.selenide.impl.Html.j4n__ctorHtml6 = @__env.GetMethodID(global::com.codeborne.selenide.impl.Html.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Z")]
        public virtual bool equals(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.impl.Html.j4n_equals0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Z")]
        public virtual bool contains(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.impl.Html.j4n_contains1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Z")]
        public virtual bool matches(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.impl.Html.j4n_matches2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Z")]
        public virtual bool equalsCaseSensitive(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.impl.Html.j4n_equalsCaseSensitive3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Z")]
        public virtual bool containsCaseSensitive(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.impl.Html.j4n_containsCaseSensitive4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.Html(@__env);
            }
        }
    }
    #endregion
}