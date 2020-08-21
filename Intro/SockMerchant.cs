using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {


    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {

        int max_sock = ar.Max() + 1; 
        int[] sock_count = new int[max_sock];
        int pair_count = 0;

        for(var i = 0; i < ar.Length; i++) {
            sock_count[ar[i]]++;
        }

        for(var i = 0; i < sock_count.Length; i++) {
            pair_count += sock_count[i] / 2;
        }

        return pair_count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
