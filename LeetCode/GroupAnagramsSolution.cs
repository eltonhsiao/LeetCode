using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCode
{
    public class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var output = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var key = String.Concat(str.OrderBy(x => x));
                if (output.ContainsKey(key))
                {
                    output[key].Add(str);
                }
                else
                {
                    output.Add(key, new List<string>());
                    output[key].Add(str);
                }
            }

            return output.Values.ToList();
        }
    }

    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test1()
        {
            var solution = new GroupAnagramsSolution();
            string[] input =
            {
                "eat", "tea", "tan", "ate", "nat", "bat"
            };
            solution.GroupAnagrams(input);
        }
    }
}
