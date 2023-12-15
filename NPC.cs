using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int health = 5;
    int level = 3;
    int speed = 2;
    

    // Start is called before the first frame update
    void Start()
    {
               health = level + health;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
