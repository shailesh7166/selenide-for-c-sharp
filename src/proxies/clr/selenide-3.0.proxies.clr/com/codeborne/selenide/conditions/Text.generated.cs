//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide.conditions {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Text : global::com.codeborne.selenide.Condition {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_visible0;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_exist1;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_present2;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_hidden3;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_appear4;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_appears5;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_disappears6;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_disappear7;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_readonly8;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_empty9;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_focused10;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_enabled11;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_disabled12;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_selected13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorText14;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Text(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n__ctorText14, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        protected Text(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.conditions.Text.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition visible {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_visible0));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition exist {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_exist1));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition present {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_present2));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition hidden {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_hidden3));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition appear {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_appear4));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition appears {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_appears5));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition disappears {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_disappears6));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition disappear {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_disappear7));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition @readonly {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_readonly8));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition empty {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_empty9));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition focused {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_focused10));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition enabled {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_enabled11));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition disabled {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_disabled12));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lcom/codeborne/selenide/Condition;")]
        public static global::com.codeborne.selenide.Condition selected {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::com.codeborne.selenide.Condition>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.conditions.Text.staticClass, global::com.codeborne.selenide.conditions.Text.j4n_selected13));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.conditions.Text.staticClass = @__class;
            global::com.codeborne.selenide.conditions.Text.j4n_visible0 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "visible", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_exist1 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "exist", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_present2 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "present", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_hidden3 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "hidden", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_appear4 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "appear", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_appears5 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "appears", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_disappears6 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "disappears", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_disappear7 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "disappear", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_readonly8 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "readonly", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_empty9 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "empty", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_focused10 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "focused", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_enabled11 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "enabled", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_disabled12 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "disabled", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n_selected13 = @__env.GetStaticFieldID(global::com.codeborne.selenide.conditions.Text.staticClass, "selected", "Lcom/codeborne/selenide/Condition;");
            global::com.codeborne.selenide.conditions.Text.j4n__ctorText14 = @__env.GetMethodID(global::com.codeborne.selenide.conditions.Text.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.conditions.Text(@__env);
            }
        }
    }
    #endregion
}