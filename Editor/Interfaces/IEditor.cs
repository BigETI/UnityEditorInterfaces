using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Unity Editor interfaces namespace
/// </summary>
namespace UnityEditorInterfaces
{
    /// <summary>
    /// An interface that represents an editor
    /// </summary>
    public interface IEditor : IScriptableObject
    {
        /// <summary>
        /// An array of all the object being inspected.
        /// </summary>
        UnityEngine.Object[] targets { get; }

        /// <summary>
        /// The object being inspected.
        /// </summary>
        UnityEngine.Object target { get; set; }

        /// <summary>
        /// A SerializedObject representing the object or objects being inspected.
        /// </summary>
        SerializedObject serializedObject { get; }

        /// <summary>
        /// Performs a cleanup
        /// </summary>
        void Cleanup();

        /// <summary>
        /// Implement this method to make a custom UIElements inspector.
        /// </summary>
        /// <returns>Inspector GUI</returns>
        VisualElement CreateInspectorGUI();

        /// <summary>
        /// Draws the built-in inspector.
        /// </summary>
        /// <returns></returns>
        bool DrawDefaultInspector();

        /// <summary>
        /// Call this function to draw the header of the editor.
        /// </summary>
        void DrawHeader();

        /// <summary>
        /// The first entry point for Preview Drawing.
        /// </summary>
        /// <param name="previewArea">The available area to draw the preview.</param>
        void DrawPreview(Rect previewArea);

        /// <summary>
        /// Implement this method to show asset information on top of the asset preview.
        /// </summary>
        /// <returns></returns>
        string GetInfoString();

        /// <summary>
        /// Override this method if you want to change the label of the Preview area.
        /// </summary>
        /// <returns></returns>
        GUIContent GetPreviewTitle();
        //
        // Zusammenfassung:
        //     Override this method in subclasses if you implement OnPreviewGUI.
        //
        // Rückgabewerte:
        //     True if this component can be Previewed in its current state.
        bool HasPreviewGUI();

        /// <summary>
        /// Initializes editor
        /// </summary>
        /// <param name="targets">Targets</param>
        void Initialize(UnityEngine.Object[] targets);

        /// <summary>
        /// Moves to next target
        /// </summary>
        /// <returns>"true" if successful, otherwise "false"</returns>
        bool MoveNextTarget();

        /// <summary>
        /// Implement this function to make a custom inspector.
        /// </summary>
        void OnInspectorGUI();

        /// <summary>
        /// Implement to create your own interactive custom preview. Interactive custom previews
        /// are used in the preview area of the inspector and the object selector.
        /// </summary>
        /// <param name="r">Rectangle in which to draw the preview.</param>
        /// <param name="background">Background image.</param>
        void OnInteractivePreviewGUI(Rect r, GUIStyle background);

        /// <summary>
        /// Implement to create your own custom preview for the preview area of the inspector,
        /// the headers of the primary editor, and the object selector.
        /// </summary>
        /// <param name="r">Rectangle in which to draw the preview.</param>
        /// <param name="background">Background image.</param>
        void OnPreviewGUI(Rect r, GUIStyle background);

        /// <summary>
        /// Override this method if you want to show custom controls in the preview header.
        /// </summary>
        void OnPreviewSettings();

        /// <summary>
        /// Reloads preview instance
        /// </summary>
        void ReloadPreviewInstances();

        /// <summary>
        /// Override this method if you want to render a static preview.
        /// </summary>
        /// <param name="assetPath">The asset to operate on.</param>
        /// <param name="subAssets">An array of all Assets at assetPath.</param>
        /// <param name="width">Width of the created texture.</param>
        /// <param name="height">Height of the created texture.</param>
        /// <returns>Generated texture or null.</returns>
        Texture2D RenderStaticPreview(string assetPath, UnityEngine.Object[] subAssets, int width, int height);

        /// <summary>
        /// Redraw any inspectors that shows this editor.
        /// </summary>
        void Repaint();

        /// <summary>
        /// Checks if this editor requires constant repaints in its current state.
        /// </summary>
        /// <returns></returns>
        bool RequiresConstantRepaint();

        /// <summary>
        /// Resets targets
        /// </summary>
        void ResetTarget();

        /// <summary>
        /// Override this method in subclasses to return false if you don't want default
        /// margins.
        /// </summary>
        /// <returns></returns>
        bool UseDefaultMargins();
    }
}
