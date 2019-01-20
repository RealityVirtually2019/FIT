using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchPressure : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    public void Pressure()
    {

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).pressure <= 0.66f)
            {
                //gameObject.GetComponent<Image> ().color = Color.red;
                print("ok");
            }
        }
    }
}