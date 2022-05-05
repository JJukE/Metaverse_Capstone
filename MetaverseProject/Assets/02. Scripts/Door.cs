using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public bool isdooropen = false;
    Button button;
    GameObject leftdoor;
    GameObject rightdoor;

    public void OnButtonDoor()
    {
        //Debug.Log("buttondoor on");
        if(isdooropen == false)
        {
            leftdoor.GetComponent<Transform>().Translate(-1, 0, 0);
            rightdoor.GetComponent<Transform>().Translate(1, 0, 0);
            isdooropen = true;
        }
        else 
        {
            leftdoor.GetComponent<Transform>().Translate(1, 0, 0);
            rightdoor.GetComponent<Transform>().Translate(-1, 0, 0);
            isdooropen = false; 
        }
        //Debug.Log(isdooropen);
    }
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonDoor);
        leftdoor = GameObject.Find("MCT - LeftDoor-1");
        rightdoor = GameObject.Find("MCT - RightDoor-1");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
