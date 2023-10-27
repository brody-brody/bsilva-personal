using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TimerScript _timer;
    public GameObject _gameOverParent;

    // Update is called once per frame
    void Update()
    {
        if(_timer.timer <= 0){
            _gameOverParent.SetActive(true);
        }
    }
}
