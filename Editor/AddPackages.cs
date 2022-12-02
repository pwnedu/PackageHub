using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEngine;

namespace pwnedu.hub
{
    static class AddPackages
    {
        const string _installMenu = "Tools/Package Hub/Install/";
        const string _installText = "This will add";
        const string _forText = "for use in your project.\n\nProceed with install?";

        static AddRequest Request;

        //******************* [ Install Package via git With Validation ] *******************//

        #region ProjectSetup

        [MenuItem(_installMenu + Packages.projectSetupName)]
        static void AddSetupTools()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.projectSetupName}", $"{_installText} {Packages.projectSetupName} {_forText}", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add(Packages.projectSetupURL);
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(_installMenu + Packages.projectSetupName, validate = true)]
        static bool AddSetupToolsValidate()
        {
            if (ListPackages.IsPackageInstalled(Packages.projectSetupPackage))
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

        [MenuItem(_installMenu + Packages.customAttributesName)]
        static void AddCustomAttributes()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.customAttributesName}", $"{_installText} {Packages.customAttributesName} {_forText}", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add(Packages.customAttributesURL);
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(_installMenu + Packages.customAttributesName, validate = true)]
        static bool AddCustomAttributesValidate()
        {
            if (ListPackages.IsPackageInstalled(Packages.customAttributesPackage))
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

        #region CustomUnity

        [MenuItem(_installMenu + Packages.customUnityName)]
        static void AddProjectCustomisation()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.customUnityName}", $"{_installText} {Packages.customUnityName} {_forText}", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add(Packages.customUnityURL);
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(_installMenu + Packages.customUnityName, validate = true)]
        static bool AddProjectCustomisationValidate()
        {
            if (ListPackages.IsPackageInstalled(Packages.customUnityPackage))
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

        #region MyNotes

        [MenuItem(_installMenu + Packages.myNotesName)]
        static void AddMyNotes()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.myNotesName}", $"{_installText} {Packages.myNotesName} {_forText}", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add(Packages.myNotesURL);
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(_installMenu + Packages.myNotesName, validate = true)]
        static bool AddMyNotesValidate()
        {
            if (ListPackages.IsPackageInstalled(Packages.myNotesPackage))
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

        #region Script Editor

        [MenuItem(_installMenu + Packages.scriptEditorName)]
        static void AddScriptEditor()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.scriptEditorName}", $"{_installText} {Packages.scriptEditorName} {_forText}", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add(Packages.scriptEditorURL);
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(_installMenu + Packages.scriptEditorName, validate = true)]
        static bool AdScriptEditorValidate()
        {
            if (ListPackages.IsPackageInstalled(Packages.scriptEditorPackage))
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

        //******************* [ Report Progress ] *******************//

        static void Progress()
        {
            if (Request.IsCompleted)
            {
                if (Request.Status == StatusCode.Success)
                {
                    Debug.Log("Installed: " + Request.Result.packageId);
                }
                else if (Request.Status >= StatusCode.Failure)
                {
                    Debug.Log(Request.Error.message);
                }

                EditorApplication.update -= Progress;
            }
        }
    }
}