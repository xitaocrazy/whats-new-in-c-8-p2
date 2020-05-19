using System.Threading.Tasks;
using NetConf.DefaultInterfaceMembers;
using NetConf.IndicesAndRanges;
using NetConf.UsingStatement;

namespace NetConf
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await AsyncIterator.Demo();
            //Pattern.Demo();
            //DefaultInterfaceMember.Demo();
            //IndiceAndRange.Demo();
            UsingStatementSample.Demo();            
            //NullCoalescingAssignment.NullCoalescingAssignment.Demo();
            //StaticLocalFunction.Demo();
            //ReadOnlyMember.Demo();
            //RefStruct.Demo();
            //StackAlloc.StackAlloc.Demo();
            //InterpolatedVerbatimString.Demo();
            //UnmanagedConstraint.UnmanagedConstraint.Demo();
        }
    }
}