using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    GameObject Player;
    GameObject Proj;
    Character PlayerCharacterScript;
    bool playerFacingRight;
    public float velocity;

    SpriteRenderer projRender;

    float projCenterXBound;
    float projCenterYBound;
    float projMinX;
    float projMaxX;
    float projMinY;
    float projMaxY;

    public BoxCollider2D projCollider;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector2(velocity,0));//new Vector3(projVelocity, 0, 0));
        if (transform.position.x < -10 || transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Ares" || collision.gameObject.name == "Zeus")
        {
            Destroy(gameObject);
        }
    }
}
