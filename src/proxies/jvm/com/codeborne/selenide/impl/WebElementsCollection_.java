// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package com.codeborne.selenide.impl;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class WebElementsCollection_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return com.codeborne.selenide.impl.WebElementsCollection_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        com.codeborne.selenide.impl.WebElementsCollection_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __WebElementsCollection extends system.Object implements com.codeborne.selenide.impl.WebElementsCollection {
    
    protected __WebElementsCollection(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String description();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/List;")
    public native java.util.List getActualElements();
}
//</generated-proxy>