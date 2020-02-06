using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public Transform cloudContainer;
  public int cloudNum;
  public GameObject cloud;

  public List<GameObject> clouds;
    // Start is called before the first frame update
    void Start()
    {
      clouds = new List<GameObject>(); // empty list of type GameObject
      _buildCloudList();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void _buildCloudList()
    {
      for (int count = 0; count < cloudNum; count++)
      {
          var newCloud = Instantiate(cloud);
          newCloud.transform.parent = cloudContainer.transform;
          clouds.Add(newCloud);
      }
    }
}
