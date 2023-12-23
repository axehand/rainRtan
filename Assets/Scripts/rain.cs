using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{

    int type;
    int score;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(3.0f, 5.0f);
        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 5);

        if(type == 1)
        {
            size = 1.2f;
            score = 3;
            GetComponent<SpriteRenderer>().color = new Color(100 / 255f, 100 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type == 2)
        {
            size = 1.0f;
            score = 2;
            GetComponent<SpriteRenderer>().color = new Color(130 / 255f, 130 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type == 3)
        {
            size = 0.8f;
            score = 1;
            GetComponent<SpriteRenderer>().color = new Color(160 / 255f, 160 / 255f, 255 / 255f, 255 / 255f);
        }
        else
        {
            size = 0.8f;
            score = -5;
            GetComponent<SpriteRenderer>().color = new Color(255 / 255.0f, 100.0f / 255.0f, 100.0f / 255.0f, 255.0f / 255.0f);
        }
        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }
        if(coll.gameObject.tag == "rtan")
        {
            Destroy(gameObject);
            gameManager.I.addScore(score);
        }
    }

}
