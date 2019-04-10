using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    Engine engine;
    Chassis body;

    public Vehicle(Engine newEngine, Chassis newBody)
    {
        engine = newEngine;
        body = newBody;
    }
}
