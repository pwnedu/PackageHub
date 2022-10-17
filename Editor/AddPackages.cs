using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEngine;

namespace pwnedu.hub
{
    static class AddPackages
    {
        const string installItem = "Tools/Custom Tools/Packages/Install/";

        static AddRequest Request;

        //******************* [ Install Local Packages ] *******************//

        //[MenuItem(installItem + "Add Text Mesh Pro")]
        //static void AddTextMeshPro()
        //{
        //    // Add a package to the project
        //    Request = Client.Add("com.unity.textmeshpro");
        //
        //    EditorApplication.update += Progress;
        //}
        //
        //[MenuItem(installItem + "Add TMP Font Tool")]
        //static void AddFontTool()
        //{
        //    // Add a package to the project
        //    Request = Client.Add("https://github.com/pwnedu/TMPFontTool.git");
        //    //Request = Client.Add("file://C:/Users/kiltec/OneDrive/Documents/GitHub/TMPFontTool/package.json");
        //    //Request = Client.Add("com.kiltec.fonttool");
        //    EditorApplication.update += Progress;
        //}
        //
        //[MenuItem(installItem + "Add Colour Palettes")]
        //static void AddColourPalettes()
        //{
        //    // Add a package to the project
        //    Request = Client.Add("https://github.com/pwnedu/ColourPalettes.git");
        //    //Request = Client.Add("file://C:/Users/kiltec/OneDrive/Documents/GitHub/ColourPalettes/package.json");
        //    //Request = Client.Add("com.kiltec.colourpalettes");
        //
        //    EditorApplication.update += Progress;
        //}
        //
        //[MenuItem(installItem + "Add Procedural Image Tools")]
        //static void AddProceduralImages()
        //{
        //    // Add a package to the project
        //    Request = Client.Add("https://github.com/pwnedu/ProceduralImages.git");
        //    //Request = Client.Add("file://C:/Users/kiltec/OneDrive/Documents/GitHub/ProceduralImageTools/package.json");
        //    //Request = Client.Add("com.kiltec.proceduralimages");
        //
        //    EditorApplication.update += Progress;
        //}

        //******************* [ Install Package via git With Validation ] *******************//

        #region ProjectSetup

        [MenuItem(installItem + Packages.setupToolName)]
        static void AddSetupTools()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.setupToolName}", $"This will install {Packages.setupToolName} for your project.\nAre you sure?", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add("https://github.com/pwnedu/SetupTools.git");
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(installItem + Packages.setupToolName, validate = true)]
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

        [MenuItem(installItem + Packages.customAttributesName)]
        static void AddCustomAttributes()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.customAttributesName}", $"This will install {Packages.customAttributesName} for your project.\nAre you sure?", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add("https://github.com/pwnedu/CustomAttributes.git");
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(installItem + Packages.customAttributesName, validate = true)]
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

        [MenuItem(installItem + Packages.myNotesName)]
        static void AddMyNotes()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.myNotesName}", $"This will install {Packages.myNotesName} for your project.\nAre you sure?", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add("https://github.com/pwnedu/MyNotes.git");
                EditorApplication.update += Progress;
            }
        }

        [MenuItem(installItem + Packages.myNotesName, validate = true)]
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

        #region ProjectCustomiser

        [MenuItem(installItem + Packages.projectCustomisationName)]
        static void AddProjectCustomisation()
        {
            if (EditorUtility.DisplayDialog($"Add {Packages.projectCustomisationName}", $"This will install {Packages.projectCustomisationName} for your project.\nAre you sure?", "Continue", "Cancel"))
            {
                // Add a package to the project
                Request = Client.Add("https://github.com/pwnedu/ProjectCustomisation.git");
                EditorApplication.update += Progress;
            }
        }
        
        [MenuItem(installItem + Packages.projectCustomisationName, validate = true)]
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

        #region UnityTools

        //[MenuItem(installItem + Packages.unityToolsName)]
        //static void AddUnityTools()
        //{
        //    if (EditorUtility.DisplayDialog($"Add {Packages.unityToolsName}", $"This will install {Packages.unityToolsName} for your project.\nAre you sure?", "Continue", "Cancel"))
        //    {
        //        // Add a package to the project
        //        Request = Client.Add("https://github.com/pwnedu/UnityTools.git");
        //        EditorApplication.update += Progress;
        //    }
        //}
        //
        //[MenuItem(installItem + Packages.unityToolsName, validate = true)]
        //static bool AddUnityToolsValidate()
        //{
        //    if (ListPackages.IsPackageInstalled(Packages.unityToolsPackage))
        //    {
        //        //Debug.Log($"{Packages.setupToolName} not installed!");
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

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