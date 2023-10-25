using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOver;
    public Button restart, toMenu;



    private void Update()
    {
        scoreText.text = $"Score : {GameManager.Score}";

        if(!GameManager.isAlive)
        {
            gameOver.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            toMenu.gameObject.SetActive(true);
        }
    }
    
}
