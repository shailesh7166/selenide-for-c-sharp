//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide.logevents {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface LogEventListener {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/codeborne/selenide/logevents/LogEvent;)V")]
        void onEvent(global::com.codeborne.selenide.logevents.LogEvent par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class LogEventListener_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.logevents.@__LogEventListener.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::com.codeborne.selenide.logevents.LogEventListener), typeof(global::com.codeborne.selenide.logevents.LogEventListener_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::com.codeborne.selenide.logevents.LogEventListener), typeof(global::com.codeborne.selenide.logevents.LogEventListener_))]
    internal sealed partial class @__LogEventListener : global::java.lang.Object, global::com.codeborne.selenide.logevents.LogEventListener {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onEvent0;
        
        private @__LogEventListener(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.logevents.@__LogEventListener.staticClass = @__class;
            global::com.codeborne.selenide.logevents.@__LogEventListener.j4n_onEvent0 = @__env.GetMethodID(global::com.codeborne.selenide.logevents.@__LogEventListener.staticClass, "onEvent", "(Lcom/codeborne/selenide/logevents/LogEvent;)V");
        }
        
        public void onEvent(global::com.codeborne.selenide.logevents.LogEvent par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::com.codeborne.selenide.logevents.@__LogEventListener.j4n_onEvent0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::com.codeborne.selenide.logevents.LogEvent>(@__env, par0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__LogEventListener);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onEvent", "onEvent0", "(Lcom/codeborne/selenide/logevents/LogEvent;)V"));
            return methods;
        }
        
        private static void onEvent0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lcom/codeborne/selenide/logevents/LogEvent;)V
            // (Lcom/codeborne/selenide/logevents/LogEvent;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::com.codeborne.selenide.logevents.LogEventListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::com.codeborne.selenide.logevents.LogEventListener>(@__env, @__obj);
            @__real.onEvent(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::com.codeborne.selenide.logevents.LogEvent>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.logevents.@__LogEventListener(@__env);
            }
        }
    }
    #endregion
}
