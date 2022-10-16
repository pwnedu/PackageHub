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

        const string setupTool = "Project Setup Tools";
        [MenuItem(removeItem + setupTool)]
        static void RemoveSetupTools()
        {
            if (EditorUtility.DisplayDialog($"Remove {setupTool}", $"This will remove {setupTool} from your project.\nAre you sure?", "Confirm", "Cancel"))
            {
                Client.Remove("com.kiltec.setuptools");
                Debug.Log($"{setupTool} package removed!");
            }
        }

        const string customAttributes = "Custom Attributes";
        [MenuItem(removeItem + customAttributes)]
        static void RemoveCustomAttributes()
        {
            if (EditorUtility.DisplayDialog($"Remove {customAttributes}", $"This will remove {customAttributes} from your project.\nAre you sure?", "Confirm", "Cancel"))
            {
                Client.Remove("com.kiltec.customattributes");
                Debug.Log($"{customAttributes} package removed!");
            }
        }

        const string myNotes = "My Notes";
        [MenuItem(removeItem + myNotes)]
        static void RemoveMyNotes()
        {
            if (EditorUtility.DisplayDialog($"Remove {myNotes}", $"This will remove {myNotes} from your project.\nAre you sure?", "Confirm", "Cancel"))
            {
                Client.Remove("com.kiltec.mynotes");
                Debug.Log($"{myNotes} package removed!");
            }
        }

        const string unityTools = "Unity Tools";
        [MenuItem(removeItem + unityTools)]
        static void RemoveUnityTools()
        {
            if (EditorUtility.DisplayDialog($"Remove {unityTools}", $"This will remove {unityTools} from your project.\nAre you sure?", "Confirm", "Cancel"))
            {
                Client.Remove("com.kiltec.unitytools");
                Debug.Log($"{unityTools} package removed!");
            }
        }
    }
}