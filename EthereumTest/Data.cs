using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthereumTest
{
    public static class Data
    {


        public static int[] GetPisanoPeriod5()
        {
            return new int[] { 0, 1, 1, 2, 3, 0, 3, 3, 1, 4, 0, 4, 4, 3, 2, 0, 2, 2, 4, 1 };
           
        }
       


        public static List<Pentagon> GetInitialDodecahedronOffset()
        {
            return new List<Pentagon>(
                new Pentagon[] {
                    new Pentagon { Adjcent = new int[] { 8,4,5,1,9} ,WhiteLine = 4, Bits = new int[] {1, 1,0,0,0}, Blocked = { } }, // 0
                    new Pentagon { Adjcent = new int[] { 0,5,2,10,9} ,WhiteLine = 5 ,Bits =new int[]{0,0,1,1,1 }, Blocked =  { } }, // 1
                    new Pentagon { Adjcent = new int[] { 5,3,11,10,1 } ,WhiteLine = 3,Bits = new int[]{0,0,1,0,1 }, Blocked = new int[]   { 11} }, // 2
                    new Pentagon { Adjcent = new int[] { 4,7,11,2,5} ,WhiteLine = 7,Bits =new int[]{1,1,1,1,1 }, Blocked = { } }, // 3
                    new Pentagon { Adjcent = new int[] { 8,7,3,5,0} ,WhiteLine = 7,Bits =new int[]{ 1,1,1,0,0}, Blocked = { } }, // 4
                    new Pentagon { Adjcent = new int[] { 3,2,1,0,4} ,WhiteLine = 2,Bits =new int[]{ 0,0,1,1,1}, Blocked = { } }, // 5
                    new Pentagon { Adjcent = new int[] { 7,8,9,10,11} ,WhiteLine = 8,Bits =new int[]{ 0,1,0,1,1}, Blocked = { } }, // 6
                    new Pentagon { Adjcent = new int[] { 8,6,11,3,4} ,WhiteLine = 6,Bits =new int[]{0,1,1,0,0 }, Blocked = { } }, // 7
                    new Pentagon { Adjcent = new int[] { 0,9,6,7,4} ,WhiteLine = 9, Bits =new int[]{1,0,1,1,1 },Blocked = { } }, // 8
                    new Pentagon { Adjcent = new int[] { 0,1,10,6,8} ,WhiteLine = 1,Bits =new int[]{0, 1,0,1,1}, Blocked = { } }, // 9
                    new Pentagon { Adjcent = new int[] { 9,1,2,11,6} ,WhiteLine = 1,Bits =new int[]{1, 1,1,1,1}, Blocked = new int[] { 11} }, // 10
                    new Pentagon { Adjcent = new int[] { 6,10,2,3,7} ,WhiteLine = 10, Bits =new int[]{1,1,0,1,1 },Blocked = new int[] { 2,10} }, // 11

        });

        }




  






        public static string GetResultPublicKey()
        {
            return "0x6b2560b34c7469c561a8fce581c88bfb8cce73b2";
        }
    }
}
