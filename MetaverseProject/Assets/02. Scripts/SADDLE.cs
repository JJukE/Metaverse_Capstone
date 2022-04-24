using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SADDLE : MonoBehaviour

{
    public int x, y, z;
    new Vector3 scale = Vector3.zero;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            x = x + 1;
        }
        if (Input.GetKeyDown("2"))
        {
            y = y + 1;
        }
        if (Input.GetKeyDown("3"))
        {
            z = z + 1;
        }
        if (Input.GetKey("4"))
        {
            transform.localPosition = new Vector3(x, y, z);
            transform.localScale = new Vector3(100+x, 100+y, 100+z);

        }
        if (Input.GetKey("5"))
        {
            transform.localScale = new Vector3(100, 100, 100);
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}