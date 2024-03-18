using RayNeo;
using RayNeo.Tool;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GestureDetector : MonoBehaviour
{
    [SerializeField] private GestureManager gestureManager;

    // Start is called before the first frame update
    void Start()
    {
       gestureManager.Start();
        
    }

}
