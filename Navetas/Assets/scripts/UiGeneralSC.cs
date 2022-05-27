using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiGeneralSC : MonoBehaviour
{
    public GameObject Canvas;
    private void Awake()    
    {
        DontDestroyOnLoad(Canvas);
    }
}
