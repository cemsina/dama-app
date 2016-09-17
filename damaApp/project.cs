using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damaApp
{
    public static class project
    {
        public static List<string> DataExp(string data, char splitType = ',')
        {
            string[] dataArr = data.Split(splitType);
            List<string> rtrnList = new List<string>();
            foreach (string d in dataArr)
            {
                rtrnList.Add(d);
            }
            return rtrnList;
        }
        class point3D
        {
            public double x;
            public double y;
            public double z;
            public point3D(double x1, double y1, double z1)
            {
                x = x1;
                y = y1;
                z = z1;
            }
        }
    }
   
    
}
