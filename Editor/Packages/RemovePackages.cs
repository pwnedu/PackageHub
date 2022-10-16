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

        [MenuItem(removeItem + "Project Setup Tools")]
        static void RemoveSetupTools()
        {
            // Remove a package to the project
            Client.Remove("com.kiltec.setuptools");
        }

        [MenuItem(removeItem + "Remove Custom Attributes")]
        static void RemoveCustomAttributes()
        {
            // Remove a package to the project
            Client.Remove("com.kiltec.customattributes");
        }

        [MenuItem(removeItem + "My Notes")]
        static void RemoveMyNotes()
        {
            // Remove a package to the project
            Client.Remove("com.kiltec.mynotes");
        }

        [MenuItem(removeItem + "Remove Unity Tools")]
        static void RemoveUnityTools()
        {
            // Remove a package to the project
            Client.Remove("com.kiltec.unitytools");
        }
    }
}