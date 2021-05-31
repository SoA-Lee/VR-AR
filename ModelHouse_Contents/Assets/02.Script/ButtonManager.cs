using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public Material Tile01;
    public Material Tile02;

    public GameObject Floor;
    public void setTile01()
    {
        Floor.GetComponent<MeshRenderer>().material = Tile01;
    }
    public void setTile02()
    {
        Floor.GetComponent<MeshRenderer>().material = Tile02;
    }
}
