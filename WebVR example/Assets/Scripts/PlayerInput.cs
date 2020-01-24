using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public static UnityEvent OnTouchStart = new UnityEvent();
    public static UnityEvent OnTouchEnd = new UnityEvent();

    public static UnityEvent OnTouchpadLeftUp = new UnityEvent();
    public static UnityEvent OnTouchpadRightUp = new UnityEvent();

    private void Update()
    {
        VrInput();
    }

    private void VrInput()
    {
        
    }
}
