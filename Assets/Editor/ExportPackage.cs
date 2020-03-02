using UnityEngine;
using UnityEditor;

static class ExportPackage 
{
    [MenuItem("Tools/Export Package")]
    static void Export()
    {
        AssetDatabase.ExportPackage(
            new string[]
            {
                "Assets/Levels",
                "Assets/Resources",
                "Assets/Scenes",
                "Assets/Scripts"
            },
            "Packages\\net.peeweek.gameplay-ingredients\\StarterAssets\\GameplayIngredients-Starter-HDRP.unitypackage",
            ExportPackageOptions.Recurse);
    }
}
