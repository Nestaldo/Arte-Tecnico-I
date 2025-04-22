using UnityEngine;

[ExecuteAlways]
public class LavaScript : MonoBehaviour 
{
    [SerializeField] private Transform _player;
    [SerializeField] private Material _lavaMaterial;

    private void Update()
    {
        if(_player != null && _lavaMaterial != null)
        {
            _lavaMaterial.SetVector("_Player_Position", _player.position);
        }
    }
}
