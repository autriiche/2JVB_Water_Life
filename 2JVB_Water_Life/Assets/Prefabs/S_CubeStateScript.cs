using System;
using Unity.VisualScripting;
using UnityEngine;

public class S_CubeStateScript : MonoBehaviour
{
    public float resetTime = 2f;

    // public int unitAmountToChangeState;
    public Material state1;
    public Material state2;
    public Material state3;
    private int state = 1;
    private int unitAmount;
    private float t = 0;

    void Start()
    {
    }

    void Update()
    {
        t += Time.deltaTime;
        if (t >= resetTime && state > 1)
        {
            t = 0;
            state -= 1;
            Debug.Log(name + " state = " + state);
        }

        if (state == 1)
        {
            GetComponent<Renderer>().material = state1;
        }
        
        if (state == 2)
        {
            GetComponent<Renderer>().material = state2;
        }
        
        if (state >= 3)
        {
            GetComponent<Renderer>().material = state3;
        }
    }

    private void OnMouseDown()
    {
        t = 0;
        state += 1;
        Debug.Log(" ajout d'une unité sur " + name);
    }
}