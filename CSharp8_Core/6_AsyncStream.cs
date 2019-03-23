using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class AsyncStream
    {
        public async static void Demo()
        {
            await using(var x = new MyAssyncDisposible())
            {
                await foreach (var i in x.GetAllResultAsync())
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    internal class MyAssyncDisposible : IAsyncDisposable
    {
        public async IAsyncEnumerable<int> GetAllResultAsync()
        {
            await foreach (var res in GetResultsAsync())
            {
                if(res > 20)
                {
                    yield return res;
                }
            }
        }

        public async IAsyncEnumerable<int> GetResultsAsync()
        {
            foreach (var num in Enumerable.Range(0,30))
            {
                await Task.Delay(100);
                yield return num;
            }
        }

        public async ValueTask DisposeAsync()
        {
            await Task.Delay(200);
            Console.WriteLine("Dispose async ...");
        }
    }
}
