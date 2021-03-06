using System;
using System.Reflection;

namespace StardewModdingAPI
{
    /// <summary>A private method obtained through reflection.</summary>
    [Obsolete("Use " + nameof(IReflectedMethod) + " instead")]
    public interface IPrivateMethod
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The reflection metadata.</summary>
        MethodInfo MethodInfo { get; }


        /*********
        ** Public methods
        *********/
        /// <summary>Invoke the method.</summary>
        /// <typeparam name="TValue">The return type.</typeparam>
        /// <param name="arguments">The method arguments to pass in.</param>
        TValue Invoke<TValue>(params object[] arguments);

        /// <summary>Invoke the method.</summary>
        /// <param name="arguments">The method arguments to pass in.</param>
        void Invoke(params object[] arguments);
    }
}
