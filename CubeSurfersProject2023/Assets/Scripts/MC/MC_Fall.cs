using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_Fall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private MC_CubeCountControl MC_CubeCountControl;
    [SerializeField] private Ragdoller ragdoller;
    [SerializeField] private Animation animator;
    void Start()
    {
        MC_CubeCountControl = GameObject.FindObjectOfType<MC_CubeCountControl>();
        ragdoller = GameObject.FindObjectOfType<Ragdoller>();
        animator = GameObject.FindObjectOfType<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fall ()
    {
        MC_CubeCountControl.StopTheCharacter(gameObject);
        animator.enabled = false;
        ragdoller.EnableRagdoll();
    }

}
