using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public StopWatch time;
    public RoutePoint finishPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (finishPoint.isActiveForPlayer)
        {
            if (other.tag = "Player")
            {
                time.hasFinished = true;
            }
        }
    }
}
