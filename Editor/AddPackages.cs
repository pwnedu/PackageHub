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

        //******************* [ Install Packages ] *******************//

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

        [MenuItem(installItem + "Add Setup Tools Package")]
        static void AddSetupTools()
        {
            // Add a package to the project
            Request = Client.Add("https://github.com/pwnedu/SetupTools.git");
            EditorApplication.update += Progress;
        }

        [MenuItem(installItem + "Add Custom Attributes Package")]
        static void AddCustomAttributes()
        {
            // Add a package to the project
            Request = Client.Add("https://github.com/pwnedu/CustomAttributes.git");
            EditorApplication.update += Progress;
        }

        [MenuItem(installItem + "Add My Notes Package")]
        static void AddMyNotes()
        {
            // Add a package to the project
            Request = Client.Add("https://github.com/pwnedu/MyNotes.git");
            EditorApplication.update += Progress;
        }

        [MenuItem(installItem + "Add Unity Tools Package")]
        static void AddUnityTools()
        {
            // Add a package to the project
            Request = Client.Add("https://github.com/pwnedu/UnityTools.git");
            EditorApplication.update += Progress;
        }

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