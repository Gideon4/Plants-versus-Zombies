using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public Texture sunimage;
    public BuildInfo[] plants;
    public static BuildInfo currentplant;
    void OnGUI(){
        GUILayout.BeginArea(new Rect(Screen.width/2-100,0,200,100));
        GUILayout.BeginHorizontal("box");

        GUILayout.Box(new GUIContent(SunCollection.score.ToString(),sunimage));
        foreach(BuildInfo bi in plants){
            GUI.enabled=SunCollection.score>=bi.price;
            if(GUILayout.Button(new GUIContent(bi.price.ToString(),bi.previewimage))){
                currentplant=bi;
            }
        }

        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
