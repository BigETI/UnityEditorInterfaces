using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Unity Engine interfaces namespace
/// </summary>
namespace UnityEditorInterfaces
{
    /// <summary>
    /// An interface that represents a property drawer
    /// </summary>
    public interface IPropertyDrawer
    {
        /// <summary>
        /// The PropertyAttribute for the property. Not applicable for custom class drawers.
        /// (Read Only)
        /// </summary>
        PropertyAttribute attribute { get; }

        /// <summary>
        /// Field info
        /// </summary>
        FieldInfo fieldInfo { get; }

        /// <summary>
        /// Override this method to determine whether the inspector GUI for your property
        /// can be cached.
        /// </summary>
        /// <param name="property">The SerializedProperty to make the custom GUI for.</param>
        /// <returns>Whether the drawer's UI can be cached.</returns>
        bool CanCacheInspectorGUI(SerializedProperty property);

        /// <summary>
        /// Override this method to make your own UIElements based GUI for the property.
        /// </summary>
        /// <param name="property">The SerializedProperty to make the custom GUI for.</param>
        /// <returns>The element containing the custom GUI.</returns>
        VisualElement CreatePropertyGUI(SerializedProperty property);

        /// <summary>
        /// Override this method to specify how tall the GUI for this field is in pixels.
        /// </summary>
        /// <param name="property">The SerializedProperty to make the custom GUI for.</param>
        /// <param name="label">The label of this property.</param>
        /// <returns>The height in pixels.</returns>
        float GetPropertyHeight(SerializedProperty property, GUIContent label);

        /// <summary>
        /// Override this method to make your own IMGUI based GUI for the property.
        /// </summary>
        /// <param name="position">Rectangle on the screen to use for the property GUI.</param>
        /// <param name="property">The SerializedProperty to make the custom GUI for.</param>
        /// <param name="label">The label of this property.</param>
        void OnGUI(Rect position, SerializedProperty property, GUIContent label);
    }
}
