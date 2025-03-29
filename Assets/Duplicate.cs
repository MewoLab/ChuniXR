using System.Runtime.InteropServices;
using UnityEditor.Rendering;
using UnityEngine;

public class Duplicate : MonoBehaviour
{

    [DllImport("chunixr.dll")]
    private static extern void io_init();

    public GameObject toDuplicate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        io_init();
        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                int cell = (x * 2) + y;
                if (cell != 0)
                {
                    GameObject clone = GameObject.Instantiate(toDuplicate);
                    clone.transform.SetParent(transform, worldPositionStays: false);
                    clone.transform.position += new Vector3(0.0375f * x, 0.0f, -0.06f * y);

                    Tap myComponent = clone.GetComponent<Tap>();
                    if (myComponent != null)
                    {
                        myComponent.cell = cell;
                    }
                }
            }
        }   
    }
    
}
