using MSBuildSampleForGitHubActions.Library;
using System;

namespace MSBuildSampleForGitHubActions
{
    /// <summary>
    /// Entry point to execute this program.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Executes this program.
        /// </summary>
        internal static void Main()
        {
            Console.WriteLine(HelloWorld.Text);
        }
    }
}
