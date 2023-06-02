using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject snakeGameObject = new GameObject();
        SpriteRenderer snakeSpriteRenderer = snakeGameObject.AddComponent<SpriteRenderer>();
        snakeSpriteRenderer.sprite = GameAssets.instance.snakeHeadSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
