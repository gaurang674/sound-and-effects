using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnObstacle : MonoBehaviour
{
    public PlayerControl PlayerControl;
    Vector3 position = new Vector3(0, 0, 20);
    int range;
    public GameObject[] obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 1.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        if (PlayerControl.gameover==false)
        {
            range = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[range], position, Quaternion.identity);
        }
    }
}
