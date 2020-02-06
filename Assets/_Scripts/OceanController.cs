using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController : MonoBehaviour
{
  public float verticalSpeed = 0.05f;
  public Boundary boundary;

    // Start is called before the first frame update
    void Start()
    {
      boundary.upperBounds = 9.4f;
      boundary.lowerBounds = -9.4f;
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
      transform.position = new Vector2(0.0f, boundary.upperBounds);
    }
}
