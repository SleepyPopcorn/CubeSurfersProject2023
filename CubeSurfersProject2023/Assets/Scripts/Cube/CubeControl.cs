using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private MC_CubeCountControl MC_CubeCountControl;

    private bool isStack = false;
    private Vector3 directionBack = Vector3.back;
    private Vector3 directionRight = Vector3.right;
    private Vector3 directionLeft = Vector3.left;
    private Vector3 directionFront = Vector3.forward;
    private Vector3 directionDown = Vector3.down;

    private RaycastHit raycastHit;
    void Start()
    {
        MC_CubeCountControl = GameObject.FindObjectOfType<MC_CubeCountControl>();
    }

    // Update is called once per frame
    void Update()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {           //Raycast(transform.position, directionDown, out raycastHit, 0.07f)
   
        if ((Physics.BoxCast(transform.position, transform.lossyScale / 300, directionBack, out raycastHit, transform.rotation, 0.045f)) ||
            (Physics.Raycast(transform.position, directionRight, out raycastHit, 0.05f)) ||
            (Physics.Raycast(transform.position, directionLeft, out raycastHit, 0.07f)))
        {
            if (!isStack)
            {
                isStack = true;
                MC_CubeCountControl.NewCube(gameObject);
            }
        }               //Raycast(transform.position, directionFront, out raycastHit, 0.07f)
        else if (Physics.BoxCast(transform.position, transform.lossyScale /300, directionFront, out raycastHit, transform.rotation, 0.045f))
        {
            if (raycastHit.transform.name == "cactuse")
            {
                MC_CubeCountControl.YeetCube(gameObject);
            }
        }
    }
}
