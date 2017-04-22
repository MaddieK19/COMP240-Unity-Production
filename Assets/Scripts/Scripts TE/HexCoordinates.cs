using UnityEngine;

[System.Serializable]
/*section for getting co-ordinates of hexagons*/
public struct HexCoordinates
{

    public int X { get; private set; }

    public int Z { get; private set; }

    public HexCoordinates(int x, int z)
    {
        X = x;
        Z = z;

    }
    public static HexCoordinates FromOffsetCoordinates(int x, int z)
    {
        return new HexCoordinates(x - z / 2, z);
    }
    public int Y
    {
        get
        {
            return -X - Z; //working out y co-ordinate
        }
    }
    public override string ToString()
    {
        return "(" + X.ToString() + ", " + Y.ToString() + Z.ToString() + ")";
    }

    public string ToStringOnSeparateLines()
    {
        return X.ToString() + "\n" + Y.ToString() + "\n" + Z.ToString();
    }

    public static HexCoordinates FromPosition(Vector3 position)//working out which cells we are touching
    {
        float x = position.x / (HexMetrics.innerRadius * 2f);//dividing x by wisth a hexagon
        float y = -x; //mirror of x
        float offset = position.z / (HexMetrics.outerRadius * 3f);
        x -= offset;//z co-ordinate isnt zero so shift to accomidate that
        y -= offset;
        int iX = Mathf.RoundToInt(x);
        int iY = Mathf.RoundToInt(y);//rounding to ints to to get the co-ordinates
        int iZ = Mathf.RoundToInt(-x - y);
        if (iX + iY + iZ != 0)
        {
            float dX = Mathf.Abs(x - iX); //reconstucting co-oridnates due to rounding error which occur with a large amount of rounding
            float dY = Mathf.Abs(y - iY);
            float dZ = Mathf.Abs(-x - y - iZ);

            if (dX > dY && dX > dZ)
            {
                iX = -iY - iZ;
            }
            else if (dZ > dY)
            {
                iZ = -iX - iY;
            }
        }

        return new HexCoordinates(iX, iZ);
    }
}
