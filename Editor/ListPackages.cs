using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEditor;
using UnityEngine;

namespace pwnedu.hub
{
    static class ListPackages
    {
        private static ListRequest Request;

        private static readonly List<string> packageList = new List<string>();

        [InitializeOnLoadMethod] [MenuItem("Tools/Custom Tools/Packages/List Installed Packages", priority = 100)]
        public static void List()
        {
            Request = Client.List();
            EditorApplication.update += Progress;
        }

        private static void Progress()
        {
            if (Request.IsCompleted)
            {
                if (Request.Status == StatusCode.Success)
                {
                    packageList.Clear();

                    foreach (var package in Request.Result)
                    {
                        if (package.name.Contains("kiltec"))
                        {
                            packageList.Add(package.name);
                            //Debug.Log($"Package Name: {package.displayName} {package.name}");
                        }
                    }

                    //Debug.Log("Package List Updated!");
                }
                else if (Request.Status >= StatusCode.Failure)
                {
                    Debug.Log(Request.Error.message);
                }

                EditorApplication.update -= Progress;
            }
        }

        public static List<string> InstalledPackageList()
        {
            return packageList;
        }

        public static bool IsPackageInstalled(string package)
        {
            return packageList.Contains(package);
        }
    }
}