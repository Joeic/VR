using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class RoomSwitch : MonoBehaviour
{
    void Update()
    {      
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            transform.position = new Vector3(0, 0, 0);
        }
      
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            this.transform.position = new Vector3(0, 0, 0);
        }
    }

    void QuitGame()
    {
#if UNITY_EDITOR
        
        EditorApplication.isPlaying = false;
#else
        
        Application.Quit();
#endif
    }
}
