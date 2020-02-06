using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandController : MonoBehaviour
{
    public float verticalSpeed = 1.0f;
    public Boundary boundary;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      _move();
      _checkBounds();
    }

    private void _move()
    {
      transform.position -= new Vector3(0.0f, verticalSpeed, 0.0f);
    }

    private void _checkBounds()
    {
      if(transform.position.y <= boundary.lowerBounds)
      {
        _reset();
      }
    }

    private void _reset()
    {
      var xCoord = Random.Range(boundary.leftBounds, boundary.rightBounds);
      transform.position = new Vector2(xCoord, boundary.upperBounds);
    }
}
