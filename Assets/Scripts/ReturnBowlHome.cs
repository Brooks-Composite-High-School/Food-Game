using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ReturnBowlHome : MonoBehaviour
{
    Vector3 homeVector;
    Quaternion homeQuad;
    // Start is called before the first frame update
    void Start()
    {
        homeVector = transform.position;
        homeQuad = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = homeVector;
        transform.rotation = homeQuad;
    }
}
