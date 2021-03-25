using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeToggle : MonoBehaviour{

public Camera cam1;
public Camera cam2;
//public MonoBehaviour moveScript1;
//public MonoBehaviour moveScript2;
 
 void Start(){
     cam1.enabled = false;
     cam2.enabled = true;
     GetComponent<FP_Movement>().enabled = false;
     GetComponent<TP_Movement>().enabled = true;

 }
 
 void Update(){
 
     if (Input.GetButtonDown("Fire2")) {
         cam1.enabled = !cam1.enabled;
         GetComponent<FP_Movement>().enabled = !cam1.enabled;
         //moveScript1.enabled = !moveScript1.enabled;
         cam2.enabled = !cam2.enabled;
         GetComponent<TP_Movement>().enabled = !cam2.enabled;
        // moveScript2.enabled = !movescript2.enabled;
     }
 }

}