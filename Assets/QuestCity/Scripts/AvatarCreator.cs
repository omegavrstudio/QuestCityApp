using ReadyPlayerMe.QuickStart;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarCreator : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void CreateAvatar(string url)
    {
        GameObject.FindWithTag("Player").GetComponent<ThirdPersonLoader>().LoadAvatar(url);
    }
}
