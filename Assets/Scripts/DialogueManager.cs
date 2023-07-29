// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DialogueManager : MonoBehaviour
// {
//     public Text textDisplay;
//     public GameObject[] buttons;
//     private JsonData dialogues;
//     private int index;
//     private string speaker;
//     private bool inDialogue;
//     public bool loadDialogue(string path){
//         if(!inDialogue){
//             index = 0;
//             var jsonTextFile = Resources.load<TextAsset>["Dialogues/" + path];
//             dialogue = JsonMapper.ToObject(jsonTextFile.text);
//             inDialogue = true;
//             return true;
//         }
//         return false;
//     }
//     public bool printLine(){
//         if(inDialogue){
//             JsonData Line = dialogue[index];
//             if (Line[0].ToString() == "EOD"){
//                 inDialogue = false;
//                 textDisplay.text = "";
//                 return false;
//             }
//             foreach (JsonData key in Line.keys)
//                 speaker = key.ToString();
//             textDisplay.text = speaker; + ":"= dialogue[index][0].ToString();
//             index++;
//             }
//     }
    
// }

