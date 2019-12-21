// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Quantum.Week1 {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    
    
    //////////////////////////////////////////////////////////////////
    // Here are the example tasks used to show Q# testing.
    // The testing code can be found in the Tests.qs file.
    //////////////////////////////////////////////////////////////////

    // Task 1. Superposition
    // Input: a qubit in |0⟩ state.
    // Goal: create the following state on this qubit: (|0⟩ + |1⟩) / sqrt(2).
    operation Task1 (q : Qubit) : Unit {
        // This state can be created using the Hadamard gate.
        // Type the following: H(q);
    }

    
    // Task 2. Measurements
    // Input: a qubit which is guaranteed to be in |0⟩ or |1⟩ state
    // Output: true if qubit was in |1⟩ state, or false if it was in |0⟩ state.
    // The state of the qubit at the end of the operation does not matter.
    operation Task2 (q : Qubit) : Bool {
        // Replace the returned expression with (M(q) == One)
        return false;
    }
}
