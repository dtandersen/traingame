using UnityEngine;
using System.Collections;
using Savoa;

public class EngineRunner : MonoBehaviour
{
    public Engine engine = new Engine();

    void Start()
    {
        engine.AddSystem(new CubeSystem());
    }

    void Update()
    {
        engine.Process();
        //Debug.Log("update");
    }
}