using System.Collections;
using UnityEngine;

public class GlitchHologramController : MonoBehaviour
{
    [SerializeField] private Vector3 _timeValues;
    private Material _hologram;
    private void Awake()
    {
        _hologram = GetComponent<Renderer>().material;
    }
    private void Start()
    {
        StartCoroutine(Glitch());
    }
    private IEnumerator Glitch()
    {
        while (true)
        {
            _hologram.SetFloat("_Change_Side_Glitch", 0);
            yield return new WaitForSecondsRealtime(Random.Range(_timeValues.x, _timeValues.y));
            _hologram.SetFloat("_Enable_Glitch", 1);
            yield return new WaitForSecondsRealtime(Random.Range(_timeValues.x, _timeValues.z));
            _hologram.SetFloat("_Enable_Glitch", 0);

            _hologram.SetFloat("_Change_Side_Glitch", 1);
        }
    }
}
