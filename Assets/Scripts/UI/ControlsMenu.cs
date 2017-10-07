using UnityEngine;
using System.Collections;

public class ControlsMenu : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void rebindControl(int index, KeyCode key)
    {
        GameManager.instance.inman.rebindControl(index, key);
    }
}
