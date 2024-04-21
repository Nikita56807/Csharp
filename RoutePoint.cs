using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutePoint : MonoBehaviour
{
    public RoutePoint nextPoint;
    public GameObject model;
    public bool isActiveForPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (collision.tag == "Checkpoint")
        {
            if (isActiveForPlayer);
            model.SetActive(false);
            isActiveForPlayer = false;
            if (nextPoint != null)
            {
                nextPoint.isActiveForPlayer = true;
                nextPoint.model.SetActive(true);
            }
        }
    }
}
