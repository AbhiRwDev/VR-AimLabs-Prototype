using UnityEngine;
using UnityEngine.SceneManagement;
using Oculus;

public class ResetSceneOnButtonPress : MonoBehaviour
{
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Two))
        {
            ResetScene();
        }
    }

    private void ResetScene()
    {
        // Reloads the current active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
