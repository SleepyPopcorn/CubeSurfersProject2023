using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineCheck : MonoBehaviour
{

    [SerializeField] private MC_CubeCountControl MC_CubeCountControl;
    // Start is called before the first frame update
    void Start()
    {
        MC_CubeCountControl = GameObject.FindObjectOfType<MC_CubeCountControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Cube")
        {
            MC_CubeCountControl.CompelteStage();
        }
    }
}
