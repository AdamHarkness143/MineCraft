using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minecraft.Voxel
{

    [CreateAssetMenu (menuName = "Minecraft/Voxel/Cross")]
    public class VoxelMesh : ScriptableObject
    {
        public string blockName;
        public FaceMeshData[] faces;
    }

    [Serializable]
    public class VertData
    {
        public Vector3 position;
        public Vector2 uv;
    }

    [Serializable]
    public class FaceMeshData
    {
        public string direction;
        public Vector3 normal;
        public VertData[] vertData;
        public int[] triangles;
    }
}