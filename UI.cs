using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class UI: MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI PointsText;
    public GameObject defeatUI;
    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PointsText.text = Player.points.ToString();
        if (player == null)
        {
            defeatUI.SetActive(true);
            restart.SetActive(true);
        }
    }
    public void OnClickRestart()
    {   int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);

    }
}
