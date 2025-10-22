using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using static UnityEngine.Random;

public class S_StateChanger : MonoBehaviour //, IPointerDownHandler
{
    private Camera _mainCamera;
    public GameObject cube_downleft;
    public GameObject cube_down;
    public GameObject cube_downright;
    public GameObject cube_left;
    public GameObject cube_right;
    public GameObject cube_topleft;
    public GameObject cube_top;
    public GameObject cube_topright;
    public Material mState_0;
    public Material mState_1;
    public Material mState_2;
    public Material mState_3;
    public Material mState_4;
    public S_CubeStateScript StateScript;
    private int state;
    private InputAction leftMouseClick;
    private bool waterDistrib;
    private static int water = 50; // stock d’eau total partagé par tous les cubes


    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    Debug.Log(eventData.pointerId);
    //    if (eventData.pointerId == -1) //left click
    //    {
    //        state--;
    //    }

    //    else if (eventData.pointerId == -2) //right click
    //    {
    //        state++;
    //    }
    //    StateChanger(state);
    //}
    public void StateChanger(int state, bool waterDistrib)
    {
        if (waterDistrib == true)
        {
            state++;
        }

        else
        {
            state--;
        }

        //Debug.Log(name + state);
        if (state <= 0)
        {
            GetComponent<MeshRenderer>().material = mState_0;
            state = 0;
        }

        else if (state == 1)
        {
            GetComponent<MeshRenderer>().material = mState_1;
        }

        else if (state == 2)
        {
            GetComponent<MeshRenderer>().material = mState_2;
        }

        else if (state == 3)
        {
            GetComponent<MeshRenderer>().material = mState_3;
        }
        else
        {
            GetComponent<MeshRenderer>().material = mState_4;
            state = 4;
        }
    }

