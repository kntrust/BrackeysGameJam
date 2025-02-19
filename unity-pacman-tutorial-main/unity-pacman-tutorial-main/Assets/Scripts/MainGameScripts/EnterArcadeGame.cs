using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterArcadeGame : MonoBehaviour
{
    [SerializeField] private int SceneNumber;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<FirstPersonController>())
        {
            SceneManager.LoadScene(SceneNumber);
            Debug.Log("—цена загружена");
        }
    }
}
