using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    public Collider bola;
    public GameObject gameOverCanvas;
    public AudioManager audioManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            gameOverCanvas.SetActive(true);
            audioManager.StopBGM();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
