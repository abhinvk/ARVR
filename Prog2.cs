
using UnityEngine;
using UnityEngine.UI;

public class Prog2 : MonoBehaviour
{
    public GameObject cube, sphere, plane; // Reference to objects
    public Material newCubeMaterial, newSphereMaterial, newPlaneMaterial; // New materials

    private Renderer cubeRenderer, sphereRenderer, planeRenderer;

    void Start()
    {
        // Get the Renderer components
        cubeRenderer = cube.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        planeRenderer = plane.GetComponent<Renderer>();

        // Find the button and add an event listener
        Button btn = GameObject.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(ChangeMaterials);
    }

    void ChangeMaterials()
    {
        // Change materials when the button is clicked
        cubeRenderer.material = newCubeMaterial;
        sphereRenderer.material = newSphereMaterial;
        planeRenderer.material = newPlaneMaterial;
    }
}
