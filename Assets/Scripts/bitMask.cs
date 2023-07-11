using UnityEngine;

public static class bitMask
{
    public static int GetBitMask(gridElement[] nearGE)
    {
        int bitMask = 0;

        if (nearGE[0] != null)
        {
            if (nearGE[0].GetEnable())
            {
                bitMask += 1;
            }
        }

        if (nearGE[1] != null)
        {
            if (nearGE[1].GetEnable())
            {
                bitMask += 2;
            }
        }

        if (nearGE[2] != null)
        {
            if (nearGE[2].GetEnable())
            {
                bitMask += 4;
            }
        }

        if (nearGE[3] != null)
        {
            if (nearGE[3].GetEnable())
            {
                bitMask += 8;
            }
        }

        if (nearGE[4] != null)
        {
            if (nearGE[4].GetEnable())
            {
                bitMask += 16;
            }
        }

        if (nearGE[5] != null)
        {
            if (nearGE[5].GetEnable())
            {
                bitMask += 32;
            }
        }

        if (nearGE[6] != null)
        {
            if (nearGE[6].GetEnable())
            {
                bitMask += 64;
            }
        }

        if (nearGE[7] != null)
        {
            if (nearGE[7].GetEnable())
            {
                bitMask += 128;
            }
        }


        return bitMask;
    }
}
