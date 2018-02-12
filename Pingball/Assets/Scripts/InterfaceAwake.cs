
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour {
    private void Start()
    {
        GameManager.point = 0;
    }

    public void Click()
    {
        SceneManager.LoadScene("Pinball");
    }
}
