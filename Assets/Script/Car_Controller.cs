using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Controller : MonoBehaviour
{
   
  

    void Update()
    {
       

            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime*20);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.back * Time.deltaTime*20);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Rotate(Vector3.up, -1);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Rotate(Vector3.up, 1);
            }

        



    }
}
        
