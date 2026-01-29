/// <summary>
/// From: https://www.geeksforgeeks.org/problems/interleave-the-first-half-of-the-queue-with-second-half/1
/// 
/// Problem: 
/// Given a queue q[] of even size. Your task is to rearrange the
/// queue by interleaving its first half with the second half.
/// Interleaving is the process of mixing two sequences by alternating 
/// their elements while preserving their relative order.
/// In other words, Interleaving means place the first element from the 
/// first half and then first element from the 2nd half and again second 
/// element from the first half and then second element from the 2nd half and so on....
/// Example:
/// Input: q[] = [2, 4, 3, 1]
/// Output: [2, 3, 4, 1]
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChallenge
{
    public static class Jan302026
    {
        public static int[] Interleave(int[] q)
        {
            int[] interLeavedQ = new int[q.Length];
            int[] firstHalf = q.Where((el, index) => index < q.Length / 2).ToArray();
            int[] secondHalf = q.Where((el, index) => index >= q.Length / 2).ToArray();

            int j = 0;
            for (int i = 0; i <= firstHalf.Length - 1; i++)
            {
                interLeavedQ[j] = firstHalf[i];
                j++;
                interLeavedQ[j] = secondHalf[i];
                j++;
            }
            return interLeavedQ;
        }
    }
}
