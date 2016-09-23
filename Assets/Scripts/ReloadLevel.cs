using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReloadLevel : MonoBehaviour {

    // Script should go on reload object in the UI canvas

    public void onClick() {
        SceneManager.LoadScene(0);
    }
}
