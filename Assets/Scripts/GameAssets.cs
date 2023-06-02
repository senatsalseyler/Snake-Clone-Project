using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    public Sprite snakeHeadSprite;

    public static GameAssets instance;
    
    private void Awake()
    {
        instance = this;

    }
}
