using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public bool isGameOver = false;
    public AudioSource gameOver;
    public AudioClip startAgain;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
        gameOver = GetComponent<AudioSource>();


    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        isGameOver = true;
        gameOver.Play();
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    
        
            
    


    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                
                Time.timeScale = 1;
                gameOverCanvas.SetActive(false);
                gameOver.PlayOneShot(startAgain, 1.0f);
                Application.LoadLevel(0);
               
            }
        } 
        
}
    }  
