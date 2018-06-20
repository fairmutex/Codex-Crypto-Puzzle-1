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
    //https://ethereum.stackexchange.com/questions/25208/generate-ethereum-address-in-c
    class Program
    {



        // or GetRandomHexNumber(random, 32);
        static void Main(string[] args)
        {
            string bits = Laboratory.Execute();
            var hex = Utils.BinaryStringToHexString(bits.Substring(0, 255));
            BigInteger number1 = BigInteger.Parse(hex, NumberStyles.AllowHexSpecifier);
            Console.WriteLine(hex);
            string PublicKey = Utils.GetPublicKey(hex).ToLower();
            Console.WriteLine(PublicKey);
            Console.ReadKey();
        }



      
    }
}
