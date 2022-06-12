using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZEROANI : MonoBehaviour
{

    public bool OnClick;

    // Start is called before the first frame update
    void Start()
    {
        {
            GetComponent<Animation>().Play("TABLEZERO");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
