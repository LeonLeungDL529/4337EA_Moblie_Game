using System;
    using UnityEngine;

public class SelectableCharacter : MonoBehaviour {

    public SpriteRenderer selectImage;
    public bool selected = false;

    private void Awake() 
    {
        selectImage.enabled = false;
        selected = false;
    }
    //Turns off the sprite renderer
    public void TurnOffSelector()
    {
        selectImage.enabled = false;
        selected = false;
    }
    //Turns on the sprite renderer
    public void TurnOnSelector()
    {
        selectImage.enabled = true;
        selected = true;
    }
}
