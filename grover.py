#!/usr/bin/env python3
import numpy as np
from sympy import *
from numpy.linalg import *


def f_to_unitary(f):
    pass

def statemagnitude(s):
    return (np.dot(s.T, s.conj()))

def initstate():
    s = np.zeros(shape=(8, 1), dtype=np.complex)
    for i in range(8):
        s[i][0] = 1.0 / np.sqrt(8.0)

    print("init state magnitude: ", statemagnitude(s))
    return s

def us():
    s = np.ones(shape=(8, 8), dtype=np.complex)
    s = 2 * 1.0 / 8.0
    eye = np.identity(8, dtype=np.complex)
    return s - eye


def uw(is_):
    m = np.identity(8, dtype=np.complex)
    for i in is_:
        m[i][i] -= 2
    return m

def isunitary(u):
    print(np.matmul(u, u.T))

if __name__ == "__main__":
    s = initstate()
    print("s0:" , s)
    s = np.matmul(uw([3]), s)
    print("s1:", s)
    s = np.matmul(us(), s)
    print("s2:", s)
