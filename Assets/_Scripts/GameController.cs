using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameController : MonoBehaviour
{
  [Header("Cloud Configuration")]
  public Transform cloudContainer;
  public int cloudNum;
  public GameObject cloud;
  public List<GameObject> clouds;

  [Header("Scoreboard")]
  public Text LivesLabel;
  public Text ScoreLabel;


  // PRIVATE INSTANCE MEMBERS
  private int _lives;
  private int _score;

  // PUBLIC PROPERTIES
  public int Lives
  {
      get { return _lives; }
      set {
        _lives = value;
        LivesLabel.text = "Lives: " + _lives.ToString();
        if(_lives < 1)
        {
          SceneManager.LoadScene("End");
        }
      }
  }

  public int Score
  {
      get { return _score; }
      set {
        _score = value;
        ScoreLabel.text = "Score: " + _score.ToString();
      }
  }



    // Start is called before the first frame update
    void Start()
    {
      clouds = new List<GameObject>(); // empty list of type GameObject
      _buildCloudList();

      Lives = 5;
      Score = 0;
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
