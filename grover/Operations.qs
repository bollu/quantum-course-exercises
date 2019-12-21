namespace grover
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation f1(x: Qubit[], y: Qubit): Unit {
        (Controlled X)(x, y);
    }

    operation HelloQ () : Unit {
        using (qs = Qubit[3]) {
            DumpRegister((), Reverse(qs));
        }
    }
}
