using System;

namespace DataForSeo.Client.Models
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    internal class JsonInheritanceAttribute : Attribute
    {
        public JsonInheritanceAttribute(string key, Type type)
        {
            Key = key;
            Type = type;
        }

        public string Key { get; }

        public Type Type { get; }
    }
}