using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speed = 100;
    public float moving_speed= 300;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKey(KeyCode.X)){
            moving_speed += 10;
        }
        if(moving_speed>10 && Input.GetKey(KeyCode.C)){
            moving_speed -= 10;
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A)){
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)){
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W)){
            transform.Rotate(-Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E)){
            Quaternion targetRotation = Quaternion.Euler(transform.localEulerAngles.x, transform.localEulerAngles.y,  transform.localEulerAngles.z-1);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Q)){
            Quaternion targetRotation = Quaternion.Euler(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z+1);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, speed * Time.deltaTime);
        }
        if(Input.GetMouseButton(0)){
            transform.position += transform.forward * Time.deltaTime * moving_speed;
        }
        else if(Input.GetMouseButton(1)){
            transform.position -= transform.forward * Time.deltaTime * moving_speed;
        }
    }
}
