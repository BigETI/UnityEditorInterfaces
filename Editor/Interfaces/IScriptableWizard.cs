/// <summary>
/// Unity Editor interfaces namespace
/// </summary>
namespace UnityEditorInterfaces
{
    /// <summary>
    /// An interface that represents a scriptable wizard
    /// </summary>
    public interface IScriptableWizard
    {
        /// <summary>
        /// Allows you to set the help text of the wizard.
        /// </summary>
        string helpString { get; set; }

        /// <summary>
        /// Allows you to set the error text of the wizard.
        /// </summary>
        string errorString { get; set; }

        /// <summary>
        /// Allows you to set the text shown on the create button of the wizard.
        /// </summary>
        string createButtonName { get; set; }

        /// <summary>
        /// Allows you to set the text shown on the optional other button of the wizard.
        /// Leave this parameter out to leave the button out.
        /// </summary>
        string otherButtonName { get; set; }

        /// <summary>
        /// Allows you to enable and disable the wizard create button, so that the user can
        /// not click it.
        /// </summary>
        bool isValid { get; set; }
    }
}
