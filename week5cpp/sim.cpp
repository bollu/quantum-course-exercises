#include <bitset>
#include <iostream>
#include <string>
#include <complex>
#include <vector>
#include <cmath>
using namespace std;
using K = int;
#define S std::vector<complex<float>>
// using std::vector<complex<float>> = State;
static const float EPSILON = 1e-3;

K sadd(S s) {
    if (!s.size()) {
        s.push_back(complex<float>(0));
        s.push_back(complex<float>(1)); return 0;
    }
}

void Sprint(S s) {
    if (s.size() == 0) return;
    const int n = log2(s.size());
    int cnt = 0;
    for(int i = 0; i < s.size(); i++) {
        complex<float> c = s[i];
        if (abs(c) < EPSILON) continue;
        if (cnt++) cout << " + ";
        cout << "(" << c << ")" << "|" << bitset<n>(i) << ">";
        cout << "\n";
    }
}

int main() {
    return 0;
}
