using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public string sceneName;
    public int roundSeconds;
    public TMP_Text timer_;
    // Start is called before the first frame update
    void Start()
    {
        timer_ = GameObject.Find("Textimer").GetComponent<TMP_Text>();
        minutes = 0;
        seconds = 10;
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
            minutes = 1;
            seconds = 60;
        }
         roundSeconds = Mathf.RoundToInt(seconds);
        timer_.text = minutes.ToString() + " : " + roundSeconds.ToString();
    }
}

       

    
   



