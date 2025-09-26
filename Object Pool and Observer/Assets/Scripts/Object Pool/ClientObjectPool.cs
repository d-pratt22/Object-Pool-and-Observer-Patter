using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.ObjectPool
{
    public class ClientObjectPool : MonoBehaviour
    {
        private DroneObjectPool _pool;

        void Start()
        {
            _pool = gameObject.AddComponent<DroneObjectPool>();
        }

        void OnGUI()
        {
            if (GUILayout.Button("Spawn Drones"))
                _pool.Spawn();

            if (GUILayout.Button("Go to Observer"))
            {
                SceneManager.LoadScene("Observer");
            }
        }
    }
}