using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public GameObject LevelWinning;
   
   private void OnTriggerEnter(Collider other) {
    
        LevelWinning.SetActive(true);
   }
}
