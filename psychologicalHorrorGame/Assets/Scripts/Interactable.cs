using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public virtual void Amake()
    {
        gameObject.layer = 6;
    }
    public abstract void OnInteract();
    public abstract void OnFocus(); 
    public abstract void OnLoseFocus();
}
