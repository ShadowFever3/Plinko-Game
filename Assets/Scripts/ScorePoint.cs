using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoint : MonoBehaviour
{


    [SerializeField]
    int scoreValue;
    [SerializeField]
    Text t;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        Destroy(collision.gameObject, 3f);
        ScoreManager.isActive = false;
        ScoreManager.playersScore += scoreValue;
        t.text = ScoreManager.playersScore.ToString();
        
    }
    
}
