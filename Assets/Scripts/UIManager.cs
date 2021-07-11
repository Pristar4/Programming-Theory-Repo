using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   [SerializeField] private LoadSceneMode Sceneid;

   public void LoadScene(int Sceneid)
   {
      SceneManager.LoadScene(Sceneid);
   }
}
