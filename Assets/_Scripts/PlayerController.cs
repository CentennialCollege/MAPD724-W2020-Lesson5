using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera camera;
    public GameController gameController;

    [Header("Sound Effects")]
    public AudioSource yaySound;

    public AudioSource thunderSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _move();
    }

    private void _move()
    {
      Vector2 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
      transform.position = new Vector2 (Mathf.Clamp(mousePosition.x, -1.86f, 1.86f), -4.3f);
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    /* void OnCollisionEnter2D(Collision2D other)
    {
      Debug.Log("Collision!");
    } */

    private void OnTriggerEnter2D(Collider2D other)
    {
      switch(other.gameObject.tag)
      {
        case "Island":
          yaySound.Play();
          gameController.Score += 100;
        break;
        case "Cloud":
          thunderSound.Play();
          gameController.Lives -= 1;
        break;
      }
    }
}
