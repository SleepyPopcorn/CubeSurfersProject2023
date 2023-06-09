using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_GameOver : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private MC_Fall MC_Fall;
    public GameOverButtons GameOverButtons;

    private Vector3 directionFront = Vector3.forward;

    private RaycastHit raycastHit;
    void Start()
    {
        MC_Fall = GameObject.FindObjectOfType<MC_Fall>();
    }

    // Update is called once per frame
    void Update()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {
        if (Physics.BoxCast(transform.position, transform.lossyScale /300, directionFront, out raycastHit, transform.rotation, 0.045f))
        {
            if (raycastHit.transform.name == "cactuse")
            {
                ScoreManager.instance.SetCubeScore();
                MC_Fall.Fall();
                GameOverButtons.Activate();
            }
        }
    }
}
