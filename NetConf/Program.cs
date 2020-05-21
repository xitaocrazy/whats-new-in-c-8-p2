using System.Threading.Tasks;
using NetConf.AsyncIterators;
using NetConf.DefaultInterfaceMembers;
using NetConf.IndicesAndRanges;
using NetConf.InterpolatedVerbatimStrings;
using NetConf.NullCoalescingAssignment;
using NetConf.Patterns;
using NetConf.ReadOnlyMembers;
using NetConf.RefStructs;
using NetConf.StackAlloc;
using NetConf.StaticLocalFunctions;
using NetConf.UnmanagedConstraint;
using NetConf.UsingStatement;

namespace NetConf
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            await AsyncIterator.Demo();
            Pattern.Demo();
            DefaultInterfaceMember.Demo();
            IndiceAndRange.Demo();
            UsingStatementSample.Demo();            
            NullCoalescingAssignmentSample.Demo();
            StaticLocalFunction.Demo();
            ReadOnlyMember.Demo();
            RefStruct.Demo();
            StackAllocSample.Demo();
            InterpolatedVerbatimString.Demo();
            UnmanagedConstraintSample.Demo();
        }
    }
}