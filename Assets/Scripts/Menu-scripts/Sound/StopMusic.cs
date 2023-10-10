using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    void Start()
    {
        //Debug.LogError("Sound settings still don't work!");
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
    }
}
