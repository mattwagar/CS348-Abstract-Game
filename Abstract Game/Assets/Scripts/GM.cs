using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public GameObject game, startScreen, inGameCanvas, gameOverScreen;
    public Button startButton;
    public Text timerText;
    private float timer;
    private bool started;
    
    public PlayerOverlap playerOverlap;
    public Text finalTimerText;
    public Button restartButton;
    public SimpleMovement simpleMovement;
    public Transform startTransform; 
    


    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(begin);
        startScreen.SetActive(true);
        game.SetActive(false);
        inGameCanvas.SetActive(false);
        started = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            started = true;
            startScreen.SetActive(false);
            game.SetActive(true);
            inGameCanvas.SetActive(true);
        }

        if(started)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString("F2");
        }

        if(playerOverlap.GameOver)
        {
            started = false;
            Cursor.visible = true;
            game.SetActive(false);
            gameOverScreen.SetActive(true);
            restartButton.onClick.AddListener(begin);
            playerOverlap.ResetTexture();
            finalTimerText.text = "You made it "+(int)timer+" seconds";
        }

    }

    void begin(){
            playerOverlap.GameOver = false;
            timer = 0f;
            started = true;
            startScreen.SetActive(false);
            gameOverScreen.SetActive(false);
            game.SetActive(true);
            inGameCanvas.SetActive(true);
            simpleMovement.transform.position = startTransform.position;
    }
}
