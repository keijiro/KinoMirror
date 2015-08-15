using UnityEngine;
using UnityEditor;

public class PackageTool
{
    [MenuItem("Package/Update Package")]
    static void UpdatePackage()
    {
        AssetDatabase.ExportPackage("Assets/Kino/Mirror", "KinoMirror.unitypackage", ExportPackageOptions.Recurse);
    }
}
