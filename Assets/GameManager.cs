using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private PlayerController player;
    
    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        
        if (player.isAlive == false)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + player.playerScore;

    }
}
