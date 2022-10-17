using UnityEngine;
using UnityEditor;
using UnityEditor.PackageManager;

namespace pwnedu.hub
{
    static class RemovePackages
    {
        const string removeItem = "Tools/Custom Tools/Packages/Uninstall/";

        //******************* [ Uninstall Packages ] *******************//

        //[MenuItem(removeItem + "Remove Colour Palettes")]
        //static void RemoveColourPalettes()
        //{
        //    // Remove a package to the project
        //    Client.Remove("com.kiltec.colourpalettes");
        //}

        //[MenuItem(removeItem + "Remove TMP Font Tool")]
        //static void RemoveFontTool()
        //{
        //    // Remove a package to the project
        //    Client.Remove("com.kiltec.fonttool");
        //}

        //[MenuItem(removeItem + "Remove Procedural Images")]
        //static void RemoveProceduralImageTool()
        //{
        //    // Remove a package to the project
        //    Client.Remove("com.kiltec.proceduralimages");
        //}

        //******************* [ Uninstall Package With Validation ] *******************//

        #region ProjectSetup

        [MenuItem(removeItem + Packages.setupToolName)]
        static void RemoveSetupTools()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.setupToolName}", $"This will remove {Packages.setupToolName} from your project.\nAre you sure?", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.setupToolPackage);
                Debug.Log($"{Packages.setupToolName} package removed!");
            }
        }

        [MenuItem(removeItem + Packages.setupToolName, validate = true)]
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

        [MenuItem(removeItem + Packages.customAttributesName)]
        static void RemoveCustomAttributes()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.customAttributesName}", $"This will remove {Packages.customAttributesName} from your project.\nAre you sure?", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.customAttributesPackage);
                Debug.Log($"{Packages.customAttributesName} package removed!");
            }
        }

        [MenuItem(removeItem + Packages.customAttributesName, validate = true)]
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

        [MenuItem(removeItem + Packages.myNotesName)]
        static void RemoveMyNotes()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.myNotesName}", $"This will remove {Packages.myNotesName} from your project.\nAre you sure?", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.myNotesPackage);
                Debug.Log($"{Packages.myNotesName} package removed!");
            }
        }

        [MenuItem(removeItem + Packages.myNotesName, validate = true)]
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

        #region ProjectCustomisation

        //[MenuItem(removeItem + Packages.projectCustomisationName)]
        //static void RemoveProjectCustomiser()
        //{
        //    if (EditorUtility.DisplayDialog($"Remove {Packages.projectCustomisationName}", $"This will remove {Packages.projectCustomisationName} from your project.\nAre you sure?", "Confirm", "Cancel"))
        //    {
        //        // Remove a package to the project
        //        Client.Remove(Packages.projectCustomisationPackage);
        //        Debug.Log($"{Packages.projectCustomisationName} package removed!");
        //    }
        //}
        //
        //[MenuItem(removeItem + Packages.projectCustomisationName, validate = true)]
        //static bool RemoveProjectCustomiserValidate()
        //{
        //    if (!ListPackages.IsPackageInstalled(Packages.projectCustomisationPackage))
        //    {
        //        //Debug.Log($"{Packages.projectCustomisationName} not installed!");
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        #endregion

        #region UnityTools

        [MenuItem(removeItem + Packages.unityToolsName)]
        static void RemoveUnityTools()
        {
            if (EditorUtility.DisplayDialog($"Remove {Packages.unityToolsName}", $"This will remove {Packages.unityToolsName} from your project.\nAre you sure?", "Confirm", "Cancel"))
            {
                // Remove a package to the project
                Client.Remove(Packages.unityToolsPackage);
                Debug.Log($"{Packages.unityToolsName} package removed!");
            }
        }

        [MenuItem(removeItem + Packages.unityToolsName, validate = true)]
        static bool RemoveUnityToolsValidate()
        {
            if (!ListPackages.IsPackageInstalled(Packages.unityToolsPackage)) 
            {
                //Debug.Log($"{Packages.unityToolsName} not installed!");
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