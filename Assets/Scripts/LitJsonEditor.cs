// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LitJsonEditor : MonoBehaviour
// {
//     public Text textDisplay;
//     private JsonData dialogue;
//     private int index;
//     private string speaker;
//     private void loadDialogue(string path){
//         index = 0;
//         var jsonTextFile = Resources.load<TextAsset>["Dialogues/" + path];
//         dialogue = JsonMapper.ToObject(jsonTextFile.text);
//     }
//     private void printLine(){
//         JsonData Line = dialogue[index];
//         foreach (JsonData key in Line.keys)
//            speaker = key.ToString();
//         textDisplay.text = speaker; + ":"= dialogue[index][0].ToString();
//         index++;
//     }
//     void start() {
//         loadDialogue("");
//     }
//     void Update(){
//         if(Input.GetKeyDown(keyCode.C))
//         printLine();
//     }
// }

