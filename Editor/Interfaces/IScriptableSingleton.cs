using UnityEngine;

/// <summary>
/// Unity Editor interfaces namespace
/// </summary>
namespace UnityEditorInterfaces
{
    /// <summary>
    /// An interface that represents a scriptable singleton
    /// </summary>
    /// <typeparam name="T">Scriptable object type</typeparam>
    public interface IScriptableSingleton<T> where T : ScriptableObject
    {
        // ...
    }
}
