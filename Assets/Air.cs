using System.Runtime.InteropServices;
using UnityEngine;

public class Air : MonoBehaviour
{

    [DllImport("chunixr.dll")]
    private static extern void io_send_air(uint index, bool value);

    public int air;

    private void Start()
    {
        Debug.Log(air);
    }

    private void OnTriggerEnter(Collider Player)
    {
        Debug.Log("Airing all over the place");
        io_send_air((uint)air, true);
    }

    private void OnTriggerExit(Collider Player)
    {
        io_send_air((uint)air, false);
    }
}