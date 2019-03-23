using System;
using System.Collections.Async;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class AsyncStream
    {
        public async static void Demo()
        {
            //await using(var x = new )
        }
    }

    internal class MyAssyncDisposible : IAsyncDisposible
    {
        //public async IAsyncEnumerable<int> GetAllResultAsync()
        //{
        //    await foreach (var res in GetResultsAsync)
        //    {

        //    }
        //}

        //public async IAsyncEnumerable<int> GetResultsAsync()
        //{
        //    for (int i = 0; i < 30; i++)
        //    {
        //        await Task.Delay(100);
        //        yield return i;
        //    }
        //}

        private static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            var nums = System.Linq.Enumerable.Range(0, 10);
            foreach (var num in nums)
            {
                await Task.Delay(100);
                yield return num;
            }
        }

        //public async ValueTask DisposeAsync()
        //{
        //    await Task.Delay(200);
        //    Console.WriteLine("Dispose async ...");
        //}
    }
}
