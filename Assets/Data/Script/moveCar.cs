using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class moveCar : MonoBehaviour
{
    //speed    
   public float speed = 10.0f;
   //left right
   public float rotationspeed = 100.0f;
   void Update()
   {
       //joystick
       float translation = CrossPlatformInputManager.GetAxis("Vertical") * speed;
       float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationspeed;
       translation *= Time.deltaTime;
       rotation *= Time.deltaTime;
       transform.Translate(-translation, 0, 0);
       transform.Rotate(0, rotation, 0);       
    }
}
