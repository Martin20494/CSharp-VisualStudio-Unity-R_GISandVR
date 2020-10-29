using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change(float f)
    {
        if (f == 0)
        {
            GetComponent<Text>().text = "Week before quarantine";
        }
        if (f == 10)
        {
            GetComponent<Text>().text = "Week after quarantine";
        }
        else
        {
            GetComponent<Text>().text = "Week " + (f-1).ToString() + " in quarantine";
        }
        
    }
}
