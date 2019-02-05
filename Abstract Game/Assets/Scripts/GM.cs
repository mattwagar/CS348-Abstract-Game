using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public GameObject game, startScreen, inGameCanvas;
    public Button startButton;
    public Text timerText;
    private float timer;
    private bool started;

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

    }

    void begin(){
            started = true;
            startScreen.SetActive(false);
            game.SetActive(true);
            inGameCanvas.SetActive(true);
    }
}
