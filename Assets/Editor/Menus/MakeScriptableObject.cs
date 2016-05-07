﻿using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;

public class MakeScriptableObject{
	[MenuItem("Assets/Create/Sentence")]
	public static void CreateSentence(){
		Sentence sentence = ScriptableObject.CreateInstance<Sentence> ();

		string path = AssetDatabase.GetAssetPath (Selection.activeObject);
		string fileName = "Sentence.asset";

		if (File.Exists(path)) {
			path = Path.GetDirectoryName (path);
		}

		AssetDatabase.CreateAsset (sentence, AssetDatabase.GenerateUniqueAssetPath (path + "/" + fileName));
		AssetDatabase.SaveAssets ();

		EditorUtility.FocusProjectWindow ();

		Selection.activeObject = sentence;

	}

}
