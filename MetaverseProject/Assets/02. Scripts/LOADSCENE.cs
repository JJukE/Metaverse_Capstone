using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOADSCENE : MonoBehaviour
{
    // Start is called before the first frame update
    public void SCENECHANGE()
    {
        SceneManager.LoadScene("MCT_ZERO");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
