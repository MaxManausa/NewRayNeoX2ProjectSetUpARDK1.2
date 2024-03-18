using UnityEngine;
using UnityEngine.UI;
public class SecretDoorButton: MonoBehaviour
{
    public Material setMaterial;           // Material to be set temporarily
    public GameObject secretButton;        // Reference to the secret button object

    private Material originalMaterial;     // Original material of the object
    private Renderer objectRenderer;       // Renderer component of the object

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalMaterial = objectRenderer.material;

    }

    public void ActivateSecretButton()
    {
        // Set the object material to the setMaterial
        objectRenderer.material = setMaterial;

        // Activate the secret button
        secretButton.SetActive(true);

        // Start a coroutine to revert the material and deactivate the secret button after 6 seconds
        StartCoroutine(ResetMaterialAndDeactivateButton());
    }

    private System.Collections.IEnumerator ResetMaterialAndDeactivateButton()
    {
        yield return new WaitForSeconds(6f);

        // Reset the object material to the original material
        objectRenderer.material = originalMaterial;

        // Deactivate the secret button
        secretButton.SetActive(false);
    }
}