using UnityEngine;
using System.Collections;

public class PieceScript
{

    public bool[,] pieceGrid;

    private bool[,] makearray4x4_L()
    {
        bool[,] boolmap_L = new bool[4, 4];

        //false all
        for (int x = 0; x < 4; x++) { for (int y = 0; y < 4; y++) { boolmap_L[x, y] = false; } }

        boolmap_L[0, 1] = true;
        boolmap_L[1, 1] = true;
        boolmap_L[2, 1] = true;
        boolmap_L[2, 0] = true;
        return boolmap_L;
    }

    private bool[,] makearray4x4_L2()
    {
        bool[,] boolmap_L2 = new bool[4, 4];

        //false all
        for (int x = 0; x < 4; x++) { for (int y = 0; y < 4; y++) { boolmap_L2[x, y] = false; } }

        boolmap_L2[0, 1] = true;
        boolmap_L2[1, 1] = true;
        boolmap_L2[2, 1] = true;
        boolmap_L2[2, 2] = true;
        return boolmap_L2;
    }
    private bool[,] makearray4x4_I()
    {
        bool[,] boolmap_I = new bool[4, 4];

        //false all
        for (int x = 0; x < 4; x++) { for (int y = 0; y < 4; y++) { boolmap_I[x, y] = false; } }

        boolmap_I[0, 1] = true;
        boolmap_I[1, 1] = true;
        boolmap_I[2, 1] = true;
        boolmap_I[3, 1] = true;
        return boolmap_I;
    }

    private bool[,] makearray4x4_S()
    {
        bool[,] boolmap_S = new bool[4, 4];

        for (int x = 0; x < 4; x++) { for (int y = 0; y < 4; y++) { boolmap_S[x, y] = false; } }

        boolmap_S[1, 2] = true;
        boolmap_S[1, 3] = true;
        boolmap_S[2, 1] = true;
        boolmap_S[2, 2] = true;
        return boolmap_S;
    }

    private bool[,] makearray4x4_S2()
    {
        bool[,] boolmap_S = new bool[4, 4];

        for (int x = 0; x < 4; x++) { for (int y = 0; y < 4; y++) { boolmap_S[x, y] = false; } }

        boolmap_S[1, 0] = true;
        boolmap_S[1, 1] = true;
        boolmap_S[2, 1] = true;
        boolmap_S[2, 2] = true;
        return boolmap_S;
    }

    private bool[,] makearray4x4_O()
    {
        bool[,] boolmap_O = new bool[4, 4];

        for (int x = 0; x < 4; x++) { for (int y = 0; y < 4; y++) { boolmap_O[x, y] = false; } }

        boolmap_O[1, 1] = true;
        boolmap_O[1, 2] = true;
        boolmap_O[2, 1] = true;
        boolmap_O[2, 2] = true;
        return boolmap_O;
    }

    private bool[,] makearray4x4_T()
    {
        bool[,] boolmap_T = new bool[4, 4];

        for (int x = 0; x < 4; x++) { for (int y = 0; y < 4; y++) { boolmap_T[x, y] = false; } }

        boolmap_T[1, 2] = true;
        boolmap_T[2, 1] = true;
        boolmap_T[2, 3] = true;
        boolmap_T[2, 2] = true;
        return boolmap_T;
    }

    public bool[,] rotateMatrixLeft(bool[,] matrix)
    {
        /* W and H are already swapped */
        int w = 4;
        int h = 4;
        bool[,] ret = new bool[h, w];
        for (int i = 0; i < h; ++i)
        {
            for (int j = 0; j < w; ++j)
            {
                int s = h - i - 1;
                ret[i, j] = matrix[j, s];
            }
        }
        pieceGrid = ret;

        return ret;
    }


    public PieceScript(int x)
    {

        switch (x)
        {
            case 0:
               pieceGrid= makearray4x4_L();
                break;
            case 1:
               pieceGrid= makearray4x4_L2();
                break;
            case 2:
               pieceGrid= makearray4x4_I();
                break;
            case 3:
               pieceGrid= makearray4x4_S();
                break;
            case 4:
               pieceGrid= makearray4x4_S2();
                break;

            case 5:
               pieceGrid= makearray4x4_O();
                break;

            case 6:
               pieceGrid= makearray4x4_I();
                break;
        }


    }
}