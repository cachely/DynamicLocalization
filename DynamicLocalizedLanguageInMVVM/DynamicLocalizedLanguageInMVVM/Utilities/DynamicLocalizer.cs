using System;
using System.Reflection;
using System.Resources;

namespace DynamicLocalizedLanguageInMVVM.Utilities
{
    internal static class DynamicLocalizer
    {
        internal static string GetText(string text)
        {
            if (text == null)
                return string.Empty;

            var resMgr = new Lazy<ResourceManager>(() => new ResourceManager(Settings.Culture, typeof(DynamicLocalizer).GetTypeInfo().Assembly));        
            return  resMgr.Value.GetString(text) ?? string.Empty;

            //consider a default or a handler for empty strings
        }
    }
}
