using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStats : MonoBehaviour
{
    List<float> faDistance;
    List<float> faAcceleration;
    List<float> faVelocity;

    // Start is called before the first frame update
    void Start()
    {
        faDistance = new List<float>();
        faAcceleration = new List<float>();
        faVelocity = new List<float>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
