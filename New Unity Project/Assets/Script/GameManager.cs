using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int bricks = 54;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject gameover;
    public GameObject youwon;
    public GameObject brickPrefab;
    public GameObject paddle;
    public GameObject DeathParticles;
    public GameObject Coin;
    public Camerashake camerashake;

    public static GameManager instance = null;
    private GameObject clonePaddle;

    // Start is called before the first frame update
    void Start()
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
        Instantiate(brickPrefab, transform.position, Quaternion.identity);
        Instantiate(Coin, transform.position, Quaternion.identity);
    }

    void CheckGameOver()
    {
        if (bricks < 1)
        {
            youwon.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        
        }
        if (lives < 1)
        {
            gameover.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }
    }

    private void Reset()
    {
        Time.timeScale = 1f;
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(Application.loadedLevel);
#pragma warning restore CS0618 // Type or member is obsolete
    }
   public void LoseLife()
    {
        lives--;
        livesText.text = "Lives:" +lives;
        Instantiate(DeathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupPaddle", resetDelay);
        CheckGameOver();
    }
    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle,transform.position, Quaternion.identity) as GameObject;
    }
     public void DestroyBrick() {
        bricks--;
        StartCoroutine(camerashake.Shake(.15f, .3f));
        CheckGameOver();
    }

 
}
