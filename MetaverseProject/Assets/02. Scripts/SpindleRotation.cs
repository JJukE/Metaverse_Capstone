using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpindleRotation : MonoBehaviour
{
    public bool isrotate = false;
    GameObject Spindle, button1, button2;
    Button onbutton, offbutton;

    // Start is called before the first frame update
    void Start()
    {
        button1 = GameObject.Find("Button__SpindleOn");
        onbutton = button1.GetComponent<Button>();
        onbutton.onClick.AddListener(ButtonOn);

        button2 = GameObject.Find("Button__SpindleOff");
        offbutton = button2.GetComponent<Button>();
        offbutton.onClick.AddListener(ButtonOff);

        Spindle = GameObject.Find("SpindlePivot");
    }

    // Update is called once per frame
    void Update()
    {
        if (isrotate == false)
        {
            Spindle.transform.Rotate(0f, 0f, 0f);
        }
        if (isrotate == true)
        {
            Spindle.transform.Rotate(0f, Time.deltaTime * 18000f, 0f);
        }
    }

    public void ButtonOn()
    {
        if (isrotate == false)
        {
            isrotate = true;
        }
    }

    public void ButtonOff()
    {
        if (isrotate == true)
        {
            isrotate = false;
        }
    }
}
