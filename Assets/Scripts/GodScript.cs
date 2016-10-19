using UnityEngine;
using Rewired;
using System.Collections;

public class GodScript : MonoBehaviour {

    
    bool p1Ready, p2Ready, p3Ready, p4Ready;

    //Player p1, p2, p3, p4;

    int Players, PlayersReady;

    public GameObject StartButton;
    bool StartActive = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Players == PlayersReady && Players > 1)
        {
            ReadyToStartGame();
        }
        if (StartActive)
        {
            if (Players != PlayersReady)
            {
                StartButton.SetActive(false);
                StartActive = false;
            }
            for (int i = 1; i < PlayersReady + 1; i++)
            {
                if (ReInput.players.GetPlayer(i - 1).GetButtonDown("Start"))
                {
                    Debug.Log("Start Game");
                }
                if (ReInput.players.GetPlayer(i - 1).GetButtonDown("Cancel"))
                {
                    StartButton.SetActive(false);
                    StartActive = false;
                }
            }
        }
    }

    public void PlayerAdd()
    {
        Players++;
    }

    public void PlayerRemove()
    {
        Players--;
    }

    public void PlayerReadyAdd()
    {
        PlayersReady++;
    }

    public void PlayerNotReady()
    {
        PlayersReady--;
    }

    void ReadyToStartGame()
    {
        StartButton.SetActive(true);
        StartActive = true;
    }
}
