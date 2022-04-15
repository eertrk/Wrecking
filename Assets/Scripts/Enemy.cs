using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //private CharacterController enemyController;
    //public GameObject player;
    //private GameObject playerScript;
    //[SerializeField]
    //private float speed,gravity=9.8f,mass=500.0f;

    //void Start()
    //{
    //    enemyController = GetComponent<CharacterController>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    Vector3 direction = player.transform.position - transform.position;
    //    Vector3 velocity = direction * speed;

    //    enemyController.Move(velocity*Time.deltaTime);
    //}

    [SerializeField]
    private GameObject VictoryPanel, GameScreen;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Arena")
        {
            Debug.Log("victory");
            VictoryPanel.SetActive(true);
            GameScreen.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
