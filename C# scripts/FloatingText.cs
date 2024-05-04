using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{   
    Transform mainCam;
    Transform unit;
    Transform canvas;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main.transform;
        unit = transform.parent;
        canvas = GameObject.FindObjectOfType<Canvas>().transform;
        transform.SetParent(canvas);
    }

    // Update is called once per frame
    void Update()
    {   
        //int procent = 1;
        transform.rotation = Quaternion.LookRotation(transform.position - mainCam.transform.position);
        transform.position = unit.position + offset;
        Vector3 razdalja = mainCam.transform.position - transform.position;
        //transform.localScale *=  procent; 
    }
}
