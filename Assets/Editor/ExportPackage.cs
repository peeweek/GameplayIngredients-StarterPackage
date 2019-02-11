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
                "Assets/Resources",
                "Assets/Scripts"
            },
            "GameplayIngredients-Starter-HDRP.unitypackage",
            ExportPackageOptions.Recurse);
    }
}
