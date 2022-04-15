using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOver,GameScreen;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Arena")
        {
            Debug.Log("gameover");
            GameOver.SetActive(true);           
            GameScreen.SetActive(false);
        }
    }
}
