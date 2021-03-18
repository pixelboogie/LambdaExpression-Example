using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lambda : MonoBehaviour
{

    public delegate void TestDelegate();
    private TestDelegate testDelegateFunction;

    void Start()
    {
        testDelegateFunction = () => { Debug.Log("Lambda Expression"); };
        testDelegateFunction();
    }
}
