using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Unity Editor interfaces
/// </summary>
namespace UnityEditorInterfaces
{
    /// <summary>
    /// An interface that represents an editor window
    /// </summary>
    public interface IEditorWindow : IScriptableObject
    {
        /// <summary>
        /// The EditorWindow currently under the mouse cursor. (Read Only)
        /// </summary>
        static EditorWindow mouseOverWindow { get; }

        /// <summary>
        /// The EditorWindow which currently has keyboard focus. (Read Only)
        /// </summary>
        static EditorWindow focusedWindow { get; }

        /// <summary>
        /// Checks whether MouseMove events are received in the GUI in this Editor window.
        /// </summary>
        bool wantsMouseMove { get; set; }

        /// <summary>
        /// Checks whether MouseEnterWindow and MouseLeaveWindow events are received in the
        /// GUI in this Editor window.
        /// </summary>
        bool wantsMouseEnterLeaveWindow { get; set; }

        /// <summary>
        /// Retrieves the root visual element of this window hierarchy.
        /// </summary>
        VisualElement rootVisualElement { get; }

        /// <summary>
        /// Specifies whether a layout pass is performed before all user events (for example,
        /// EventType.MouseDown or EventType, KeyDown), or is only performed before repaint
        /// events.
        /// </summary>
        bool wantsLessLayoutEvents { get; set; }

        /// <summary>
        /// Does the window automatically repaint whenever the Scene has changed?
        /// </summary>
        bool autoRepaintOnSceneChange { get; set; }

        /// <summary>
        /// Is this window maximized?
        /// </summary>
        bool maximized { get; set; }

        /// <summary>
        /// Returns true if EditorWindow is focused.
        /// </summary>
        bool hasFocus { get; }

        /// <summary>
        /// The desired position of the window in screen space.
        /// </summary>
        Rect position { get; set; }

        /// <summary>
        /// This property specifies whether the Editor prompts the user to save or discard
        /// unsaved changes before the window closes.
        /// </summary>
        bool hasUnsavedChanges { get; }

        /// <summary>
        /// The message that displays to the user if they are prompted to save
        /// </summary>
        string saveChangesMessage { get; }

        /// <summary>
        /// The minimum size of this window when it is floating or modal. The minimum size
        /// is not used when the window is docked.
        /// </summary>
        Vector2 minSize { get; set; }

        /// <summary>
        /// Depth buffer bits
        /// </summary>
        int depthBufferBits { get; set; }

        /// <summary>
        /// The GUIContent used for drawing the title of EditorWindows.
        /// </summary>
        GUIContent titleContent { get; set; }

        /// <summary>
        /// The maximum size of this window when it is floating or modal. The maximum size
        /// is not used when the window is docked.
        /// </summary>
        Vector2 maxSize { get; set; }

        /// <summary>
        /// Returns true if EditorWindow is docked.
        /// </summary>
        bool docked { get; }

        /// <summary>
        /// Mark the beginning area of all popup windows.
        /// </summary>
        void BeginWindows();

        /// <summary>
        /// Close the editor window.
        /// </summary>
        void Close();

        /// <summary>
        /// Discards unsaved changes to the contents of the window.
        /// </summary>
        void DiscardChanges();

        /// <summary>
        /// Close a window group started with EditorWindow.BeginWindows.
        /// </summary>
        void EndWindows();

        /// <summary>
        /// Moves keyboard focus to another EditorWindow.
        /// </summary>
        void Focus();

        /// <summary>
        /// Gets the extra panes associated with the window.
        /// </summary>
        /// <returns>The extra panes that are specific to the window.</returns>
        IEnumerable<Type> GetExtraPaneTypes();

        /// <summary>
        /// Stop showing notification message.
        /// </summary>
        void RemoveNotification();

        /// <summary>
        /// Make the window repaint.
        /// </summary>
        void Repaint();

        /// <summary>
        /// Performs a save action on the contents of the window.
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Sends an Event to a window.
        /// </summary>
        /// <param name="e">Event</param>
        /// <returns>Event result</returns>
        bool SendEvent(Event e);

        /// <summary>
        /// Show the EditorWindow window.
        /// </summary>
        /// <param name="immediateDisplay">Immediately display Show.</param>
        void Show(bool immediateDisplay);

        /// <summary>
        /// Show the EditorWindow window.
        /// </summary>
        void Show();

        /// <summary>
        /// Shows a window with dropdown behaviour and styling.
        /// </summary>
        /// <param name="buttonRect">The button from which the position of the window will be determined (see description).</param>
        /// <param name="windowSize">The initial size of the window.</param>
        void ShowAsDropDown(Rect buttonRect, Vector2 windowSize);

        /// <summary>
        /// Show the editor window in the auxiliary window.
        /// </summary>
        void ShowAuxWindow();

        /// <summary>
        /// Show modal editor window.
        /// </summary>
        void ShowModal();

        /// <summary>
        /// Show the EditorWindow as a floating modal window.
        /// </summary>
        void ShowModalUtility();

        /// <summary>
        /// Show a notification message.
        /// </summary>
        /// <param name="notification">The contents of the notification message.</param>
        /// <param name="fadeoutWait">The duration the notification is displayed. Measured in seconds.</param>
        void ShowNotification(GUIContent notification, double fadeoutWait);

        /// <summary>
        /// Show a notification message.
        /// </summary>
        /// <param name="notification">The contents of the notification message.</param>
        void ShowNotification(GUIContent notification);

        /// <summary>
        /// Shows an Editor window using popup-style framing.
        /// </summary>
        void ShowPopup();

        /// <summary>
        /// Shows an Editor window using tab framing.
        /// </summary>
        void ShowTab();

        /// <summary>
        /// Show the EditorWindow as a floating utility window.
        /// </summary>
        void ShowUtility();

        /// <summary>
        /// Tries to get an overlay
        /// </summary>
        /// <param name="id">Overlay ID</param>
        /// <param name="match">Overlay match</param>
        /// <returns></returns>
        bool TryGetOverlay(string id, out Overlay match);
    }
}
