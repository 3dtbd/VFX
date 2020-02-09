using UnityEngine;

namespace WizardsCode.VFX
{
    /// <summary>
    /// Cause a light to flicker by varying its color.
    /// </summary>
    public class FlickeringLight : MonoBehaviour
    {
        [Tooltip("The minimum intensity of the light.")]
        public float minIntensity = 0.7f;
        [Tooltip("The maximum intensity of the light.")]
        public float maxIntensity = 1.3f;
        [Tooltip("The frequency of changes in the intensity.")]
        public float frequency = 0.5f;

        private float originalIntensity;
        new private Light light;
        float nextChangeTime = 0;

        // Store the original color
        void Start()
        {
            light = GetComponent<Light>();
            originalIntensity = light.intensity;
        }

        void Update()
        {
            if (Time.time > nextChangeTime)
            {
                light.intensity = Random.Range(minIntensity, maxIntensity);
                nextChangeTime = Time.time + frequency;
            }
        }
    }
}
