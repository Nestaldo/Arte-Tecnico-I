using UnityEngine;

public class DitheringController : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    
    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalVector("_PlayerPos", _playerTransform.position);
    }
}
