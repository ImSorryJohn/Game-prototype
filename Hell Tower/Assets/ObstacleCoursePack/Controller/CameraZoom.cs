using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.Axis ("Mouse ScrollWheel") > 0)
        {
            Get.Component<Camera>().CameraDist--;
        }

        if (Input.Axis("Mouse ScrollWheel") < 0)
        {
            Get.Component<Camera>().CameraDist++;
        }

    }
}
