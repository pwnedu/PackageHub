using UnityEngine;
using UnityEditor;
using UnityEditor.PackageManager;

namespace pwnedu.hub
{
    static class RemovePackages
    {
        const string _removeMenu = "Tools/Custom Tools/Packages/Uninstall/";
        const string _removeText = "This will remove";
        const string _fromText = "from your project.\n\nAre you sure?";
        const string _confirmationText = "package removed!";

        //******************* [ Uninstall Package With Validation ] *******************//

        #region ProjectSetup

        [MenuItem(_removeMenu + Packages.setupToolName)]
        static void RemoveSetupTools()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.setupToolName}", $"{_removeText} {Packages.setupToolName} {_fromText}", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.setupToolPackage);
                Debug.Log($"{Packages.setupToolName} {_confirmationText}");
            }
        }

        [MenuItem(_removeMenu + Packages.setupToolName, validate = true)]
        static bool RemoveSetupToolsValidate()
        {
            if (!ListPackages.IsPackageInstalled(Packages.setupToolPackage))
            {
                //Debug.Log($"{Packages.setupToolName} not installed!");
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region CustomAttributes

        [MenuItem(_removeMenu + Packages.customAttributesName)]
        static void RemoveCustomAttributes()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.customAttributesName}", $"{_removeText} {Packages.customAttributesName} {_fromText}", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.customAttributesPackage);
                Debug.Log($"{Packages.customAttributesName} {_confirmationText}");
            }
        }

        [MenuItem(_removeMenu + Packages.customAttributesName, validate = true)]
        static bool RemoveCustomAttributesValidate()
        {
            if (!ListPackages.IsPackageInstalled(Packages.customAttributesPackage))
            {
                //Debug.Log($"{Packages.customAttributesName} not installed!");
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region MyNotes

        [MenuItem(_removeMenu + Packages.myNotesName)]
        static void RemoveMyNotes()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.myNotesName}", $"{_removeText} {Packages.myNotesName} {_fromText}", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.myNotesPackage);
                Debug.Log($"{Packages.myNotesName} {_confirmationText}");
            }
        }

        [MenuItem(_removeMenu + Packages.myNotesName, validate = true)]
        static bool RemoveMyNotesValidate()
        {
            if (!ListPackages.IsPackageInstalled(Packages.myNotesPackage)) 
            {
                //Debug.Log($"{Packages.myNotesName} not installed!");
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region Script Editor

        [MenuItem(_removeMenu + Packages.scriptEditorName)]
        static void RemoveScriptEditor()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.scriptEditorName}", $"{_removeText} {Packages.scriptEditorName} {_fromText}", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.scriptEditorPackage);
                Debug.Log($"{Packages.scriptEditorName} {_confirmationText}");
            }
        }

        [MenuItem(_removeMenu + Packages.scriptEditorName, validate = true)]
        static bool RemoveScriptEditorValidate()
        {
            if (!ListPackages.IsPackageInstalled(Packages.scriptEditorPackage))
            {
                //Debug.Log($"{Packages.myNotesName} not installed!");
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region ProjectCustomisation

        [MenuItem(_removeMenu + Packages.projectCustomisationName)]
        static void RemoveProjectCustomiser()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.projectCustomisationName}", $"{_removeText} {Packages.projectCustomisationName} {_fromText}", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.projectCustomisationPackage);
                Debug.Log($"{Packages.projectCustomisationName} {_confirmationText}");
            }
        }
        
        [MenuItem(_removeMenu + Packages.projectCustomisationName, validate = true)]
        static bool RemoveProjectCustomiserValidate()
        {
            if (!ListPackages.IsPackageInstalled(Packages.projectCustomisationPackage))
            {
                //Debug.Log($"{Packages.projectCustomisationName} not installed!");
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}