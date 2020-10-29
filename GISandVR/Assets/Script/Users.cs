using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Users : MonoBehaviour
{
    public float radius;
    public TextAsset CSVfile;
    public Transform marker;
    public Slider slider1;
    public Slider slider2;
    //public Button button
    private GameObject playerGameObj;

    // Use this for initialization
    void Start()
    {
        //Camera looking at
        playerGameObj = GameObject.Find("Player");


        //Set the parent GameObject
        GameObject papa = GameObject.Find("Earth");

        //Split the data into rows
        string[] myfile = CSVfile.text.Split('\n');

        //Processing for each row - each country
        for (int i = 1; i < myfile.Length; i++)
        {
            string[] each_country = myfile[i].Split(',');

            //Get the latitude and longitude from the file
            float lati = float.Parse(each_country[each_country.Length - 2]);
            float longi = float.Parse(each_country[each_country.Length - 1]);

            //Transfer to Radians from Degrees
            float templongi = longi * Mathf.PI / 180;
            float templati = lati * Mathf.PI / 180;

            //Transfer to xyz
            float Xpos = radius * Mathf.Cos(templati) * Mathf.Cos(templongi);
            float Ypos = radius * Mathf.Cos(templati) * Mathf.Sin(templongi);
            float Zpos = radius * Mathf.Sin(templati);

            //Set the X,Y,Z pos from the long and lat to position of the point, and make it become the child
            var newmarker = Instantiate(marker);
            newmarker.position = new Vector3(Xpos, Zpos, Ypos);
            newmarker.transform.SetParent(papa.transform);            

            //Set the basic values for slider 1
            slider1.minValue = 1;
            slider1.maxValue = 10;
            slider1.wholeNumbers = true;
            slider1.value = 1;

            //Process the size of the points when sliding the slider 1
            slider1.onValueChanged.AddListener(delegate { ValueChangeCheck1(each_country, newmarker); });

            //Set the basic values for slider 2
            slider2.minValue = 0;
            slider2.maxValue = 5;
            slider2.wholeNumbers = true;
            slider2.value = 5;

            //Process the size of the points when sliding the slider 2
            slider2.onValueChanged.AddListener(delegate { ValueChangeCheck2(each_country, newmarker, slider1); });

            
        }
    }

    //Create a function to change the size of the points as dates based on the slider /
    public void ValueChangeCheck1(string[] alist1, Transform m)
    {
        //Get the slider values
        int i = (int)slider1.value;

        //Create a variable named size as the number of users for each date
        float size = float.Parse(alist1[i]);

        //Categorise the size
        if (size <= 10)
        {
            m.localScale = new Vector3(0.03f, 0.03f, 0.03f);
        }
        else if ((size > 10) && (size <= 100))
        {
            m.localScale = new Vector3(0.06f, 0.06f, 0.06f);
        }
        else if ((size > 100) && (size <= 1000))
        {
            m.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
        else if ((size > 1000) && (size <= 10000))
        {
            m.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        else
        {
            m.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
    }

    public void ValueChangeCheck2(string[] alist2, Transform m, Slider slider1)
    {
        int num_size = (int)slider2.value;

        int num_date = (int)slider1.value;

        float value = float.Parse(alist2[num_date]);

        Renderer point = m.GetComponent<Renderer>();

        if (num_size == 5)
        {
            if (value <= 10)
            {
                m.localScale = new Vector3(0.03f, 0.03f, 0.03f);
                point.enabled = true;
            }
            else if ((value > 10) && (value <= 100))
            {
                m.localScale = new Vector3(0.06f, 0.06f, 0.06f);
                point.enabled = true;
            }
            else if ((value > 100) && (value <= 1000))
            {
                m.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                point.enabled = true;
            }
            else if ((value > 1000) && (value <= 10000))
            {
                m.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                point.enabled = true;
            }
            else
            {
                m.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                point.enabled = true;
            }
        }
        else if (num_size == 4)
        {
            if (value > 10000)
            {
                m.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                point.enabled = true;
            }
            else
            {
                point.enabled = false;
            }
        }
        else if (num_size == 3)
        {
            if ((value > 1000) && (value <= 10000))
            {
                m.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                point.enabled = true;
            }
            else
            {
                point.enabled = false;
            }
        }
        else if (num_size == 2)
        {
            if ((value > 100) && (value <= 1000))
            {
                m.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                point.enabled = true;
            }
            else
            {
                point.enabled = false;
            }
        }
        else if (num_size == 1)
        {
            if ((value > 10) && (value <= 100))
            {
                m.localScale = new Vector3(0.06f, 0.06f, 0.06f);
                point.enabled = true;
            }
            else
            {
                point.enabled = false;
            }
        }
        else
        {
            if (value <= 10)
            {
                m.localScale = new Vector3(0.03f, 0.03f, 0.03f);
                point.enabled = true;
            }
            else
            {
                point.enabled = false;
            }
        }

    }


    void Update()
    {
        //Rotate the earth

        //transform.Rotate(0, 0.3f, 0);
    }
}