    public void NearbyStateChanger(bool waterDistrib)
    {
        if (waterDistrib == false)
        {
            if (cube_downleft.GetComponent<S_StateChanger>().state > 0)
            {
                cube_downleft.GetComponent<S_StateChanger>().StateChanger(
                    cube_downleft.GetComponent<S_StateChanger>().state--,
                    cube_downleft.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_down.GetComponent<S_StateChanger>().state > 0)
            {
                cube_down.GetComponent<S_StateChanger>().StateChanger(cube_down.GetComponent<S_StateChanger>().state--,
                    cube_down.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_downright.GetComponent<S_StateChanger>().state > 0)
            {
                cube_downright.GetComponent<S_StateChanger>().StateChanger(
                    cube_downright.GetComponent<S_StateChanger>().state--,
                    cube_downright.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_left.GetComponent<S_StateChanger>().state > 0)
            {
                cube_left.GetComponent<S_StateChanger>().StateChanger(cube_left.GetComponent<S_StateChanger>().state--,
                    cube_left.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_right.GetComponent<S_StateChanger>().state > 0)
            {
                cube_right.GetComponent<S_StateChanger>().StateChanger(
                    cube_right.GetComponent<S_StateChanger>().state--,
                    cube_right.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_topleft.GetComponent<S_StateChanger>().state > 0)
            {
                cube_topleft.GetComponent<S_StateChanger>().StateChanger(
                    cube_topleft.GetComponent<S_StateChanger>().state--,
                    cube_topleft.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_top.GetComponent<S_StateChanger>().state > 0)
            {
                cube_top.GetComponent<S_StateChanger>().StateChanger(cube_top.GetComponent<S_StateChanger>().state--,
                    cube_top.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_topright.GetComponent<S_StateChanger>().state > 0)
            {
                cube_topright.GetComponent<S_StateChanger>().StateChanger(
                    cube_topright.GetComponent<S_StateChanger>().state--,
                    cube_topright.GetComponent<S_StateChanger>().waterDistrib);
            }
        }

        else
        {
            if (cube_downleft.GetComponent<S_StateChanger>().state < 4)
            {
                cube_downleft.GetComponent<S_StateChanger>().StateChanger(
                    cube_downleft.GetComponent<S_StateChanger>().state++,
                    cube_downleft.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_down.GetComponent<S_StateChanger>().state < 4)
            {
                cube_down.GetComponent<S_StateChanger>().StateChanger(cube_down.GetComponent<S_StateChanger>().state++,
                    cube_down.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_downright.GetComponent<S_StateChanger>().state < 4)
            {
                cube_downright.GetComponent<S_StateChanger>().StateChanger(
                    cube_downright.GetComponent<S_StateChanger>().state++,
                    cube_downright.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_left.GetComponent<S_StateChanger>().state < 4)
            {
                cube_left.GetComponent<S_StateChanger>().StateChanger(cube_left.GetComponent<S_StateChanger>().state++,
                    cube_left.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_right.GetComponent<S_StateChanger>().state < 4)
            {
                cube_right.GetComponent<S_StateChanger>().StateChanger(
                    cube_right.GetComponent<S_StateChanger>().state++,
                    cube_right.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_topleft.GetComponent<S_StateChanger>().state < 4)
            {
                cube_topleft.GetComponent<S_StateChanger>().StateChanger(
                    cube_topleft.GetComponent<S_StateChanger>().state++,
                    cube_topleft.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_top.GetComponent<S_StateChanger>().state < 4)
            {
                cube_top.GetComponent<S_StateChanger>().StateChanger(cube_top.GetComponent<S_StateChanger>().state++,
                    cube_top.GetComponent<S_StateChanger>().waterDistrib);
            }

            if (cube_topright.GetComponent<S_StateChanger>().state < 4)
            {
                cube_topright.GetComponent<S_StateChanger>().StateChanger(
                    cube_topright.GetComponent<S_StateChanger>().state++,
                    cube_topright.GetComponent<S_StateChanger>().waterDistrib);
            }
        }
    }

    void Start()
    {
        _mainCamera = Camera.main;
        state = StateScript.state;
        if (state == 0)
        {
            GetComponent<MeshRenderer>().material = mState_0;
        }

        else if (state == 1)
        {
            GetComponent<MeshRenderer>().material = mState_1;
        }

        else if (state == 2)
        {
            GetComponent<MeshRenderer>().material = mState_2;
        }

        else if (state == 3)
        {
            GetComponent<MeshRenderer>().material = mState_3;
        }

        else
        {
            GetComponent<MeshRenderer>().material = mState_4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _mainCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.position == transform.position)
                {
                    int refund = 0;
                    if (state > 0) refund += 2; 
                    if (cube_downleft.GetComponent<S_StateChanger>().state > 0) refund++;
                    if (cube_down.GetComponent<S_StateChanger>().state > 0) refund++;
                    if (cube_downright.GetComponent<S_StateChanger>().state > 0) refund++;
                    if (cube_left.GetComponent<S_StateChanger>().state > 0) refund++;
                    if (cube_right.GetComponent<S_StateChanger>().state > 0) refund++;
                    if (cube_topleft.GetComponent<S_StateChanger>().state > 0) refund++;
                    if (cube_top.GetComponent<S_StateChanger>().state > 0) refund++;
                    if (cube_topright.GetComponent<S_StateChanger>().state > 0) refund++;

                    water += refund;
                    Debug.Log("Il te reste " + water + " unités d'eau.");
                    
                    if (state > 0)
                    {
                        waterDistrib = false;
                        state--;
                        StateChanger(state, waterDistrib);
                        NearbyStateChanger(waterDistrib);
                    }
                    else if (state == 0)
                    {
                        waterDistrib = false;
                        NearbyStateChanger(waterDistrib);
                    }
                }
            }
        }


        else if (Input.GetMouseButtonDown(1))
        {
            Ray ray = _mainCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.position == transform.position)
                {
                    int cost = 2;
                    if (cube_downleft.GetComponent<S_StateChanger>().state < 4) cost++;
                    if (cube_down.GetComponent<S_StateChanger>().state < 4) cost++;
                    if (cube_downright.GetComponent<S_StateChanger>().state < 4) cost++;
                    if (cube_left.GetComponent<S_StateChanger>().state < 4) cost++;
                    if (cube_right.GetComponent<S_StateChanger>().state < 4) cost++;
                    if (cube_topleft.GetComponent<S_StateChanger>().state < 4) cost++;
                    if (cube_top.GetComponent<S_StateChanger>().state < 4) cost++;
                    if (cube_topright.GetComponent<S_StateChanger>().state < 4) cost++;

                    if (water < cost)
                    {
                        Debug.Log("Pas assez d'eau ! (" + water + " unités restantes, besoin de " + cost + ")");
                        return;
                    }

                    water -= cost;
                    Debug.Log("Il te reste " + water + " unités d'eau.");
                    
                    if (state < 4)
                    {
                        waterDistrib = true;
                        state++;
                        StateChanger(state, waterDistrib);
                        NearbyStateChanger(waterDistrib);
                    }
                    else if (state == 4)
                    {
                        waterDistrib = true;
                        NearbyStateChanger(waterDistrib);
                    }
                }
            }
        }
    }
}