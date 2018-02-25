using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {
    public float projectileSpeed = 0.0001f;
    public Rigidbody2D rgb;
    public float damage = 30;
    public float degreesPerSecond = 50.0f; 
    // Use this for initialization
    public void Awake()
    {
        rgb =gameObject.GetComponent<Rigidbody2D>();
        rgb.velocity = new Vector2(0, -projectileSpeed);
    }
    void Start () {
		
	}
	
    public void Crash()
    {
        print("Should be destroyed");
        Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
    public float getDamage()
    {
        return this.damage;
    }
}
