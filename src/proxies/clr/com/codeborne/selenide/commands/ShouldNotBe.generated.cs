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
    public partial class ShouldNotBe : global::com.codeborne.selenide.commands.ShouldNot {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_NO_ARGS0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorShouldNotBe1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public ShouldNotBe() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::com.codeborne.selenide.commands.ShouldNotBe.staticClass, global::com.codeborne.selenide.commands.ShouldNotBe.j4n__ctorShouldNotBe1, this);
            }
        }
        
        protected ShouldNotBe(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.commands.ShouldNotBe.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("[Ljava/lang/Object;")]
        public static global::java.lang.Object[] NO_ARGS {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::java.lang.Object[], global::java.lang.Object>(@__env, @__env.GetStaticObjectFieldPtr(global::com.codeborne.selenide.commands.ShouldNotBe.staticClass, global::com.codeborne.selenide.commands.ShouldNotBe.j4n_NO_ARGS0));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.commands.ShouldNotBe.staticClass = @__class;
            global::com.codeborne.selenide.commands.ShouldNotBe.j4n_NO_ARGS0 = @__env.GetStaticFieldID(global::com.codeborne.selenide.commands.ShouldNotBe.staticClass, "NO_ARGS", "[Ljava/lang/Object;");
            global::com.codeborne.selenide.commands.ShouldNotBe.j4n__ctorShouldNotBe1 = @__env.GetMethodID(global::com.codeborne.selenide.commands.ShouldNotBe.staticClass, "<init>", "()V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.commands.ShouldNotBe(@__env);
            }
        }
    }
    #endregion
}