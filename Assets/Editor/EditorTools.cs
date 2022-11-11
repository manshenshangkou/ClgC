using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorTools : Editor
{
    [MenuItem("CustomEditorTools/Creat/CreatTexturesAssetsStoreObject")]
    public static void CreatTexturesAssetsStoreObject()
    {
        TexturesAssetsStore asset = ScriptableObject.CreateInstance<TexturesAssetsStore>();
        AssetDatabase.CreateAsset(asset, "Assets/TexturesAssetsStore.asset");
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
}
