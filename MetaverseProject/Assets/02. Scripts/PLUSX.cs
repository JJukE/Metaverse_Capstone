using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngineInternal;



public class PLUSX : MonoBehaviour
{
    public UnityEvent OnPressed;

    public GameObject PLUSXS;
    public GameObject GREENX;
    public GameObject TABLEANI;
    public bool XZERO;
    // Start is called before the first frame update
    void Start()
    {
       PLUSXS = GameObject.Find("MCT_ControlPanelMinusX");
       GREENX = GameObject.Find("MCT_ControlPanelLightX");
       TABLEANI = GameObject.Find("MCT_Table_1");

        if (XZERO == true)
        {
            GREENX.GetComponent<Renderer>().material.color = Color.green;
            TABLEANI.GetComponent<Animation>().Play("TABLEZERO");
            
        }
            
    }

    // Update is called once per frame
    private void Onpressed()
    {
        XZERO = true; 
    }
}
