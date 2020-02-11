using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    public GameObject player;
    enum EnemyState { Chase };
    EnemyState currentState;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");    
        currentState =
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
