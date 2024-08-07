using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
      if (LogicScript.isGameStarted && birdIsAlive && Input.GetKeyDown(KeyCode.Space))
        myRigidbody.velocity = Vector2.up * flapStrength;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
      logic.GameOver();
      birdIsAlive = false;
    }
}
