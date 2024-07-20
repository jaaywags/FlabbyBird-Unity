using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleTrigger : MonoBehaviour
{
    public LogicScript logic;
    private int birdLayer = 3;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.layer == birdLayer)
        logic.AddScore(1);
    }
}
