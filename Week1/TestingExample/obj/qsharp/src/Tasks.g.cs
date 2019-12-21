#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week1\",\"Name\":\"Task1\"},\"SourceFile\":\"/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tasks.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Week1\",\"Name\":\"Task1\"},\"SourceFile\":\"/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tasks.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week1\",\"Name\":\"Task2\"},\"SourceFile\":\"/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tasks.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Week1\",\"Name\":\"Task2\"},\"SourceFile\":\"/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tasks.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Week1
{
    public class Task1 : Operation<Qubit, QVoid>, ICallable
    {
        public Task1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Task1";
        String ICallable.FullName => "Quantum.Week1.Task1";
        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<Task1, Qubit, QVoid>(q);
        }
    }

    public class Task2 : Operation<Qubit, Boolean>, ICallable
    {
        public Task2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Task2";
        String ICallable.FullName => "Quantum.Week1.Task2";
        public override Func<Qubit, Boolean> Body => (__in__) =>
        {
            var q = __in__;
#line 31 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tasks.qs"
            return false;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<Task2, Qubit, Boolean>(q);
        }
    }
}