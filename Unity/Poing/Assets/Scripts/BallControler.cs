using UnityEngine;
using System.Collections;

public class BallControler : MonoBehaviour {
    public BoxCollider2D player1Collider;
    public BoxCollider2D player2Collider;
    public BoxCollider2D goal1Collider;
    public BoxCollider2D goal2Collider;
    public GameObject ball;
    private float yPower = 1.0f;
    private float xPower = 0.5f;
    private Vector2 constantVelocity;

    void Start() {
        xPower = Random.Range(-0.9f, 0.9f);
        constantVelocity = new Vector2(xPower, yPower);
    }

	void Update () {
        GetComponent<Rigidbody2D>().velocity = constantVelocity;
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if (GetComponent<CircleCollider2D>().IsTouching(player1Collider)) {
            yPower = 1.0f;
        }
        if (GetComponent<CircleCollider2D>().IsTouching(player2Collider)) {
            yPower = -1.0f;
        }
        if (transform.position.x > 2.47f) {
            xPower = Random.Range(-1.0f, -0.2f);
        }
        if (transform.position.x < 2.47f) {
            xPower = Random.Range(0.2f, 1.0f);
        }
        if (GetComponent<CircleCollider2D>().IsTouching(goal1Collider)) {
            EndRound(goal1Collider);
        }
        if (GetComponent<CircleCollider2D>().IsTouching(goal2Collider)) {
            EndRound(goal2Collider);
        }
        
        constantVelocity = new Vector2(xPower, yPower);
    }

    void EndRound (BoxCollider2D goalLine) {
        Destroy(ball);
        GameObject newBall = GameObject.Instantiate(ball) as GameObject;
    }
}
