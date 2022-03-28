using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;
public class CountDownTimer : MonoBehaviour
{
    public float currentTime = 1;
    public float startTime = 100f;
    [SerializeField] Text CountDown;

    public TextMeshProUGUI gameOverText;
    //public Button restating;
    bool restart = false;
    private void Start()
    {
        currentTime = startTime;
        
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountDown.text = "CountDown:  " + currentTime.ToString("0");
        
        if(currentTime <= 0)
        {
            currentTime = 0;
        }
        GameOver();
    }
    public void GameOver()
    {
        if (currentTime == 0)
        {
            gameOverText.gameObject.SetActive(true);
            restart = true;
        }
    }

    public void RestartGame()
    {
        //restating.gameObject.SetActive(true);
        if (restart)
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
