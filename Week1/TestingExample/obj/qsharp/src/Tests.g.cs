#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week1\",\"Name\":\"T1_Test\"},\"SourceFile\":\"/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Week1\",\"Name\":\"T1_Test\"},\"SourceFile\":\"/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week1\",\"Name\":\"T2_Test\"},\"SourceFile\":\"/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Week1\",\"Name\":\"T2_Test\"},\"SourceFile\":\"/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Week1
{
    public class T1_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T1_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T1_Test";
        String ICallable.FullName => "Quantum.Week1.T1_Test";
        protected ICallable MicrosoftQuantumExtensionsDiagnosticsDumpMachine
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        protected ICallable<((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex),Qubit,Double), QVoid> MicrosoftQuantumExtensionsTestingAssertQubitState
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Task1
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 20 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                var q = Allocate.Apply();
#line 24 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                Task1.Apply(q);
#line 28 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                MicrosoftQuantumExtensionsDiagnosticsDumpMachine.Apply("C://Tmp//task1.txt");
#line 33 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubitState.Apply(((new Microsoft.Quantum.Extensions.Math.Complex(((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(2D)), 0D)), new Microsoft.Quantum.Extensions.Math.Complex(((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(2D)), 0D))), q, 1E-05D));
#line 36 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                Reset.Apply(q);
#line hidden
                Release.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsDiagnosticsDumpMachine = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpMachine<>));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.MicrosoftQuantumExtensionsTestingAssertQubitState = this.Factory.Get<ICallable<((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex),Qubit,Double), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubitState));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.Task1 = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Task1));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T1_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T2_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T2_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T2_Test";
        String ICallable.FullName => "Quantum.Week1.T2_Test";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<Qubit, Boolean> Task2
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 43 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                var q = Allocate.Apply();
#line 50 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                var res0 = Task2.Apply(q);
#line 53 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                Message.Apply(String.Format("Return for state |0⟩ is {0}", res0));
#line 56 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                MicrosoftQuantumCanonAssertBoolEqual.Apply((res0, false, String.Format("Unexpected return for state |0⟩: {0}", res0)));
#line 59 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                Reset.Apply(q);
#line 64 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(q);
#line 66 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                var res1 = Task2.Apply(q);
#line 67 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                Message.Apply(String.Format("Return for state |1⟩ is {0}", res1));
#line 68 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                MicrosoftQuantumCanonAssertBoolEqual.Apply((res1, true, String.Format("Unexpected return for state |1⟩: {0}", res1)));
#line 71 "/home/bollu/iiit/assignments/quantum/Week1/TestingExample/Tests.qs"
                Reset.Apply(q);
#line hidden
                Release.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.Task2 = this.Factory.Get<ICallable<Qubit, Boolean>>(typeof(Task2));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T2_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}