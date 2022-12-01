using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEngine;

namespace pwnedu.hub
{
    static class AddPackages
    {
        const string _installMenu = "Tools/Custom Tools/Packages/Install/";
        const string _installText = "This will add";
        const string _forText = "for use in your project.\n\nProceed with install?";

        static AddRequest Request;

        //******************* [ Install Package via git With Validation ] *******************//

        #region ProjectSetup

        [MenuItem(_installMenu + Packages.setupToolName)]
        static void AddSetupTools()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.setupToolName}", $"{_installText} {Packages.setupToolName} {_forText}", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add("https://github.com/pwnedu/ProjectSetup.git");
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(_installMenu + Packages.setupToolName, validate = true)]
        static bool AddSetupToolsValidate()
        {
            if (ListPackages.IsPackageInstalled(Packages.setupToolPackage))
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
                Request = Client.Add("https://github.com/pwnedu/CustomAttributes.git");
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

        #region MyNotes

        [MenuItem(_installMenu + Packages.myNotesName)]
        static void AddMyNotes()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.myNotesName}", $"{_installText} {Packages.myNotesName} {_forText}", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add("https://github.com/pwnedu/MyNotes.git");
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
                Request = Client.Add("https://github.com/pwnedu/ScriptEditor.git");
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

        #region ProjectCustomiser

        [MenuItem(_installMenu + Packages.projectCustomisationName)]
        static void AddProjectCustomisation()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.projectCustomisationName}", $"{_installText} {Packages.projectCustomisationName} {_forText}", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add("https://github.com/pwnedu/ProjectCustomisation.git");
                EditorApplication.update += Progress;
            }
        }
        
        [MenuItem(_installMenu + Packages.projectCustomisationName, validate = true)]
        static bool AddProjectCustomisationValidate()
        {
            if (ListPackages.IsPackageInstalled(Packages.projectCustomisationPackage))
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