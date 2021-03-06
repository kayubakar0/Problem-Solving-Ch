using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMouseController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    public Camera mainCamera;
    public ScoreController scoreController;

    // Header
    [Header("Ball Movement")]
    public Vector2 ballAngle = new Vector2(100, 100);
    public float speed;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        transform.Rotate(new Vector3(0, 0, 90 * Time.deltaTime));
    }

    private void Update()
    {
        Vector3 target = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        Vector3 moveAngle = target - transform.position;

         if (Vector3.Distance(target, transform.position) > 0.5)
            transform.Translate(moveAngle.normalized * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            scoreController.IncreaseCurrentScore(1);
            Destroy(collision.gameObject);
        }
    }
}
