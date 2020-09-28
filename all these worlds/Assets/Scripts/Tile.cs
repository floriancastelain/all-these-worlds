using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    public int x;
    public int y;
    private Color originalColor;
    private Color overColor = Color.red;
    private MeshRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        originalColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver() {
        renderer.material.color = overColor;
    }
    void OnMouseExit() {
        renderer.material.color = originalColor;
    }
}
