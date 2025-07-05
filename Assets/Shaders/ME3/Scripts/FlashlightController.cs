using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightController : MonoBehaviour
{
    [SerializeField] GameObject flashLight;
    private bool activeFlashlight;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            activeFlashlight = !activeFlashlight;
            ChangeFlashlightState();
        }
    }
    public void ChangeFlashlightState()
    {
        flashLight.SetActive(activeFlashlight);
    }
}
