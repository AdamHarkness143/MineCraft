# Cross

类型: 十字交叉

## PanGu
```
        Vector3fc[] face0 = new Vector3fc[4];
        face0[0]=new Vector3f(0,0,0);
        face0[1]=new Vector3f(1,0,1);
        face0[2]=new Vector3f(1,1,1);
        face0[3]=new Vector3f(0,1,0);
        //1,0,0~0,1,1
        Vector3fc[] face1 = new Vector3fc[4];
        face1[0]=new Vector3f(1,0,0);
        face1[1]=new Vector3f(0,0,1);
        face1[2]=new Vector3f(0,1,1);
        face1[3]=new Vector3f(1,1,0);
        //Face的3号与一号元素对调后(360°翻面),+1(旋转90°);
        //1,1,1~0,0,0
        Vector3fc[] face2 = new Vector3fc[4];
        face2[0]=new Vector3f(1,0,1);
        face2[1]=new Vector3f(0,0,0);
        face2[2]=new Vector3f(0,1,0);
        face2[3]=new Vector3f(1,1,1);
        //0,1,1~1,0,0
        Vector3fc[] face3 = new Vector3fc[4];
        face3[0]=new Vector3f(0,0,1);
        face3[1]=new Vector3f(1,0,0);
        face3[2]=new Vector3f(1,1,0);
        face3[3]=new Vector3f(0,1,1);
```

## 顶点组

```
0,0,0
1,0,1
1,1,1
0,1,0

1,0,0
0,0,1
0,1,1
1,1,0
```
## 三角组
0,1,3,


## Cull

None