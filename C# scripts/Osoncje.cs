using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Osoncje : MonoBehaviour
{   
    public float G = 10f;
    GameObject[] vesoljskaTelesa; 

    void Start()
    {
        vesoljskaTelesa = GameObject.FindGameObjectsWithTag("VesoljskoTelo");
        ZacetnaHitrost();
    }

    void FixedUpdate()
    {
        Gravitacija();
    }

    void Gravitacija()
    {
        foreach(GameObject prvi in vesoljskaTelesa){
            foreach(GameObject  drugi in vesoljskaTelesa){
                if(!prvi.Equals(drugi)){
                    float masaPrvi = prvi.GetComponent<Rigidbody>().mass;
                    float masaDrugi = drugi.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(prvi.transform.position,drugi.transform.position);

                    prvi.GetComponent<Rigidbody>().AddForce((drugi.transform.position-prvi.transform.position).normalized * (G * (masaDrugi*masaPrvi)/(r*r)));
                }
            }
        }
    }
    void ZacetnaHitrost(){
        foreach(GameObject prvi in vesoljskaTelesa){
            foreach(GameObject  drugi in vesoljskaTelesa){
                if(!prvi.Equals(drugi)){
                    float masaDrugi = drugi.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(prvi.transform.position,drugi.transform.position);
                    prvi.transform.LookAt(drugi.transform);

                    //prvi.GetComponent<Rigidbody>().velocity += prvi.transform.right * Mathf.Sqrt((G*masaDrugi)/r);
                    prvi.GetComponent<Rigidbody>().velocity += prvi.transform.right * Mathf.Sqrt((G*masaDrugi) * ((2 / r) - (1 / (r * 1.5f))));
                }
            }
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {   
        /*
        if(Input.GetKey(KeyCode.R)){
            Time.timeScale += 0.1f;
        }
        if(Time.timeScale>0.1 && Input.GetKey(KeyCode.T)){
            Time.timeScale -= 0.1f;
        }
        */
    }
}
