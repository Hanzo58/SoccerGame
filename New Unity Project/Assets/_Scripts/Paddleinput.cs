using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddleinput : MonoBehaviour
{
   
        public float speed;
    public float clampValue;

    // Update is called once per frame
    void Update()
    {

      


        MovePlayer1(Input.GetAxis("Horizontal"));

    }



    public void MovePlayer1(float amountToMove)
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3(0, 0, amountToMove * speed);

        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);




        gameObject.transform.position = clampedGameObjectPosition;
        

        
       
    }
}
