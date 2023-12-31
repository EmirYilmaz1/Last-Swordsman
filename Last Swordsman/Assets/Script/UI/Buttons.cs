using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Buttons : MonoBehaviour
{

  [SerializeField] int sceneNumber;
  public void GoToShrine()
  {
    PlayerHealtHandler.Instance.UpdateHealtStatsInSceneChange();
    PlayerManaHandler.Instance.UpdateManaStatsInSceneChange();
    Time.timeScale =1;
    FindObjectOfType<AttackHandler>().enabled = true; 
    SceneManager.LoadScene("Shrine");
    PlayerHealtHandler.Instance.OnPlayerDeath = null;
  }

  public void GoToPrototyoeLevel()
  {
    PlayerHealtHandler.Instance.UpdateHealtStatsInSceneChange();
    PlayerManaHandler.Instance.UpdateManaStatsInSceneChange();
    SceneManager.LoadScene(sceneNumber);
  }


}
