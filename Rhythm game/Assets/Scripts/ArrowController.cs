using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public GameObject pressButton;
    public KeyCode KeyToPress;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyToPress))
        {
            theSR.sprite = pressedImage;
        }

        if(Input.GetKeyUp(KeyToPress))
        {
            theSR.sprite = defaultImage;
        }
    }
    // Used for mobile touch controlls
    void OnMouseDown()
    {
        theSR.sprite = pressedImage;
    }

    void OnMouseUp()
    {
        theSR.sprite = defaultImage;
    }
}
