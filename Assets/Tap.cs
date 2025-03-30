using System.Runtime.InteropServices;
using UnityEngine;

public class Tap : MonoBehaviour
{

    [DllImport("chunixr.dll")]
    private static extern void io_send_slider(uint index, bool value);

    public int cell;

    private void Start()
    {
        Debug.Log(cell);
    }

    private void OnTriggerEnter(Collider Player)
    {
        io_send_slider((uint)cell, true);
    }

    private void OnTriggerExit(Collider Player)
    {
        io_send_slider((uint)cell, false);
    }
}