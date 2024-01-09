using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    private float moveSpeed = 7f;
    private float boundary = -18f;
    private PlayerControl playerControlscript;
    // Start is called before the first frame update
    void Start()
    {
        playerControlscript=GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlscript.gameover == false)
        {
            transform.Translate(Vector3.back *  moveSpeed * Time.deltaTime);
            
        }
        if (transform.position.z < boundary)
            {
                Destroy(gameObject);
            }
    }
}
