using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentLibrary : MonoBehaviour
{
    public List<Environment> m_Environments = null;
}

public class Environment
{
    public int m_WorldRotation = 0;
    public Texture m_Background = null;
    public AudioClip m_AmbientNoise = null;
}
