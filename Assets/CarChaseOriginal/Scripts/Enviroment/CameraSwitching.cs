using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    // Start is called before the first frame update
    
    public void SwitchCam(int x)
    {
        deactivateall();
        if(x == 1 )
        {
            cam1.enabled = true;
        }
        else
        {
            cam2.enabled = true;
        }
    }

    public void deactivateall()
    {
        cam1.enabled = false;
        cam2.enabled = false;
    }
}
