using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public GameObject game, startScreen;
    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(begin);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            startScreen.SetActive(false);
            game.SetActive(true);
        }
    }

    void begin(){
            startScreen.SetActive(false);
            game.SetActive(true);
    }
}
