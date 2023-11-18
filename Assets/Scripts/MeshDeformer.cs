using UnityEngine;

public class MeshDeformer : MonoBehaviour
{
    public float deformationAmount = 1.0f;

    void Start()
    {
        DeformMesh();
    }

    void DeformMesh()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;

        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i].y += Mathf.Sin(vertices[i].x) * deformationAmount;
        }

        mesh.vertices = vertices;
        mesh.RecalculateNormals();
    }
}
