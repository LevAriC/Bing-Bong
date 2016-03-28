using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

    public int lives = 3;
    public int bricks = 4;
    public float resetDelay = 1f;
    public Text livesText;
  //  public GameObject gameOver;
  //  public GameObject youWon;
    public GameObject bricksPrefab;
    public GameObject paddle;
 //   public GameObject deathParticles;
    public static GM instance = null;

    private GameObject clonePaddle;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        Setup();

    }

    public void Setup()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(bricksPrefab, transform.position, Quaternion.identity);
    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void DestroyBrick()
    {
        bricks--;
        //  CheckGameOver();
    }

    /*
        void CheckGameOver()
        {
            if (bricks < 1)
            {
                youWon.SetActive(true);
                Time.timeScale = .25f;
                Invoke("Reset", resetDelay);
            }

            if (lives < 1)
            {
                gameOver.SetActive(true);
                Time.timeScale = .25f;
                Invoke("Reset", resetDelay);
            }

        }
    */

    /*
        public void LoseLife()
        {
            lives--;
            livesText.text = "Lives: " + lives;
            Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
            Destroy(clonePaddle);
            Invoke("SetupPaddle", resetDelay);
            CheckGameOver();
        }
    */

    void Reset()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("stage");

      //  Application.LoadLevel(Application.loadedLevel);
    }
}