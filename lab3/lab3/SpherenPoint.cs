namespace lab3
{
    class SpherenPoint
    {

        public string poiName;
        public double pX;
        public double pY;
        public double pZ;


        public string sphereName;
        public double sNum;
        public double sX;
        public double sY;
        public double sZ;
        public double sr;

        public SpherenPoint(int n, string pointName, string sphereName, double pX, double pY, double pZ, double sX, double sY, double sZ, double r)
        {
            this.poiName = pointName;
            this.sphereName = sphereName;
            this.pX = pX;
            this.pY = pY;
            this.pZ = pZ;

            this.sNum = n;
            this.sX = sX;
            this.sY = sY;
            this.sZ = sZ;
            this.sr = r;

        }

        public void inputPointCoordinates(string pName, double pvX, double pvY, double pvZ)
        {
            poiName = pName;

            pX = pvX;
            pY = pvY;
            pZ = pvZ;
        }

        public void inputSphereCoordinates(int n, string sName, double svX, double svY, double svZ, double r)
        {
            sphereName = sName;
            sNum = n;
            sX = svX;
            sY = svY;
            sZ = svZ;
            sr = r;
        }
        public void printPoint()
        {
            Console.WriteLine(" Point's Name: " + poiName + ", x: " + pX + ", y: " + pY + ", z: " + pZ);
        }

        public void printSphere( string sName, double svX, double svY, double svZ, double r)
        {
            Console.WriteLine(" Sphere's Name: " + sphereName + ", x: " + sX + ", y: " + sY + ", z: " + sZ + ", r: " + sr);
        }

        public void printSphere2()
        {
            Console.WriteLine(" Sphere's Name: " + sphereName + ", x: " + sX + ", y: " + sY + ", z: " + sZ + ", r: " + sr);
        }
        
        public bool GetLeng()

        {
            double su = Math.Sqrt(Math.Pow(pX - sX, 2) + Math.Pow(pY - sY, 2) + Math.Pow(pZ - sZ, 2));
            if (su<= sr*sr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        

    ~SpherenPoint()
    {

    }

    
    }

    
}
