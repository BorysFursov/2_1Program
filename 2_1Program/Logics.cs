using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Program
{
    class Logics
    {   
        private static string[] parseString(string str)
        {
            var separators = new string[] { ", " };
            var res = str.Split(separators, StringSplitOptions.None);
            return res;
        }
        public static string GetResult(string str)
        {
            var result = "";
            string[] arr = parseString(str);
            if(arr.Length == 1)
            {
                try
                {
                    result = "result of cubing is :"+ Math.Pow(Int32.Parse(arr[0]), 3).ToString();
                }
                catch (Exception ex)
                {

                    result = ex.Message;
                }
                return result;
            }
            else
            {
                var min = Int32.MaxValue;
                var max = Int32.MinValue;
                int[] intRes = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    try
                    {
                        intRes[i] = Int32.Parse(arr[i]);
                    }
                    catch (Exception ex)
                    {

                        return ex.Message;
                    }
                }
                foreach (var item in intRes)
                {
                    if (min > item)
                    {
                        min = item;
                    }
                    if( max < item)
                    {
                        max = item;
                    }
                }
                return "minimum :" + min + "maximum:" + max; 
            }
        }
    }
}
