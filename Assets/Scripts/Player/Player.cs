using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //handle Inputs
    public void aPress()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 1);
    }
    public void bPress()
    {

    }
    public void upPress()
    {

    }
    public void downPress()
    {
    }
    public void leftPress()
    {
        transform.position = new Vector2(transform.position.x - moveSpeed, transform.position.y);
    }
    public void rightPress()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed, transform.position.y);
    }
    public void startPress()
    {

    }
}
