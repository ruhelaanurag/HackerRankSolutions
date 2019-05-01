///Solution to Hacker Rank Problem: Compare the Triplets
///URL: https://www.hackerrank.com/challenges/compare-the-triplets/leaderboard


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2){
        // Complete this function
        List<int>Result = new List<int>();
        int ResultAlice =0;
        int ResultBob =0;
        int[] alice = {a0,a1,a2};
        int[] bob = {b0,b1,b2};
        for(int i=0; i<=2; i++)
        {
            if(alice[i] > bob[i])
                ResultAlice++;
            else if(bob[i]> alice[i])
                ResultBob ++;
        }
        Result.Add(ResultAlice);
        Result.Add(ResultBob);
        return Result.ToArray();
    }

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));
        

    }
}
