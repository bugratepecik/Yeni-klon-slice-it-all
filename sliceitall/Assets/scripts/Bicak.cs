using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class Bicak : MonoBehaviour
{
    public LayerMask cuttable;
    public Material mat;
    GameObject bicak;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("cuttable"))
        {
            mat = other.GetComponent<MeshRenderer>().material;
            bicak = other.gameObject;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && bicak != null)
        {
            SlicedHull Kesilen = Kes(bicak, mat);
            GameObject KesilenUst = Kesilen.CreateUpperHull(bicak, mat);
            KesilenUst.AddComponent<MeshCollider>().convex = true;
            KesilenUst.AddComponent<Rigidbody>();
            KesilenUst.layer = LayerMask.NameToLayer("cuttable");
            GameObject KesilenAlt = Kesilen.CreateLowerHull(bicak, mat);
            KesilenAlt.AddComponent<MeshCollider>().convex = true;
            KesilenAlt.AddComponent<Rigidbody>();
            KesilenAlt.layer = LayerMask.NameToLayer("cuttable");
            
        }
    }
    public SlicedHull Kes(GameObject obj, Material crossSectionMaterial = null)
    {
        return obj.Slice(transform.position, transform.up, crossSectionMaterial);
    }
}
