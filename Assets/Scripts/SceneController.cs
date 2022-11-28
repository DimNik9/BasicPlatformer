using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject banana;
    private GameObject bananaScene;
    private int prevIndex = 0;
    private Vector2[] coords =
    {
        new Vector2(2f,0.79f), new Vector2(-1.5f,1.23f), new Vector2(3.36f,-0.41f), new Vector2(-5.52f,1.56f)
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bananaScene == null)
        {
            int newIndex = Random.RandomRange(0, coords.Length);
            bananaScene = Instantiate(banana) as GameObject;
            bananaScene.transform.position = coords[newIndex];
        }
    }
}
