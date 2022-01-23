using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level : MonoBehaviour
{
    // Start is called before the first frame update
      
    public void Play()
    {
        int selectedCharacter =
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        
        Gamemanager.instance.CharIndex = selectedCharacter;
        SceneManager.LoadScene("Gamearea");

        //SceneManager.LoadScene("Gamearea");
    }
   
      

}
