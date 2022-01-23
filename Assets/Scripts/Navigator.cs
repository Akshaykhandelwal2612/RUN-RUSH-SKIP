using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Navigator : MonoBehaviour
{
    // Start is called before the first frame update
  public void Home()
    {
        SceneManager.LoadScene("Title");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
