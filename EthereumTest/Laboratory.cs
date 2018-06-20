using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Signer;
using Nethereum.Util;
using Nethereum.RPC.Eth;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EthereumTest
{
    public static class Laboratory
    {

        public static string Execute()
        {
            Console.WriteLine("Laboratory Execute");

            int[] PisanoPeriod5 = Data.GetPisanoPeriod5();
            List<Pentagon> Dodecahedron;
            string bits = "";
            Dodecahedron = Data.GetInitialDodecahedronOffset();
            Pentagon Current = Dodecahedron[7];
            for (int i = 0; i < 255; i++)
            {

                int p = PisanoPeriod5[i % PisanoPeriod5.Length];
                Console.Write(Current.Adjcent[p] + ",");
                bits += Current.Bits[p];
                Current = Dodecahedron[Current.Adjcent[p]];
            }
            Console.WriteLine();
            Console.WriteLine(bits);


            return Utils.ReverseString(bits);
        }

    }
}