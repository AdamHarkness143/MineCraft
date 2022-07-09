# Cube

## 顶点组
```
	new Vector3(0.0f, 0.0f, 0.0f),
    new Vector3(1.0f, 0.0f, 0.0f),
    new Vector3(1.0f, 1.0f, 0.0f),
    new Vector3(0.0f, 1.0f, 0.0f),
    new Vector3(0.0f, 0.0f, 1.0f),
    new Vector3(1.0f, 0.0f, 1.0f),
    new Vector3(1.0f, 1.0f, 1.0f),
    new Vector3(0.0f, 1.0f, 1.0f),
```

## 三角组 
```
    {0, 3, 1, 1, 3, 2}, // Back Face
    {5, 6, 4, 4, 6, 7}, // Front Face
    {3, 7, 2, 2, 7, 6}, // Top Face
    {1, 5, 0, 0, 5, 4}, // Bottom Face
    {4, 7, 0, 0, 7, 3}, // Left Face
    {1, 2, 5, 5, 2, 6} // Right Face

```
## UV组
```
    new Vector2 (0.0f, 0.0f),
    new Vector2 (0.0f, 1.0f),
    new Vector2 (1.0f, 0.0f),
    new Vector2 (1.0f, 0.0f),
    new Vector2 (0.0f, 1.0f),
    new Vector2 (1.0f, 1.0f)
```

## Cull 

如果周围前面有一个方块,就不需要Cull了, 注意和三角组对齐
```
1,0,0 右 
-1,0,0 左
0,1,0 上
0,-1,0 下
0,0,1 前
0,0,-1 后
```