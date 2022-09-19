using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coba : MonoBehaviour
{
    int answer = 42;
    string greeting = "Hello, World!";
    const int speedLimit = 55;
    const double pi = 3.14159265358979323846264338327950;
    public string MyName;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("I am alive and my name is" + MyName);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
