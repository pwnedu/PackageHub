using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEngine;

namespace pwnedu.hub
{
    static class ListPackages
    {
        private static ListRequest Request;

        [MenuItem("Tools/Custom Tools/Packages/List Installed Packages", priority = 100)]
        public static void List()
        {
            // List packages installed for the project
            Request = Client.List();    
            EditorApplication.update += Progress;
        }

        private static void Progress()
        {
            if (Request.IsCompleted)
            {
                if (Request.Status == StatusCode.Success)
                {
                    foreach (var package in Request.Result)
                    {
                        if (package.name.Contains("kiltec"))
                        {
                            Debug.Log($"Package Name: {package.displayName} {package.name}");
                        }

                        //if (package.displayName.Contains("pwnedu"))
                        //{
                        //    Debug.Log($"Package Name: {package.displayName} {package.name}");
                        //}
                    }
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