// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Quantum.Week1 {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Extensions.Diagnostics;
    

    //////////////////////////////////////////////////////////////////
    // Here are several examples of how you can run and test
    // your solutions to the programming assignments in Q#.
    //////////////////////////////////////////////////////////////////

    operation T1_Test () : Unit {
        // Allocate a qubit which you'll pass to the operation
        using (q = Qubit()) {
            // The qubit starts in |0⟩ state, so it is already in the state promised as the input for Task1

            // Call the operation you're testing
            Task1(q);

            // You can print the amplitudes of the wave function to a file using function DumpMachine
            // from namespace Microsoft.Quantum.Extensions.Diagnostics
            DumpMachine("C://Tmp//task1.txt");

            // For this task amplitudes of both |0⟩ and |1⟩ states need to be 1 / sqrt(2);
            // you can check this using operation AssertQubitState
            // from namespace Microsoft.Quantum.Extensions.Testing
            AssertQubitState((Complex(1.0 / Sqrt(2.0), 0.0), Complex(1.0 / Sqrt(2.0), 0.0)), q, 1e-5);

            // Remember to return qubits to state |0⟩ before releasing them
            Reset(q);
        }
    }


    operation T2_Test () : Unit {
        // Allocate a qubit which you'll pass to the operation
        using (q = Qubit()) {
            // There are two possible input states - |0⟩ and |1⟩; 
            // you need to check that your operation's return is correct on both states

            // The qubit starts in |0⟩ state, so it is already in the first of these states

            // Call the operation you're testing and store the result
            let res0 = Task2(q);

            // You can output the intermediary classical variables to console using Message function 
            Message($"Return for state |0⟩ is {res0}");

            // Check that the return matches the expectation
            AssertBoolEqual(res0, false, $"Unexpected return for state |0⟩: {res0}");

            // Return the qubit to state |0⟩ before reusing it
            Reset(q);


            // Repeat the sequence for the second input state |1⟩
            // Start by preparing this state from |0⟩
            X(q);

            let res1 = Task2(q);
            Message($"Return for state |1⟩ is {res1}");
            AssertBoolEqual(res1, true, $"Unexpected return for state |1⟩: {res1}");

            // Remember to return qubits to state |0⟩ before releasing them
            Reset(q);
        }
    }
}
