using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DragDropHandler : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 5;
    bool gvrstatus;
    public float gvrTimer;
}
