using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    // Use this for initialization
    private void OnEnable()
    {
        GameManager.instance.player = GameObject.FindObjectOfType<Player>();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
