using System.IO;
using System.Reflection;

namespace Akka.MultiNode.TestAdapter.SampleTests
{
    /// <summary>
    /// SampleTestsMetadata
    /// </summary>
    public static class SampleTestsMetadata
    {
        /// <summary>
        /// Sample tests assembly path
        /// </summary>
        public static string AssemblyPath => typeof(SampleMultiNodeSpec).Assembly.Location;
        /// <summary>
        /// Gets assembly file name
        /// </summary>
        public static string AssemblyFileName => typeof(SampleMultiNodeSpec).Assembly.GetName().Name + ".dll";
    }
}