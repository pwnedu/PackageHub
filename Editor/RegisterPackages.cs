using UnityEditor.PackageManager;
using UnityEngine;
using UnityEditor;

namespace pwnedu.hub
{
    /// <summary>
    /// Registered Packages
    /// Triggers on install or remove package
    /// </summary>
    public class RegisteredPackages
    {
        [InitializeOnLoadMethod]
        static void SubscribeToEvent()
        {
            // This causes the method to be invoked after the Editor registers the new list of packages.
            Events.registeredPackages += RegisteredPackagesEventHandler;
        }
        
        static void RegisteredPackagesEventHandler(PackageRegistrationEventArgs packageRegistrationEventArgs)
        {
            // Code executed here can safely assume that the Editor has finished compiling the new list of packages
            Debug.Log("The list of registered packages has changed!");
            ListPackages.List();
        }
    }
}