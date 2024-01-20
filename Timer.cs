using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds; 
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        minutes = 1;
        seconds = 60;
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0)
        {
            seconds += 60;
            minutes -= 1;
        }
        if (minutes == -1)
        {
            EditorSceneManager.LoadScene(sceneName);
            print("scene reload");
        }
 
    }
}

