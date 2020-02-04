using UnityEngine.SceneManagement;
using UnityEngine;

public class collisionWPlayer : MonoBehaviour {

    private string theCollider;

    void OnTriggerEnter(Collider other)
    {
        theCollider = other.tag;
        if (theCollider == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("pergamentMenu");
        }
    }
}
