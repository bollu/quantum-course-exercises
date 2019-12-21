from sympy import *

coeff = [1 + cos((pi * l) / 3) for l in range(6)]

if False:
    total = 0
    for (l, c) in enumerate(coeff):
        total += c*c
        print("1 + cos(", pi * l / 3, ")=", cos(pi * l / 3), ":",  1 + cos(pi * l / 3))
        print("total after adding(", c,"): ", total)
    
    total = sqrt(total)
    print("total after sqrt:", total)
    assert(total == sqrt(sum(map(lambda x: x*x, coeff))))
    
    
    total = 0
    print("=====")
    for (l, c) in enumerate(coeff):
        total += c*c
        print("1 + sin(", pi * l / 3, ")=", sin(pi * l / 3), ":",  1 + sin(pi * l / 3))
        print("total after adding(", c,"): ", total)
    total = sqrt(total)
    print("total after sqrt:", total)

def dftrow(n, rowi, v):
    # 1 1 1 1 1 
    # 1 2 3 4 5
    coeffs = [cos(2 * pi * k * rowi / n) + I * sin (2 * pi * k * rowi / n) for k in range(n)]
    print("* coeffs: ", coeffs)

    total = 0
    for i in range(n):
        term = coeffs[i] * v[i]
        print("  ", i, " term:" , term)
        total += term
        total = expand(total)
        print("  total at this stage: ", total)
    print("* total: " , expand(total))



v = [1, 1 + sqrt(3) / 2, 1 + sqrt(3) /2, 1, 1 - sqrt(3)/2, 1 - sqrt(3)/2]
print("vec: ", v)
for i in range(6):
    print("######")
    print("DFT ROW", i)
    dftrow(6, i, v)


