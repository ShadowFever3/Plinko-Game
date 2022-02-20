using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField]
    public GameObject ball;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(ScoreManager.isActive != true)
            {
                Instantiate(ball);    
                ScoreManager.isActive = true;
            }
            
            
        }
    }
}
