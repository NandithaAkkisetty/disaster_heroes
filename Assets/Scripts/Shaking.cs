// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Shaking : MonoBehaviour
// {
//     public bool start = false;
//     public AnimationCurve curve;
//     public float duration = 1f;
//     void Update() {
//         if (start) {
//             start = false;
//             StartCoroutine (Shakingg());
//         }
//     }
//     IEnumerator Shakingg() {
//         float elapsedTime = 0f;
//         while (elapsedTime < duration) {
//             Vector3 position = transform.position;
//             elapsedTime = elapsedTime + Time.deltaTime;
//             transform.position= position + Random. insideUnitSphere;
//             yield return null;
//         }
//         transform.position = position;
//     }
// }
