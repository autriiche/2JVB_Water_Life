using UnityEngine;

public class S_CubeStateScript : MonoBehaviour
{
    public int resetTime;
    // public int unitAmountToChangeState;
    // public Material state1;
    // public Material state2;
    // public Material state3;
    private int state = 3;
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
            state -= 1;
            Debug.Log(name + " state = " + state);

        }
    }
}
