using UnityEngine;
using UnityEditor;
using UnityEditor.PackageManager;

namespace pwnedu.hub
{
    static class RemovePackages
    {
        const string _removeMenu = "Tools/Package Hub/Uninstall/";
        const string _removeText = "This will remove";
        const string _fromText = "from your project.\n\nAre you sure?";

        //******************* [ Uninstall Package With Validation ] *******************//

        #region ProjectSetup

        [MenuItem(_removeMenu + Packages.projectSetupName)]
        static void RemoveSetupTools()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.projectSetupName}", $"{_removeText} {Packages.projectSetupName} {_fromText}", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.projectSetupPackage);
                Debug.Log($"Removing {Packages.projectSetupName}");
            }
        }

        [MenuItem(_removeMenu + Packages.projectSetupName, validate = true)]
        static bool RemoveSetupToolsValidate()
        {
            if (!ListPackages.IsPackageInstalled(Packages.projectSetupPackage))
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
                Debug.Log($"Removing {Packages.customAttributesName}");
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

        #region CustomUnity

        [MenuItem(_removeMenu + Packages.customUnityName)]
        static void RemoveProjectCustomiser()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.customUnityName}", $"{_removeText} {Packages.customUnityName} {_fromText}", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.customUnityPackage);
                Debug.Log($"Removing {Packages.customUnityName}");
            }
        }

        [MenuItem(_removeMenu + Packages.customUnityName, validate = true)]
        static bool RemoveProjectCustomiserValidate()
        {
            if (!ListPackages.IsPackageInstalled(Packages.customUnityPackage))
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

        #region MyNotes

        [MenuItem(_removeMenu + Packages.myNotesName)]
        static void RemoveMyNotes()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.myNotesName}", $"{_removeText} {Packages.myNotesName} {_fromText}", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.myNotesPackage);
                Debug.Log($"Removing {Packages.myNotesName}");
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
                Debug.Log($"Removing {Packages.scriptEditorName}");
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

    }
}