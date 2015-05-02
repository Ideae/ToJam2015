using UnityEngine;
using System.Collections;

public class Bacteria : Animal {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //if (counter++ % 10 == 0)
            MoveRandom(gameObject);


        
    }
    int counter = 0;
    static float speed = 1f;
    public static void MoveRandom(GameObject go)
    {
        if (Random.Range(0f, 10f) > 2f) return;
        var rigid = go.GetComponent<Rigidbody2D>();
        Vector2 vel = rigid.velocity;
        //float dist = vel.magnitude;
        float num = 1f;
        float x = vel.x + Random.Range(-speed, speed) * num;
        float y = vel.y + Random.Range(-speed, speed) * num;
        vel = new Vector2(x, y);
        rigid.velocity = vel.normalized * speed;

    }
    public static void Divide(GameObject go)
    {
        GameObject next = Instantiate<GameObject>(go);
        next.transform.position = go.transform.position;
    }
}
