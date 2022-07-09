using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Minecraft.Voxel
{
    [RequireComponent(typeof(MeshRenderer))]
    public class VoxelRender: MonoBehaviour
    {
        public VoxelMesh VoxelMesh;

        private void OnEnable()
        {
            GetComponent<MeshFilter>().mesh = GenerateMesh();
        }

        private Mesh GenerateMesh()
        {
            int vertIndex = 0;
            List<Vector3> vertexs = new List<Vector3>();
            List<Vector2> uvs = new List<Vector2>();
            List<int> triangles = new List<int>();
           // List<Vector3> normals = new List<Vector3>();
            Mesh mesh = new Mesh();
             
            //遍历每一个面
            foreach (var faceMeshData in VoxelMesh.faces)
            {
                Debug.Log("Rendering For Face "+faceMeshData.direction);
                //根据三角形的数量,进行遍历
                for (var i = 0; i < faceMeshData.triangles.Length; i++)
                {
                    //triangles储存的是组成这个三角形对应的vertData在vertexs中的位置
                    var triangleIndex = faceMeshData.triangles[i];
                    var vertData = faceMeshData.vertData[triangleIndex];
                    //将三角形的顶点位置存到
                    vertexs.Add(vertData.position);
                    uvs.Add(vertData.uv);
                    triangles.Add(vertIndex);
                   // normals.Add(faceMeshData.normal);
                    vertIndex++;
                }
            }

            mesh.vertices = vertexs.ToArray();
            mesh.triangles = triangles.ToArray();
            mesh.uv = uvs.ToArray();
            mesh.RecalculateNormals();
           // mesh.normals = normals.ToArray();
            return mesh;
        }
    }
}