using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCT_ControlPanel : MonoBehaviour
   
{        public int x, y, z;
    new Vector3 scale = Vector3.zero;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a"))
        {
            x = x + 1;
        }
        if (Input.GetKeyDown("s"))
        {
            y = y + 1;
        }
        if (Input.GetKeyDown("d"))
        {
            z = z + 1;
        }
        if (Input.GetKey("q"))
        {
            transform.localPosition = new Vector3(x, -2*y, 4*z);
            transform.localScale = new Vector3(x, y, z);

        }
        if (Input.GetKey("w"))
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}