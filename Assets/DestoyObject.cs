using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyObject : MonoBehaviour
{

    private GameObject Unitychan;

    // Use this for initialization
    void Start()
    {
        this.Unitychan = GameObject.Find("unitychan");
    }
        // Update is called once per frame
        void Update()
        {

            if (Unitychan.transform.position.z  > this.transform.position.z)
            {
          
                Destroy(this.gameObject,2f);
            
            }
        }
    }





