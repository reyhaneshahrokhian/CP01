#include <bits/stdc++.h>

#define int long long

using namespace std;

int32_t main(void){
  int n;
  cin >> n;
  int a[n], b[n], c[1000007], ans;
  for(int i = 0; i < n && cin >> a[i]; i++) b[i] = a[i];
  sort(b, b + n);
  for(int i = 0 ;i < n; i++){
    auto lower = lower_bound(b, b + n, a[i]) - b + 1;
    int t = 0;
    for(int j = lower; j > 0; j -= j&-j) t += c[j];
    ans += (i - t) * (lower - 1 - t);
    while (lower <= n){
        c[lower]++;
        lower += lower&-lower;
    }
  }
  cout << ans << endl;
}